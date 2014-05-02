using _20140501_cow_jQuery_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _20140501_cow_jQuery_CRUD.Controllers
{
    public class ShippersController : ApiController
    {

        NorthwindEntities ne = new NorthwindEntities();
        public ShippersController()
        {
            ne.Configuration.ProxyCreationEnabled = false;  
        
      }
        public IEnumerable<Shipper> Get()  //http://localhost:45139/api/Shippers
        {
            return ne.Shippers;
        }

        public void POST(Shipper obj)
        {


            ne.Shippers.Add(obj);  //_存到資料庫設定
            ne.SaveChanges(); //_存到資料庫設定
        }
        public void Put(int id, Shipper obj)//帶2參數
        {
            obj.ShipperID = id;//server端直接帶參數或在前台clinet端寫(委託人客戶)
            ne.Entry(obj).State = EntityState.Modified; //.Entry(obj).State可用來讀取,修改obj狀態//Modified修改的
                                  //System.Data.EntityState縮短成"EntityState"
            ne.SaveChanges();
        }
        public void Delete(int id)
        {
            var obj = ne.Shippers.Find(id);
            ne.Shippers.Remove(obj);
            ne.SaveChanges();

        }

    }
}
