using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Solicitudes_de_Invitaciones
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Solicitudes_de_InvitacionesService : IDetalle_de_Solicitudes_de_InvitacionesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> _Detalle_de_Solicitudes_de_InvitacionesRepository;
        #endregion

        #region Ctor
        public Detalle_de_Solicitudes_de_InvitacionesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> Detalle_de_Solicitudes_de_InvitacionesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Solicitudes_de_InvitacionesRepository = Detalle_de_Solicitudes_de_InvitacionesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Solicitudes_de_InvitacionesRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Solicitudes_de_InvitacionesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Solicitudes_de_InvitacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Solicitudes_de_InvitacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Solicitudes_de_InvitacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_InvitacionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Solicitudes_de_InvitacionesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Solicitudes_de_InvitacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Solicitudes_de_Invitaciones.Detalle_de_Solicitudes_de_Invitaciones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitudes_de_InvitacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

