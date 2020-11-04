using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Solicitud_Bitacora_de_Coincid
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Solicitud_Bitacora_de_CoincidService : IDetalle_de_Solicitud_Bitacora_de_CoincidService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> _Detalle_de_Solicitud_Bitacora_de_CoincidRepository;
        #endregion

        #region Ctor
        public Detalle_de_Solicitud_Bitacora_de_CoincidService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> Detalle_de_Solicitud_Bitacora_de_CoincidRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Solicitud_Bitacora_de_CoincidRepository = Detalle_de_Solicitud_Bitacora_de_CoincidRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Solicitud_Bitacora_de_CoincidRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Solicitud_Bitacora_de_CoincidRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Solicitud_Bitacora_de_CoincidRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Solicitud_Bitacora_de_CoincidRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Solicitud_Bitacora_de_CoincidRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_CoincidPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Solicitud_Bitacora_de_CoincidPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Solicitud_Bitacora_de_CoincidRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitud_Bitacora_de_CoincidInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitud_Bitacora_de_CoincidInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Solicitud_Bitacora_de_Coincid.Detalle_de_Solicitud_Bitacora_de_Coincid entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitud_Bitacora_de_CoincidInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

