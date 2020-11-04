using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Redes_Sociales;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Redes_Sociales
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Redes_SocialesService : IRedes_SocialesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> _Redes_SocialesRepository;
        #endregion

        #region Ctor
        public Redes_SocialesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> Redes_SocialesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Redes_SocialesRepository = Redes_SocialesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> SelAll(bool ConRelaciones)
        {
            return this._Redes_SocialesRepository.Table.ToList();
        }

        public IList<Core.Domain.Redes_Sociales.Redes_Sociales> SelAllComplete(bool ConRelaciones)
        {
            return this._Redes_SocialesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Redes_SocialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Redes_SocialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Redes_SocialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Redes_Sociales.Redes_SocialesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Redes_SocialesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Redes_Sociales.Redes_Sociales> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Redes_SocialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Redes_Sociales.Redes_Sociales GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Redes_Sociales.Redes_Sociales result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Redes_SocialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Redes_Sociales.Redes_Sociales entity, Spartane.Core.Domain.User.GlobalData Redes_SocialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Redes_Sociales.Redes_Sociales entity, Spartane.Core.Domain.User.GlobalData Redes_SocialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

