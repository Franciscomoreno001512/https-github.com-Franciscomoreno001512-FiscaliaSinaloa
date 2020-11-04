using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Color_Piel;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Color_Piel
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Color_PielService : IColor_PielService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Color_Piel.Color_Piel> _Color_PielRepository;
        #endregion

        #region Ctor
        public Color_PielService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Color_Piel.Color_Piel> Color_PielRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Color_PielRepository = Color_PielRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Color_Piel.Color_Piel> SelAll(bool ConRelaciones)
        {
            return this._Color_PielRepository.Table.ToList();
        }

        public IList<Core.Domain.Color_Piel.Color_Piel> SelAllComplete(bool ConRelaciones)
        {
            return this._Color_PielRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Color_Piel.Color_Piel> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Color_PielRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Color_Piel.Color_Piel> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Color_PielRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Color_Piel.Color_Piel> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Color_PielRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Color_Piel.Color_PielPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Color_PielPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Color_Piel.Color_Piel> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Color_PielRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Color_Piel.Color_Piel GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Color_Piel.Color_Piel result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Color_PielInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Color_Piel.Color_Piel entity, Spartane.Core.Domain.User.GlobalData Color_PielInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Color_Piel.Color_Piel entity, Spartane.Core.Domain.User.GlobalData Color_PielInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

