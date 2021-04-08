using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Area_envia_Cumplimiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Area_envia_Cumplimiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Area_envia_CumplimientoService : IArea_envia_CumplimientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> _Area_envia_CumplimientoRepository;
        #endregion

        #region Ctor
        public Area_envia_CumplimientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> Area_envia_CumplimientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Area_envia_CumplimientoRepository = Area_envia_CumplimientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAll(bool ConRelaciones)
        {
            return this._Area_envia_CumplimientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAllComplete(bool ConRelaciones)
        {
            return this._Area_envia_CumplimientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Area_envia_CumplimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Area_envia_CumplimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Area_envia_CumplimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_CumplimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Area_envia_CumplimientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Area_envia_CumplimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Spartane.Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Area_envia_Cumplimiento.Area_envia_Cumplimiento entity, Spartane.Core.Domain.User.GlobalData Area_envia_CumplimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

