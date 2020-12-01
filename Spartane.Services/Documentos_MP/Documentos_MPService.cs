using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Documentos_MP;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Documentos_MP
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Documentos_MPService : IDocumentos_MPService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Documentos_MP.Documentos_MP> _Documentos_MPRepository;
        #endregion

        #region Ctor
        public Documentos_MPService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Documentos_MP.Documentos_MP> Documentos_MPRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Documentos_MPRepository = Documentos_MPRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Documentos_MP.Documentos_MP> SelAll(bool ConRelaciones)
        {
            return this._Documentos_MPRepository.Table.ToList();
        }

        public IList<Core.Domain.Documentos_MP.Documentos_MP> SelAllComplete(bool ConRelaciones)
        {
            return this._Documentos_MPRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Documentos_MP.Documentos_MP> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Documentos_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documentos_MP.Documentos_MP> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Documentos_MPRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Documentos_MP.Documentos_MP> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Documentos_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documentos_MP.Documentos_MPPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Documentos_MPPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Documentos_MP.Documentos_MP> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Documentos_MPRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Documentos_MP.Documentos_MP GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Documentos_MP.Documentos_MP result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Documentos_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Documentos_MP.Documentos_MP entity, Spartane.Core.Domain.User.GlobalData Documentos_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Documentos_MP.Documentos_MP entity, Spartane.Core.Domain.User.GlobalData Documentos_MPInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

