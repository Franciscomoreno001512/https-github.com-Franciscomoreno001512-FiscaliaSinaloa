using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Vinculacion_Resolucion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Vinculacion_Resolucion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Vinculacion_ResolucionService : IDetalle_Vinculacion_ResolucionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> _Detalle_Vinculacion_ResolucionRepository;
        #endregion

        #region Ctor
        public Detalle_Vinculacion_ResolucionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> Detalle_Vinculacion_ResolucionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Vinculacion_ResolucionRepository = Detalle_Vinculacion_ResolucionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Vinculacion_ResolucionRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Vinculacion_ResolucionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Vinculacion_ResolucionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Vinculacion_ResolucionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Vinculacion_ResolucionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_ResolucionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Vinculacion_ResolucionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Vinculacion_ResolucionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Vinculacion_ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion entity, Spartane.Core.Domain.User.GlobalData Detalle_Vinculacion_ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Vinculacion_Resolucion.Detalle_Vinculacion_Resolucion entity, Spartane.Core.Domain.User.GlobalData Detalle_Vinculacion_ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

