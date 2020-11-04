using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_de_Cita_Invitaciones;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_de_Cita_Invitaciones
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_de_Cita_InvitacionesService : IEstatus_de_Cita_InvitacionesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> _Estatus_de_Cita_InvitacionesRepository;
        #endregion

        #region Ctor
        public Estatus_de_Cita_InvitacionesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> Estatus_de_Cita_InvitacionesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_de_Cita_InvitacionesRepository = Estatus_de_Cita_InvitacionesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAll(bool ConRelaciones)
        {
            return this._Estatus_de_Cita_InvitacionesRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_de_Cita_InvitacionesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Cita_InvitacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_de_Cita_InvitacionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Cita_InvitacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_InvitacionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_de_Cita_InvitacionesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_de_Cita_InvitacionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_de_Cita_InvitacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Cita_InvitacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Cita_InvitacionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

