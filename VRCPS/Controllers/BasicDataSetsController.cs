using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Description;
using VRCPS.Context;
using VRCPS.Models;

namespace VRCPS.Controllers
{
    public class BasicDataSetsController : ApiController
    {
        private PersistenceSystemContext db = new PersistenceSystemContext();
               
        [Route("data/{data}/echo")]
        [HttpGet]
        public string EchoData(string data)
        {
            return data;
        }

        [Route("setdata/{creator}/{world}/{associatedId}/{obj}/{data}")]
        [HttpGet]
        public string SetBasicData(string creator, string world, string associatedId,string obj, string data)
        {
            try
            {
                var basicDataSet = new BasicDataSet();

                basicDataSet.CreatorId = creator;
                basicDataSet.WorldId = world;
                basicDataSet.AssociatedId = associatedId;
                basicDataSet.ObjectId = obj;
                basicDataSet.ObjectData = data;

                db.BasicDataSets.Add(basicDataSet);
                db.SaveChanges();

                return "OK!";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}