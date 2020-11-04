using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Incidente_con_Invitacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Incidente_con_Invitacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Incidente_con_InvitacionService : IIncidente_con_InvitacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> _Incidente_con_InvitacionRepository;
        #endregion

        #region Ctor
        public Incidente_con_InvitacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> Incidente_con_InvitacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Incidente_con_InvitacionRepository = Incidente_con_InvitacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> SelAll(bool ConRelaciones)
        {
            return this._Incidente_con_InvitacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Incidente_con_InvitacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Incidente_con_InvitacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Incidente_con_InvitacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Incidente_con_InvitacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_InvitacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Incidente_con_InvitacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Incidente_con_InvitacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Incidente_con_InvitacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion entity, Spartane.Core.Domain.User.GlobalData Incidente_con_InvitacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Incidente_con_Invitacion.Incidente_con_Invitacion entity, Spartane.Core.Domain.User.GlobalData Incidente_con_InvitacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

