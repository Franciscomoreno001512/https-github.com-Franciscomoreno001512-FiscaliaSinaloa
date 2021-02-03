using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Probable_Responsable_PC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Probable_Responsable_PC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Probable_Responsable_PCService : IProbable_Responsable_PCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> _Probable_Responsable_PCRepository;
        #endregion

        #region Ctor
        public Probable_Responsable_PCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> Probable_Responsable_PCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Probable_Responsable_PCRepository = Probable_Responsable_PCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> SelAll(bool ConRelaciones)
        {
            return this._Probable_Responsable_PCRepository.Table.ToList();
        }

        public IList<Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> SelAllComplete(bool ConRelaciones)
        {
            return this._Probable_Responsable_PCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Probable_Responsable_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Probable_Responsable_PCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Probable_Responsable_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Probable_Responsable_PCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Probable_Responsable_PCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Probable_Responsable_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC entity, Spartane.Core.Domain.User.GlobalData Probable_Responsable_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Probable_Responsable_PC.Probable_Responsable_PC entity, Spartane.Core.Domain.User.GlobalData Probable_Responsable_PCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

