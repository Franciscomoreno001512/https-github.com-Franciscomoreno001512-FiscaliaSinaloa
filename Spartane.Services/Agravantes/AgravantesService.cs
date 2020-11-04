using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Agravantes;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Agravantes
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AgravantesService : IAgravantesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Agravantes.Agravantes> _AgravantesRepository;
        #endregion

        #region Ctor
        public AgravantesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Agravantes.Agravantes> AgravantesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AgravantesRepository = AgravantesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Agravantes.Agravantes> SelAll(bool ConRelaciones)
        {
            return this._AgravantesRepository.Table.ToList();
        }

        public IList<Core.Domain.Agravantes.Agravantes> SelAllComplete(bool ConRelaciones)
        {
            return this._AgravantesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Agravantes.Agravantes> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AgravantesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Agravantes.Agravantes> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AgravantesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Agravantes.Agravantes> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AgravantesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Agravantes.AgravantesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AgravantesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Agravantes.Agravantes> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AgravantesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Agravantes.Agravantes GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Agravantes.Agravantes result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AgravantesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Agravantes.Agravantes entity, Spartane.Core.Domain.User.GlobalData AgravantesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Agravantes.Agravantes entity, Spartane.Core.Domain.User.GlobalData AgravantesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

