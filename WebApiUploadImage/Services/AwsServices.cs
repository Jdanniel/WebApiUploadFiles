using Amazon.S3.Model;
using Amazon.S3;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using WebApiUpload.Configs;
using WebApiUpload.Wrappers;
using WebApiUpload.Interfaces;

namespace WebApiUpload.Services
{
    public class AwsServices : IAwsServices
    {
        private readonly GetnetConfig _getnetConfig;

        public AwsServices(IOptions<GetnetConfig> options)
        {
            _getnetConfig = options.Value;
        }

        public async Task<Wrapper> Delete(string FileName)
        {
            List<string> msgs = new();

            using (var client = new AmazonS3Client(Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID"), Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY"), Amazon.RegionEndpoint.USEast1))
            {
                try
                {
                    var deleteObjectRequest = new DeleteObjectRequest
                    {
                        BucketName = Environment.GetEnvironmentVariable("AwsBucketName"),
                        Key = $"{_getnetConfig.PathS3}/" + FileName,
                    };

                    await client.DeleteObjectAsync(deleteObjectRequest);

                    Wrapper wrapper = new Wrapper(200, null, msgs);
                    return wrapper;
                }
                catch (AmazonS3Exception amazonS3Exception)
                {
                    if (amazonS3Exception.ErrorCode != null &&
                        (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId") || amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                    {
                        msgs.Add("Credenciales no validas - el archivo no se cargo. " + amazonS3Exception.Message + ", " + amazonS3Exception.ErrorCode);
                        Wrapper wrapper = new Wrapper(100, null, msgs);
                        return wrapper;
                    }
                    msgs.Add("Unspecified error attempting to upload data: " + amazonS3Exception.Message + ", " + amazonS3Exception.ErrorCode);
                    Wrapper wrapperE = new Wrapper(100, null, msgs);
                    return wrapperE;
                }
            }
        }

        public async Task<Wrapper> Upload(IFormFile formFile, string FileName)
        {
            List<string> msgs = new List<string>();

            using (var sm = new MemoryStream())
            {
                await formFile.CopyToAsync(sm);

                using (var client = new AmazonS3Client(Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID"), Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY"), Amazon.RegionEndpoint.USEast1))
                {
                    try
                    {
                        var putRequest1 = new PutObjectRequest
                        {
                            BucketName = Environment.GetEnvironmentVariable("AwsBucketName"),
                            Key = $"{_getnetConfig.PathS3}/" + FileName,
                            InputStream = sm
                        };

                        PutObjectResponse Objresponse = await client.PutObjectAsync(putRequest1);

                        Wrapper wrapper = new Wrapper(200, Objresponse, msgs);
                        return wrapper;
                    }
                    catch (AmazonS3Exception amazonS3Exception)
                    {
                        if (amazonS3Exception.ErrorCode != null &&
                            (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId") || amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                        {
                            msgs.Add("Credenciales no validas - el archivo no se cargo. " + amazonS3Exception.Message + ", " + amazonS3Exception.ErrorCode);
                            Wrapper wrapper = new Wrapper(100, null, msgs);
                            return wrapper;
                        }
                        msgs.Add("Unspecified error attempting to upload data: " + amazonS3Exception.Message + ", " + amazonS3Exception.ErrorCode);
                        Wrapper wrapperE = new Wrapper(100, null, msgs);
                        return wrapperE;
                    }
                }
            }
        }
    }
}
