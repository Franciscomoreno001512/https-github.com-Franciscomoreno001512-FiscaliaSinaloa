using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Medidas_Cautelares;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Medidas_Cautelares
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Medidas_CautelaresService : IMedidas_CautelaresService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> _Medidas_CautelaresRepository;
        #endregion

        #region Ctor
        public Medidas_CautelaresService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> Medidas_CautelaresRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Medidas_CautelaresRepository = Medidas_CautelaresRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAll(bool ConRelaciones)
        {
            return this._Medidas_CautelaresRepository.Table.ToList();
        }

        public IList<Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAllComplete(bool ConRelaciones)
        {
            return this._Medidas_CautelaresRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Medidas_CautelaresRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Medidas_CautelaresRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Medidas_CautelaresRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Medidas_Cautelares.Medidas_CautelaresPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Medidas_CautelaresPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Medidas_CautelaresRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Medidas_CautelaresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares entity, Spartane.Core.Domain.User.GlobalData Medidas_CautelaresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares entity, Spartane.Core.Domain.User.GlobalData Medidas_CautelaresInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

