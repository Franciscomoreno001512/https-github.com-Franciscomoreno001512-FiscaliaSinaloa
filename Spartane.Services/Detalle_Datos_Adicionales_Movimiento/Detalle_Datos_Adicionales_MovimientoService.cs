using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Datos_Adicionales_Movimiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Datos_Adicionales_MovimientoService : IDetalle_Datos_Adicionales_MovimientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> _Detalle_Datos_Adicionales_MovimientoRepository;
        #endregion

        #region Ctor
        public Detalle_Datos_Adicionales_MovimientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> Detalle_Datos_Adicionales_MovimientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Datos_Adicionales_MovimientoRepository = Detalle_Datos_Adicionales_MovimientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Datos_Adicionales_MovimientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Datos_Adicionales_MovimientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Datos_Adicionales_MovimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Datos_Adicionales_MovimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Datos_Adicionales_MovimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_MovimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Datos_Adicionales_MovimientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Datos_Adicionales_MovimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Datos_Adicionales_MovimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento entity, Spartane.Core.Domain.User.GlobalData Detalle_Datos_Adicionales_MovimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Datos_Adicionales_Movimiento.Detalle_Datos_Adicionales_Movimiento entity, Spartane.Core.Domain.User.GlobalData Detalle_Datos_Adicionales_MovimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

