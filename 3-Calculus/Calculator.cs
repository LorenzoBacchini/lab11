using System;
using ComplexAlgebra;

namespace Calculus
{
    /// <summary>
    /// A calculator for <see cref="Complex"/> numbers, supporting 2 operations ('+', '-').
    /// The calculator visualizes a single value at a time.
    /// Users may change the currently shown value as many times as they like.
    /// Whenever an operation button is chosen, the calculator memorises the currently shown value and resets it.
    /// Before resetting, it performs any pending operation.
    /// Whenever the final result is requested, all pending operations are performed and the final result is shown.
    /// The calculator also supports resetting.
    /// </summary>
    ///
    /// HINT: model operations as constants
    /// HINT: model the following _public_ properties methods
    /// HINT: - a property/method for the currently shown value
    /// HINT: - a property/method to let the user request the final result
    /// HINT: - a property/method to let the user reset the calculator
    /// HINT: - a property/method to let the user request an operation
    /// HINT: - the usual ToString() method, which is helpful for debugging
    /// HINT: - you may exploit as many _private_ fields/methods/properties as you like
    ///
    /// TODO: implement the calculator class in such a way that the Program below works as expected
    class Calculator
    {
        public const char OperationPlus = '+';
        public const char OperationMinus = '-';

        /// <summary>
        /// Mantiene il risultato temporaneo/parziale della calcolatrice
        /// </summary>
        private Complex _result = null;
        
        /// <summary>
        /// Mantiene il valore attuale passato alla calcolatrice e quando chiamo (ComputeResult())
        /// si salva al suo interno il risultato finale, questo perchè e proprio value che stampo
        /// ad ogni operazione della calcolatrice per vedere a "shcermo" cosa sto facendo
        /// </summary>
        
        ///Mantiene il segno dell'operazione da eseguire (+ o -)
        public Complex Value { get; set; }

        private char? _operation;

        /// <summary>
        /// Metodo MOLTO IMPORTANTE viene chiamato quando inserisco un (+ o -) nella
        /// calcolatrice, si occupa di:
        ///     - portare a null il valore di _operation
        ///     - inizializzare il valore di _result a Value la prima volta che viene
        ///       premuto un (+ o -)
        ///     - compiere operazioni su _result ogni qualvolta si "schiacci" un tasto
        ///       della calcolatrice
        /// </summary>
        public char? Operation
        {
            get => _operation;
            set
            {
                if (value == null)
                {
                    _operation = value;
                    return;
                }
                
                _operation = value;
                if (_result == null)
                {
                    _result = Value;
                }
                else
                {
                    ComputeIntermediateResult();
                }
                Value = null;
            }
        }

        /// <summary>
        /// Metodo usato internamente che calcola l'operazione richiesta su _result
        /// al passaggio del parametro Value da (sommare/sottrarre) a _result
        /// </summary>
        private void ComputeIntermediateResult()
        {
            _result = _operation == OperationPlus ? _result.Sum(Value) : _result.Min(Value);
        }

        /// <summary>
        /// Corrisponde al tasto = della calcolatrice, ci porta nella
        /// condizione di avere il risultato nella Properties che verra poi
        /// stampata, porta inoltre a null il valore di Operation
        /// </summary>
        public void ComputeResult()
        {
            Value = _result;
            Operation = null;
        }

        /// <summary>
        /// Metodo che crea la stringa da stampare ad ogni operazione,
        /// stampa prima il valore dell'operazione poi il suo segno (+ o -)
        /// se una delle due e null allora al suo posto metterà null
        /// </summary>
        /// <returns>la stringa completa</returns>
        public override string ToString()
        {
            string cNumber = Value == null ? "null" : $"{Value}";
            string sign = Operation == null ? "null" : $"{Operation}";
            return $"{cNumber} , {sign}";
        }

        /// <summary>
        /// Metodo che resetta la calcolatrice portando a null
        /// il suo Value, Operation e _result
        /// </summary>
        public void Reset()
        {
            _result = null;
            Value = null;
            Operation = null;
        }
    }
}