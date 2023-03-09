﻿using System;
using System.Globalization;

namespace ContaBancaria
{
    internal class Conta
    {
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta()
        {
        }



        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo) : this (numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}
