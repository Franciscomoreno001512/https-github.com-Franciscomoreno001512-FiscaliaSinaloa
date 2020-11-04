using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Unidad_de_Atenciòn;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Unidad_de_Atenciòn
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Unidad_de_AtenciònService : IUnidad_de_AtenciònService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> _Unidad_de_AtenciònRepository;
        #endregion

        #region Ctor
        public Unidad_de_AtenciònService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> Unidad_de_AtenciònRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Unidad_de_AtenciònRepository = Unidad_de_AtenciònRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAll(bool ConRelaciones)
        {
            return this._Unidad_de_AtenciònRepository.Table.ToList();
        }

        public IList<Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAllComplete(bool ConRelaciones)
        {
            return this._Unidad_de_AtenciònRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Unidad_de_AtenciònRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Unidad_de_AtenciònRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Unidad_de_AtenciònRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Unidad_de_AtenciònPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Unidad_de_AtenciònRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Spartane.Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Spartane.Core.Domain.User.GlobalData Unidad_de_AtenciònInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

