using Microsoft.AspNetCore.Mvc;
using System;

namespace WebCallerClient.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("1")]
        public string GetHello1()
        {
            return "TeacherService.Hello1".WpcParam("Jim").Get<string>();
        }


        [HttpGet("2")]
        public DateTime GetHello2()
        {
            return "TeacherService.Hello2".WpcParam(DateTime.Now).Get<DateTime>();
        }


        [HttpGet("3")]
        public int GetHello3()
        {
            return "TeacherService.Hello3".WpcParam(12.34).Get<int>();
        }


        [HttpGet("4")]
        public int GetHello4()
        {
            return "TeacherService.Hello4".WpcParam(new { Value=12.34,time= DateTime.Now }).Get<int>();
        }


        [HttpGet("5")]
        public string GetHello5()
        {
            return "TeacherService.Hello5".NoWpcParam().Get<string>();
        }

        [HttpGet("6")]
        public string GetHello6()
        {
            return "TeacherService.Hello6".WpcParam(new { Indexs = new int[] { 1,2,3,4 }, name="abc" }).Get<string>();
        }

        [HttpGet("7")]
        public string GetHello7()
        {
            return "Hello7".WpcParam(new { Indexs = new int[] { 1, 2, 3, 4 }, name = "abc" }).Get<string>();
        }
    }
}
