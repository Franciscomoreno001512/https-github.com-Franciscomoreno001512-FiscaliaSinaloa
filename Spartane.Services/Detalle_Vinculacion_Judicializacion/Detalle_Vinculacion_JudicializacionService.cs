using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Vinculacion_Judicializacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Vinculacion_JudicializacionService : IDetalle_Vinculacion_JudicializacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> _Detalle_Vinculacion_JudicializacionRepository;
        #endregion

        #region Ctor
        public Detalle_Vinculacion_JudicializacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> Detalle_Vinculacion_JudicializacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Vinculacion_JudicializacionRepository = Detalle_Vinculacion_JudicializacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Vinculacion_JudicializacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Vinculacion_JudicializacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Vinculacion_JudicializacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Vinculacion_JudicializacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Vinculacion_JudicializacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_JudicializacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Vinculacion_JudicializacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Vinculacion_JudicializacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Vinculacion_JudicializacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion entity, Spartane.Core.Domain.User.GlobalData Detalle_Vinculacion_JudicializacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Vinculacion_Judicializacion.Detalle_Vinculacion_Judicializacion entity, Spartane.Core.Domain.User.GlobalData Detalle_Vinculacion_JudicializacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

