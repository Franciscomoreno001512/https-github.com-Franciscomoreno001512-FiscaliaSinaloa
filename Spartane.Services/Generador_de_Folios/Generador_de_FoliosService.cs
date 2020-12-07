using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Generador_de_Folios;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Generador_de_Folios
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Generador_de_FoliosService : IGenerador_de_FoliosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios> _Generador_de_FoliosRepository;
        #endregion

        #region Ctor
        public Generador_de_FoliosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios> Generador_de_FoliosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Generador_de_FoliosRepository = Generador_de_FoliosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios> SelAll(bool ConRelaciones)
        {
            return this._Generador_de_FoliosRepository.Table.ToList();
        }

        public IList<Core.Domain.Generador_de_Folios.Generador_de_Folios> SelAllComplete(bool ConRelaciones)
        {
            return this._Generador_de_FoliosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_de_FoliosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Generador_de_FoliosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Generador_de_FoliosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_de_Folios.Generador_de_FoliosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Generador_de_FoliosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Generador_de_FoliosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Generador_de_FoliosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios entity, Spartane.Core.Domain.User.GlobalData Generador_de_FoliosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Generador_de_Folios.Generador_de_Folios entity, Spartane.Core.Domain.User.GlobalData Generador_de_FoliosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

