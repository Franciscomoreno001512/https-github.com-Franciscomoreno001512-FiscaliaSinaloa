using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Resolucion_MP;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Resolucion_MP
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Resolucion_MPService : IResolucion_MPService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> _Resolucion_MPRepository;
        #endregion

        #region Ctor
        public Resolucion_MPService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> Resolucion_MPRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Resolucion_MPRepository = Resolucion_MPRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> SelAll(bool ConRelaciones)
        {
            return this._Resolucion_MPRepository.Table.ToList();
        }

        public IList<Core.Domain.Resolucion_MP.Resolucion_MP> SelAllComplete(bool ConRelaciones)
        {
            return this._Resolucion_MPRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resolucion_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Resolucion_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resolucion_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resolucion_MP.Resolucion_MPPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Resolucion_MPPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Resolucion_MP.Resolucion_MP> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Resolucion_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resolucion_MP.Resolucion_MP GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Resolucion_MP.Resolucion_MP result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Resolucion_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Resolucion_MP.Resolucion_MP entity, Spartane.Core.Domain.User.GlobalData Resolucion_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Resolucion_MP.Resolucion_MP entity, Spartane.Core.Domain.User.GlobalData Resolucion_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

