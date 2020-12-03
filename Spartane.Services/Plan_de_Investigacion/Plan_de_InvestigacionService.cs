using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Plan_de_Investigacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Plan_de_Investigacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Plan_de_InvestigacionService : IPlan_de_InvestigacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> _Plan_de_InvestigacionRepository;
        #endregion

        #region Ctor
        public Plan_de_InvestigacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> Plan_de_InvestigacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Plan_de_InvestigacionRepository = Plan_de_InvestigacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> SelAll(bool ConRelaciones)
        {
            return this._Plan_de_InvestigacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Plan_de_InvestigacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Plan_de_InvestigacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Plan_de_InvestigacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Plan_de_InvestigacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_InvestigacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Plan_de_InvestigacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Plan_de_InvestigacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Plan_de_InvestigacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion entity, Spartane.Core.Domain.User.GlobalData Plan_de_InvestigacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Plan_de_Investigacion.Plan_de_Investigacion entity, Spartane.Core.Domain.User.GlobalData Plan_de_InvestigacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

