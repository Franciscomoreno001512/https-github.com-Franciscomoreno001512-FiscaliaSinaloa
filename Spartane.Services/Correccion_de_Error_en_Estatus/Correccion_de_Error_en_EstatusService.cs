using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Correccion_de_Error_en_Estatus;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Correccion_de_Error_en_Estatus
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Correccion_de_Error_en_EstatusService : ICorreccion_de_Error_en_EstatusService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> _Correccion_de_Error_en_EstatusRepository;
        #endregion

        #region Ctor
        public Correccion_de_Error_en_EstatusService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> Correccion_de_Error_en_EstatusRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Correccion_de_Error_en_EstatusRepository = Correccion_de_Error_en_EstatusRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAll(bool ConRelaciones)
        {
            return this._Correccion_de_Error_en_EstatusRepository.Table.ToList();
        }

        public IList<Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAllComplete(bool ConRelaciones)
        {
            return this._Correccion_de_Error_en_EstatusRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Correccion_de_Error_en_EstatusRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Correccion_de_Error_en_EstatusRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Correccion_de_Error_en_EstatusRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_EstatusPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Correccion_de_Error_en_EstatusPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Correccion_de_Error_en_EstatusRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Spartane.Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Correccion_de_Error_en_Estatus.Correccion_de_Error_en_Estatus entity, Spartane.Core.Domain.User.GlobalData Correccion_de_Error_en_EstatusInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

