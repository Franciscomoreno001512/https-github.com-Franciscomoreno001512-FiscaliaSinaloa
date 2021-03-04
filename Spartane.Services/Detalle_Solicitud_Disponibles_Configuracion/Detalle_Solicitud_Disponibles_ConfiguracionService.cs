using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Solicitud_Disponibles_Configuracion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Solicitud_Disponibles_ConfiguracionService : IDetalle_Solicitud_Disponibles_ConfiguracionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> _Detalle_Solicitud_Disponibles_ConfiguracionRepository;
        #endregion

        #region Ctor
        public Detalle_Solicitud_Disponibles_ConfiguracionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> Detalle_Solicitud_Disponibles_ConfiguracionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Solicitud_Disponibles_ConfiguracionRepository = Detalle_Solicitud_Disponibles_ConfiguracionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Solicitud_Disponibles_ConfiguracionRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Solicitud_Disponibles_ConfiguracionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Solicitud_Disponibles_ConfiguracionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Solicitud_Disponibles_ConfiguracionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Solicitud_Disponibles_ConfiguracionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_ConfiguracionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Solicitud_Disponibles_ConfiguracionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Solicitud_Disponibles_ConfiguracionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Solicitud_Disponibles_ConfiguracionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion entity, Spartane.Core.Domain.User.GlobalData Detalle_Solicitud_Disponibles_ConfiguracionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Solicitud_Disponibles_Configuracion.Detalle_Solicitud_Disponibles_Configuracion entity, Spartane.Core.Domain.User.GlobalData Detalle_Solicitud_Disponibles_ConfiguracionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

