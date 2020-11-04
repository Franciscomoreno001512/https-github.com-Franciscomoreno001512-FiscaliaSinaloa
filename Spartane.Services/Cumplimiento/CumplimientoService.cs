using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Cumplimiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Cumplimiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class CumplimientoService : ICumplimientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Cumplimiento.Cumplimiento> _CumplimientoRepository;
        #endregion

        #region Ctor
        public CumplimientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Cumplimiento.Cumplimiento> CumplimientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._CumplimientoRepository = CumplimientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Cumplimiento.Cumplimiento> SelAll(bool ConRelaciones)
        {
            return this._CumplimientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Cumplimiento.Cumplimiento> SelAllComplete(bool ConRelaciones)
        {
            return this._CumplimientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Cumplimiento.Cumplimiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CumplimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Cumplimiento.Cumplimiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._CumplimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Cumplimiento.Cumplimiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CumplimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Cumplimiento.CumplimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            CumplimientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Cumplimiento.Cumplimiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._CumplimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Cumplimiento.Cumplimiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Cumplimiento.Cumplimiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData CumplimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Cumplimiento.Cumplimiento entity, Spartane.Core.Domain.User.GlobalData CumplimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Cumplimiento.Cumplimiento entity, Spartane.Core.Domain.User.GlobalData CumplimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

