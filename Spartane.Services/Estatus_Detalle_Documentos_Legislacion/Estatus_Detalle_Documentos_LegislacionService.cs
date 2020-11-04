using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_Detalle_Documentos_Legislacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_Detalle_Documentos_LegislacionService : IEstatus_Detalle_Documentos_LegislacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> _Estatus_Detalle_Documentos_LegislacionRepository;
        #endregion

        #region Ctor
        public Estatus_Detalle_Documentos_LegislacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> Estatus_Detalle_Documentos_LegislacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_Detalle_Documentos_LegislacionRepository = Estatus_Detalle_Documentos_LegislacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAll(bool ConRelaciones)
        {
            return this._Estatus_Detalle_Documentos_LegislacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_Detalle_Documentos_LegislacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_Detalle_Documentos_LegislacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_Detalle_Documentos_LegislacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_Detalle_Documentos_LegislacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_LegislacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_Detalle_Documentos_LegislacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_Detalle_Documentos_LegislacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_Detalle_Documentos_LegislacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion entity, Spartane.Core.Domain.User.GlobalData Estatus_Detalle_Documentos_LegislacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_Detalle_Documentos_Legislacion.Estatus_Detalle_Documentos_Legislacion entity, Spartane.Core.Domain.User.GlobalData Estatus_Detalle_Documentos_LegislacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

