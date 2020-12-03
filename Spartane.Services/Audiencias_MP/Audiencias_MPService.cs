using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencias_MP;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencias_MP
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Audiencias_MPService : IAudiencias_MPService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> _Audiencias_MPRepository;
        #endregion

        #region Ctor
        public Audiencias_MPService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> Audiencias_MPRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Audiencias_MPRepository = Audiencias_MPRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> SelAll(bool ConRelaciones)
        {
            return this._Audiencias_MPRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencias_MP.Audiencias_MP> SelAllComplete(bool ConRelaciones)
        {
            return this._Audiencias_MPRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencias_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Audiencias_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencias_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencias_MP.Audiencias_MPPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Audiencias_MPPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencias_MP.Audiencias_MP> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Audiencias_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencias_MP.Audiencias_MP GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencias_MP.Audiencias_MP result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencias_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencias_MP.Audiencias_MP entity, Spartane.Core.Domain.User.GlobalData Audiencias_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencias_MP.Audiencias_MP entity, Spartane.Core.Domain.User.GlobalData Audiencias_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

