using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Configurador_de_Movimientos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Configurador_de_Movimientos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Configurador_de_MovimientosService : IConfigurador_de_MovimientosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> _Configurador_de_MovimientosRepository;
        #endregion

        #region Ctor
        public Configurador_de_MovimientosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> Configurador_de_MovimientosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Configurador_de_MovimientosRepository = Configurador_de_MovimientosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAll(bool ConRelaciones)
        {
            return this._Configurador_de_MovimientosRepository.Table.ToList();
        }

        public IList<Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAllComplete(bool ConRelaciones)
        {
            return this._Configurador_de_MovimientosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Configurador_de_MovimientosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Configurador_de_MovimientosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Configurador_de_MovimientosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_MovimientosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Configurador_de_MovimientosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Configurador_de_MovimientosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Configurador_de_MovimientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos entity, Spartane.Core.Domain.User.GlobalData Configurador_de_MovimientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Configurador_de_Movimientos.Configurador_de_Movimientos entity, Spartane.Core.Domain.User.GlobalData Configurador_de_MovimientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

