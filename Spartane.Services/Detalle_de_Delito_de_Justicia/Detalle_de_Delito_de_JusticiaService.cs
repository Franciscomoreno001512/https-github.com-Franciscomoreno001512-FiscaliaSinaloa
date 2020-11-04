using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Delito_de_Justicia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Delito_de_Justicia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Delito_de_JusticiaService : IDetalle_de_Delito_de_JusticiaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> _Detalle_de_Delito_de_JusticiaRepository;
        #endregion

        #region Ctor
        public Detalle_de_Delito_de_JusticiaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> Detalle_de_Delito_de_JusticiaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Delito_de_JusticiaRepository = Detalle_de_Delito_de_JusticiaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Delito_de_JusticiaRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Delito_de_JusticiaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Delito_de_JusticiaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Delito_de_JusticiaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Delito_de_JusticiaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_JusticiaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Delito_de_JusticiaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Delito_de_JusticiaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Delito_de_JusticiaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Delito_de_JusticiaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Delito_de_Justicia.Detalle_de_Delito_de_Justicia entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Delito_de_JusticiaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

