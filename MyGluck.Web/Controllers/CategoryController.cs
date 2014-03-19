using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyGluck.Dal.Implementation;
using MyGluck.Domain;

namespace MyGluck.Web.Controllers
{
    public class CategoryController : ApiController
    {
        // GET api/category
        [HttpGet]
        public List<Category> Get()
        {
            return new CategoryDaoImpl().SelectAll();
        }
        [HttpGet]
        // GET api/category/5
        public Category Get(int id)
        {
            return new CategoryDaoImpl().SelectByKey(new Category { CategoryId=id });
        }

        [HttpPost]
        // POST api/category
        public void Post([FromBody]Category category)
        {
            category.Photo = "";
            new CategoryDaoImpl().Insert(category);
        }

        [HttpPut]
        // PUT api/category/5
        public void Put([FromBody]Category category)
        {
            new CategoryDaoImpl().Update(category);
        }

        [HttpDelete]
        // DELETE api/category/5
        public void Delete(int CategoryId)
        {
            new CategoryDaoImpl().Delete(new Category { CategoryId = CategoryId });
        }
    }
}
