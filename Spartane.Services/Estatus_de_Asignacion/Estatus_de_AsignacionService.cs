using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_de_Asignacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_de_Asignacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_de_AsignacionService : IEstatus_de_AsignacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> _Estatus_de_AsignacionRepository;
        #endregion

        #region Ctor
        public Estatus_de_AsignacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> Estatus_de_AsignacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_de_AsignacionRepository = Estatus_de_AsignacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAll(bool ConRelaciones)
        {
            return this._Estatus_de_AsignacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_de_AsignacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_AsignacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_de_AsignacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_AsignacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_AsignacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_de_AsignacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_de_AsignacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_de_AsignacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion entity, Spartane.Core.Domain.User.GlobalData Estatus_de_AsignacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_de_Asignacion.Estatus_de_Asignacion entity, Spartane.Core.Domain.User.GlobalData Estatus_de_AsignacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

