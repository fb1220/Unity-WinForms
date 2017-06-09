﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Windows.Forms
{
    public class KeyEventArgs : EventArgs
    {
        public UnityEngine.KeyCode uwfKeyCode { get; set; }
        public UnityEngine.EventModifiers uwfModifiers { get; set; }

        private readonly Keys keyData;
        private bool handled;
        private bool suppressKeyPress;

        public virtual bool Alt
        {
            get { return (keyData & Keys.Alt) == Keys.Alt; }
        }
        public bool Control
        {
            get { return (keyData & Keys.Control) == Keys.Control; }
        }
        public bool Handled
        {
            get { return handled; }
            set { handled = value; }
        }
        public Keys KeyCode
        {
            get
            {
                var keys = keyData & Keys.KeyCode;
                if (!Enum.IsDefined(typeof(Keys), keys))
                    return Keys.None;
                return keys;
            }
        }
        public int KeyValue
        {
            get { return (int)(keyData & Keys.KeyCode); }
        }
        public Keys KeyData
        {
            get { return keyData; }
        }
        public Keys Modifiers
        {
            get { return keyData & Keys.Modifiers; }
        }
        public virtual bool Shift
        {
            get { return (keyData & Keys.Shift) == Keys.Shift; }
        }
        public bool SuppressKeyPress
        {
            get { return suppressKeyPress; }
            set
            {
                suppressKeyPress = value;
                handled = value;
            }
        }

        internal KeyEventArgs()
        {
            
        }
        public KeyEventArgs(Keys keyData)
        {
            this.keyData = keyData;
        }
    }
}
