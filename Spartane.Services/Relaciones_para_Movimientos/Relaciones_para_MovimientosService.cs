using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Relaciones_para_Movimientos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Relaciones_para_Movimientos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Relaciones_para_MovimientosService : IRelaciones_para_MovimientosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> _Relaciones_para_MovimientosRepository;
        #endregion

        #region Ctor
        public Relaciones_para_MovimientosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> Relaciones_para_MovimientosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Relaciones_para_MovimientosRepository = Relaciones_para_MovimientosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> SelAll(bool ConRelaciones)
        {
            return this._Relaciones_para_MovimientosRepository.Table.ToList();
        }

        public IList<Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> SelAllComplete(bool ConRelaciones)
        {
            return this._Relaciones_para_MovimientosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Relaciones_para_MovimientosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Relaciones_para_MovimientosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Relaciones_para_MovimientosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_MovimientosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Relaciones_para_MovimientosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Relaciones_para_MovimientosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Relaciones_para_MovimientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos entity, Spartane.Core.Domain.User.GlobalData Relaciones_para_MovimientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Relaciones_para_Movimientos.Relaciones_para_Movimientos entity, Spartane.Core.Domain.User.GlobalData Relaciones_para_MovimientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

