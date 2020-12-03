using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Metodo_de_Destruccion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Metodo_de_Destruccion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Metodo_de_DestruccionService : IMetodo_de_DestruccionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> _Metodo_de_DestruccionRepository;
        #endregion

        #region Ctor
        public Metodo_de_DestruccionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> Metodo_de_DestruccionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Metodo_de_DestruccionRepository = Metodo_de_DestruccionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAll(bool ConRelaciones)
        {
            return this._Metodo_de_DestruccionRepository.Table.ToList();
        }

        public IList<Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAllComplete(bool ConRelaciones)
        {
            return this._Metodo_de_DestruccionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Metodo_de_DestruccionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Metodo_de_DestruccionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Metodo_de_DestruccionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_DestruccionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Metodo_de_DestruccionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Metodo_de_DestruccionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Metodo_de_DestruccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion entity, Spartane.Core.Domain.User.GlobalData Metodo_de_DestruccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion entity, Spartane.Core.Domain.User.GlobalData Metodo_de_DestruccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

