using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Catalogo_Numero_de_Preguntas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Catalogo_Numero_de_Preguntas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Catalogo_Numero_de_PreguntasService : ICatalogo_Numero_de_PreguntasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> _Catalogo_Numero_de_PreguntasRepository;
        #endregion

        #region Ctor
        public Catalogo_Numero_de_PreguntasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> Catalogo_Numero_de_PreguntasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Catalogo_Numero_de_PreguntasRepository = Catalogo_Numero_de_PreguntasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAll(bool ConRelaciones)
        {
            return this._Catalogo_Numero_de_PreguntasRepository.Table.ToList();
        }

        public IList<Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAllComplete(bool ConRelaciones)
        {
            return this._Catalogo_Numero_de_PreguntasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_Numero_de_PreguntasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Catalogo_Numero_de_PreguntasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_Numero_de_PreguntasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_PreguntasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Catalogo_Numero_de_PreguntasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Catalogo_Numero_de_PreguntasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_Numero_de_PreguntasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas entity, Spartane.Core.Domain.User.GlobalData Catalogo_Numero_de_PreguntasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas entity, Spartane.Core.Domain.User.GlobalData Catalogo_Numero_de_PreguntasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

