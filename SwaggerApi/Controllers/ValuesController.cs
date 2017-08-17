using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerApi.Controllers
{
    /// <summary>
    /// 应用值相关接口
    /// </summary>
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetList()
        {
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// 获取值接口
        /// </summary>
        /// <param name="id">值id</param>
        /// <returns></returns>
        // GET api/values/5
        public string GetValue(int id)
        {
            return "5一通阮";
        }

        // POST api/values
        public void PostValue([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
