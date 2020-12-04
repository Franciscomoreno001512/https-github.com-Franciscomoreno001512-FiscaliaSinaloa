using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Vinculacion_a_Proceso;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Vinculacion_a_Proceso
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Vinculacion_a_ProcesoService : IVinculacion_a_ProcesoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> _Vinculacion_a_ProcesoRepository;
        #endregion

        #region Ctor
        public Vinculacion_a_ProcesoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> Vinculacion_a_ProcesoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Vinculacion_a_ProcesoRepository = Vinculacion_a_ProcesoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAll(bool ConRelaciones)
        {
            return this._Vinculacion_a_ProcesoRepository.Table.ToList();
        }

        public IList<Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAllComplete(bool ConRelaciones)
        {
            return this._Vinculacion_a_ProcesoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Vinculacion_a_ProcesoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Vinculacion_a_ProcesoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Vinculacion_a_ProcesoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_ProcesoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Vinculacion_a_ProcesoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Vinculacion_a_ProcesoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Vinculacion_a_ProcesoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso entity, Spartane.Core.Domain.User.GlobalData Vinculacion_a_ProcesoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Vinculacion_a_Proceso.Vinculacion_a_Proceso entity, Spartane.Core.Domain.User.GlobalData Vinculacion_a_ProcesoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

