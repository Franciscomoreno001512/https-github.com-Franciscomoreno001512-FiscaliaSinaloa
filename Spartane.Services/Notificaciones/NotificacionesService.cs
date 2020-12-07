using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Notificaciones;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Notificaciones
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class NotificacionesService : INotificacionesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Notificaciones.Notificaciones> _NotificacionesRepository;
        #endregion

        #region Ctor
        public NotificacionesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Notificaciones.Notificaciones> NotificacionesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._NotificacionesRepository = NotificacionesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Notificaciones.Notificaciones> SelAll(bool ConRelaciones)
        {
            return this._NotificacionesRepository.Table.ToList();
        }

        public IList<Core.Domain.Notificaciones.Notificaciones> SelAllComplete(bool ConRelaciones)
        {
            return this._NotificacionesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Notificaciones.Notificaciones> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._NotificacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Notificaciones.Notificaciones> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._NotificacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Notificaciones.Notificaciones> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._NotificacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Notificaciones.NotificacionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            NotificacionesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Notificaciones.Notificaciones> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._NotificacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Notificaciones.Notificaciones GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Notificaciones.Notificaciones result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData NotificacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Notificaciones.Notificaciones entity, Spartane.Core.Domain.User.GlobalData NotificacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Notificaciones.Notificaciones entity, Spartane.Core.Domain.User.GlobalData NotificacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

