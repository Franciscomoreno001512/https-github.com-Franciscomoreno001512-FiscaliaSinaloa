using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Solicitud;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Solicitud
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_SolicitudService : ITipo_de_SolicitudService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> _Tipo_de_SolicitudRepository;
        #endregion

        #region Ctor
        public Tipo_de_SolicitudService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> Tipo_de_SolicitudRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_SolicitudRepository = Tipo_de_SolicitudRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_SolicitudRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_SolicitudRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_SolicitudRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_SolicitudRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_SolicitudRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_SolicitudPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_SolicitudPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_SolicitudRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_de_SolicitudInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud entity, Spartane.Core.Domain.User.GlobalData Tipo_de_SolicitudInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_de_Solicitud.Tipo_de_Solicitud entity, Spartane.Core.Domain.User.GlobalData Tipo_de_SolicitudInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

