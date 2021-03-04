using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_subareas_responsable_servicio_apoyo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_subareas_responsable_servicio_apoyoService : IDetalle_subareas_responsable_servicio_apoyoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> _Detalle_subareas_responsable_servicio_apoyoRepository;
        #endregion

        #region Ctor
        public Detalle_subareas_responsable_servicio_apoyoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> Detalle_subareas_responsable_servicio_apoyoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_subareas_responsable_servicio_apoyoRepository = Detalle_subareas_responsable_servicio_apoyoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAll(bool ConRelaciones)
        {
            return this._Detalle_subareas_responsable_servicio_apoyoRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_subareas_responsable_servicio_apoyoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_subareas_responsable_servicio_apoyoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_subareas_responsable_servicio_apoyoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_subareas_responsable_servicio_apoyoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_subareas_responsable_servicio_apoyoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_subareas_responsable_servicio_apoyoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_subareas_responsable_servicio_apoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo entity, Spartane.Core.Domain.User.GlobalData Detalle_subareas_responsable_servicio_apoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_subareas_responsable_servicio_apoyo.Detalle_subareas_responsable_servicio_apoyo entity, Spartane.Core.Domain.User.GlobalData Detalle_subareas_responsable_servicio_apoyoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

