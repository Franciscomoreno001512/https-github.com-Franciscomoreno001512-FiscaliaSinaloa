using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Fase_de_Judicializacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Fase_de_Judicializacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Fase_de_JudicializacionService : IFase_de_JudicializacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> _Fase_de_JudicializacionRepository;
        #endregion

        #region Ctor
        public Fase_de_JudicializacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> Fase_de_JudicializacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Fase_de_JudicializacionRepository = Fase_de_JudicializacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAll(bool ConRelaciones)
        {
            return this._Fase_de_JudicializacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Fase_de_JudicializacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Fase_de_JudicializacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Fase_de_JudicializacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Fase_de_JudicializacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_JudicializacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Fase_de_JudicializacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Fase_de_JudicializacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Fase_de_JudicializacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion entity, Spartane.Core.Domain.User.GlobalData Fase_de_JudicializacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Fase_de_Judicializacion.Fase_de_Judicializacion entity, Spartane.Core.Domain.User.GlobalData Fase_de_JudicializacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

