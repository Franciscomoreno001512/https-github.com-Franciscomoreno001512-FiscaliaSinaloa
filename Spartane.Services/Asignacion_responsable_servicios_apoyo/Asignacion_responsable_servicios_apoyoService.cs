using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Asignacion_responsable_servicios_apoyo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Asignacion_responsable_servicios_apoyoService : IAsignacion_responsable_servicios_apoyoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> _Asignacion_responsable_servicios_apoyoRepository;
        #endregion

        #region Ctor
        public Asignacion_responsable_servicios_apoyoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> Asignacion_responsable_servicios_apoyoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Asignacion_responsable_servicios_apoyoRepository = Asignacion_responsable_servicios_apoyoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAll(bool ConRelaciones)
        {
            return this._Asignacion_responsable_servicios_apoyoRepository.Table.ToList();
        }

        public IList<Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAllComplete(bool ConRelaciones)
        {
            return this._Asignacion_responsable_servicios_apoyoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Asignacion_responsable_servicios_apoyoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Asignacion_responsable_servicios_apoyoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Asignacion_responsable_servicios_apoyoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Asignacion_responsable_servicios_apoyoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Asignacion_responsable_servicios_apoyoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Asignacion_responsable_servicios_apoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo entity, Spartane.Core.Domain.User.GlobalData Asignacion_responsable_servicios_apoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Asignacion_responsable_servicios_apoyo.Asignacion_responsable_servicios_apoyo entity, Spartane.Core.Domain.User.GlobalData Asignacion_responsable_servicios_apoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

