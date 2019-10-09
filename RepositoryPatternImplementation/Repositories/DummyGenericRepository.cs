using Microsoft.AspNetCore.Mvc;
using RepositoryPatternImplementation.Db;
using RepositoryPatternImplementation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternImplementation.Repositories
{
    public class DummyGenericRepository<T> where T : IModel
    {
        private DB _dB { get; set; }
        private static int IdCounter = 0;

        public DummyGenericRepository()
        {
            this._dB = new DB();
        }

        public ActionResult<IEnumerable<DummyModel>> Get()
        {
            return this._dB.DummyModel;
        }

        public ActionResult<DummyModel> Get(int id)
        {
            return _dB.DummyModel.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Add(string value)
        {
            var dummy = new DummyModel { Id = ++IdCounter, Name = value };
            this._dB.DummyModel.Add(dummy);
            this._dB.SaveChanges();
        }

        public void Update(int id, string value)
        {
            var dummy = _dB.DummyModel.Where(x => x.Id == id).FirstOrDefault();
            dummy.Name = value;
            this._dB.DummyModel.Update(dummy);
            this._dB.SaveChanges();
        }

        public void Delete(int id)
        {
            var dummy = _dB.DummyModel.Where(x => x.Id == id).FirstOrDefault();
            this._dB.DummyModel.Remove(dummy);
            this._dB.SaveChanges();
        }
    }
}