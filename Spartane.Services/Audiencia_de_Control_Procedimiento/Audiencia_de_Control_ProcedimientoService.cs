using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencia_de_Control_Procedimiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencia_de_Control_Procedimiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Audiencia_de_Control_ProcedimientoService : IAudiencia_de_Control_ProcedimientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> _Audiencia_de_Control_ProcedimientoRepository;
        #endregion

        #region Ctor
        public Audiencia_de_Control_ProcedimientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> Audiencia_de_Control_ProcedimientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Audiencia_de_Control_ProcedimientoRepository = Audiencia_de_Control_ProcedimientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAll(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_ProcedimientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAllComplete(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_ProcedimientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_ProcedimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Audiencia_de_Control_ProcedimientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_ProcedimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_ProcedimientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Audiencia_de_Control_ProcedimientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Audiencia_de_Control_ProcedimientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ProcedimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ProcedimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencia_de_Control_Procedimiento.Audiencia_de_Control_Procedimiento entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_ProcedimientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

