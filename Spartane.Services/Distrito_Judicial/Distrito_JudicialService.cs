using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Distrito_Judicial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Distrito_Judicial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Distrito_JudicialService : IDistrito_JudicialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> _Distrito_JudicialRepository;
        #endregion

        #region Ctor
        public Distrito_JudicialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> Distrito_JudicialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Distrito_JudicialRepository = Distrito_JudicialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> SelAll(bool ConRelaciones)
        {
            return this._Distrito_JudicialRepository.Table.ToList();
        }

        public IList<Core.Domain.Distrito_Judicial.Distrito_Judicial> SelAllComplete(bool ConRelaciones)
        {
            return this._Distrito_JudicialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Distrito_JudicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Distrito_JudicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Distrito_JudicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Distrito_Judicial.Distrito_JudicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Distrito_JudicialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Distrito_JudicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Distrito_JudicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial entity, Spartane.Core.Domain.User.GlobalData Distrito_JudicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Distrito_Judicial.Distrito_Judicial entity, Spartane.Core.Domain.User.GlobalData Distrito_JudicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

