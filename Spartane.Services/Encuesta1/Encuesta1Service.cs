using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Encuesta1;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Encuesta1
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Encuesta1Service : IEncuesta1Service
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Encuesta1.Encuesta1> _Encuesta1Repository;
        #endregion

        #region Ctor
        public Encuesta1Service(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Encuesta1.Encuesta1> Encuesta1Repository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Encuesta1Repository = Encuesta1Repository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Encuesta1.Encuesta1> SelAll(bool ConRelaciones)
        {
            return this._Encuesta1Repository.Table.ToList();
        }

        public IList<Core.Domain.Encuesta1.Encuesta1> SelAllComplete(bool ConRelaciones)
        {
            return this._Encuesta1Repository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Encuesta1.Encuesta1> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Encuesta1Repository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Encuesta1.Encuesta1> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Encuesta1Repository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Encuesta1.Encuesta1> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Encuesta1Repository.Table.ToList();
        }

        public Spartane.Core.Domain.Encuesta1.Encuesta1PagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Encuesta1PagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Encuesta1.Encuesta1> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Encuesta1Repository.Table.ToList();
        }

        public Spartane.Core.Domain.Encuesta1.Encuesta1 GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Encuesta1.Encuesta1 result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Encuesta1Information, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Encuesta1.Encuesta1 entity, Spartane.Core.Domain.User.GlobalData Encuesta1Information, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Encuesta1.Encuesta1 entity, Spartane.Core.Domain.User.GlobalData Encuesta1Information, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

