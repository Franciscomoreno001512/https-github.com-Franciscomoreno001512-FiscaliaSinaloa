using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencia_de_Control_Solicitud;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencia_de_Control_Solicitud
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Audiencia_de_Control_SolicitudService : IAudiencia_de_Control_SolicitudService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> _Audiencia_de_Control_SolicitudRepository;
        #endregion

        #region Ctor
        public Audiencia_de_Control_SolicitudService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> Audiencia_de_Control_SolicitudRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Audiencia_de_Control_SolicitudRepository = Audiencia_de_Control_SolicitudRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> SelAll(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_SolicitudRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> SelAllComplete(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_SolicitudRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_SolicitudRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Audiencia_de_Control_SolicitudRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_SolicitudRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_SolicitudPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Audiencia_de_Control_SolicitudPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Audiencia_de_Control_SolicitudRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_SolicitudInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_SolicitudInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencia_de_Control_Solicitud.Audiencia_de_Control_Solicitud entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_SolicitudInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

