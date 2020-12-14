using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Registro_de_Movimiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Registro_de_Movimiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Registro_de_MovimientoService : IRegistro_de_MovimientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> _Registro_de_MovimientoRepository;
        #endregion

        #region Ctor
        public Registro_de_MovimientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> Registro_de_MovimientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Registro_de_MovimientoRepository = Registro_de_MovimientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> SelAll(bool ConRelaciones)
        {
            return this._Registro_de_MovimientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> SelAllComplete(bool ConRelaciones)
        {
            return this._Registro_de_MovimientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Registro_de_MovimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Registro_de_MovimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Registro_de_MovimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_MovimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Registro_de_MovimientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Registro_de_MovimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Registro_de_MovimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento entity, Spartane.Core.Domain.User.GlobalData Registro_de_MovimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Registro_de_Movimiento.Registro_de_Movimiento entity, Spartane.Core.Domain.User.GlobalData Registro_de_MovimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

