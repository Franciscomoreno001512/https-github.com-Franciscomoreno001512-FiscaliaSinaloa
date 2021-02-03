using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_Quejas_MP;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_Quejas_MP
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_Quejas_MPService : IEstatus_Quejas_MPService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> _Estatus_Quejas_MPRepository;
        #endregion

        #region Ctor
        public Estatus_Quejas_MPService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> Estatus_Quejas_MPRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_Quejas_MPRepository = Estatus_Quejas_MPRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> SelAll(bool ConRelaciones)
        {
            return this._Estatus_Quejas_MPRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_Quejas_MPRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_Quejas_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_Quejas_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_Quejas_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MPPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_Quejas_MPPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_Quejas_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_Quejas_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP entity, Spartane.Core.Domain.User.GlobalData Estatus_Quejas_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_Quejas_MP.Estatus_Quejas_MP entity, Spartane.Core.Domain.User.GlobalData Estatus_Quejas_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

