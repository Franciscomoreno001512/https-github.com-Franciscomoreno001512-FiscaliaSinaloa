using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Senas_Particulares;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Senas_Particulares
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Senas_ParticularesService : ISenas_ParticularesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> _Senas_ParticularesRepository;
        #endregion

        #region Ctor
        public Senas_ParticularesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> Senas_ParticularesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Senas_ParticularesRepository = Senas_ParticularesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> SelAll(bool ConRelaciones)
        {
            return this._Senas_ParticularesRepository.Table.ToList();
        }

        public IList<Core.Domain.Senas_Particulares.Senas_Particulares> SelAllComplete(bool ConRelaciones)
        {
            return this._Senas_ParticularesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Senas_ParticularesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Senas_ParticularesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Senas_ParticularesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Senas_Particulares.Senas_ParticularesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Senas_ParticularesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Senas_ParticularesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Senas_Particulares.Senas_Particulares GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Senas_Particulares.Senas_Particulares result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Senas_ParticularesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Senas_Particulares.Senas_Particulares entity, Spartane.Core.Domain.User.GlobalData Senas_ParticularesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Senas_Particulares.Senas_Particulares entity, Spartane.Core.Domain.User.GlobalData Senas_ParticularesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

