﻿using NLog;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BmLauncherWForm.data
{
    /// <summary>
    ///     Worker for Keybindform. Acts similarly to GraphicsInterpreter
    /// </summary>
    internal class KeybindInterpreter
    {
        // part of a string that is constant for every line
        private const string NameConstant = ".Bindings=(Name=\"";

        // logger for easy debugging
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public KeybindInterpreter()
        {
            logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        ///     Reads or writes Keybind parameters from UserInput file
        /// </summary>
        /// <param name="lineToCheck">Line to check</param>
        /// <param name="read">Determines if file is being read or written to</param>
        /// <returns>Read input, or new input</returns>
        public string interpretKeys(string lineToCheck, bool read)
        {
            if (lineToCheck.Length <= 41 ||
                lineToCheck.Equals("[Generated by Batman: Arkham Asylum Advanced Launcher]"))
            {
                return lineToCheck;
            }

            string placeHolder = lineToCheck.Substring(17);
            string readThis = stringModifier(lineToCheck, placeHolder);

            //forward
            if (lineToCheck.Contains("MoveForward") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.fwButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.fwButton.Text,
                        "\",Command=\"MoveForward | DebugMenuUpPressed | OnRelease DebugMenuUpReleased | Axis aRawLHJoyUp Speed=1.0\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_FORWARD,0,-1,-1,\"\",false,false,CI_Movement,CI_LeftStick,CI_LeftStickUp");
                }

                logger.Debug("interpretKeys - forward processed as {0}", readThis);
            }

            //backward
            if (lineToCheck.Contains("MoveBackward") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.bwButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.bwButton.Text,
                        "\",Command=\"MoveBackward | DebugMenuDownPressed | OnRelease DebugMenuDownReleased | Axis aRawLHJoyUp Speed=-1.0\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_BACK,0,-1,-1,\"\",true,false,CI_Movement,CI_LeftStick,CI_LeftStickDown");
                }

                logger.Debug("interpretKeys - backward processed as {0}", readThis);
            }

            //left
            if (lineToCheck.Contains("StrafeLeft") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.leftButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.leftButton.Text,
                        "\",Command=\"StrafeLeft | DebugMenuLeftPressed | OnRelease DebugMenuLeftReleased | Axis aRawLHJoyRight Speed=-1.0\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_LEFT,0,-1,-1,\"\",false,false,CI_LeftStick,CI_LeftStickLeftAndRight");
                }

                logger.Debug("interpretKeys - left processed as {0}", readThis);
            }

            //right
            if (lineToCheck.Contains("StrafeRight") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.rightButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.rightButton.Text,
                        "\",Command=\"StrafeRight | DebugMenuRightPressed | OnRelease DebugMenuRightReleased | Axis aRawLHJoyRight Speed=1.0\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_RIGHT,0,-1,-1,\"\",false,false,CI_LeftStick,CI_LeftStickLeftAndRight");
                }

                logger.Debug("interpretKeys - right processed as {0}", readThis);
            }

            //crouch
            if (lineToCheck.Contains("Stealth") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.crouchButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.crouchButton.Text,
                        "\",Command=\"Stealth | CancelBatarangCamera | CancelGadget | ExitAgilityMode | HangFromVantagepoint\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_CROUCH,0,-1,-1,\"bCrouchButton\",false,false,CI_Crouch,CI_Cancel,CI_HangFromVantagePoint");
                }

                logger.Debug("interpretKeys - crouch processed as {0}", readThis);
            }

            //zoom
            if (lineToCheck.Contains("ToggleCameraZoom") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.zoomButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.zoomButton.Text,
                        "\",Command=\"ToggleCameraZoom\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_ZOOM,0,-1,-1,\"\",false,true,CI_Zoom");
                }

                logger.Debug("interpretKeys - zoom processed as {0}", readThis);
            }

            //grapple
            if (lineToCheck.Contains("UseGrapple") && !lineToCheck.Contains("ThumbMouseButton"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.grappleButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.grappleButton.Text,
                        "\",Command=\"Grapple\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_GRAPPLE,0,-1,-1,\"\",false,true,CI_UseGrapple");
                }

                logger.Debug("interpretKeys - grapple processed as {0}", readThis);
            }

            //crouchToggle
            if (lineToCheck.Contains("ToggleCrouch") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.crouchToggleButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.crouchToggleButton.Text,
                        "\",Command=\"ToggleCrouch\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_CROUCH_TOGGLE,0,-1,-1,\"\",false,true,CI_ToggleCrouch");
                }

                logger.Debug("interpretKeys - crouchToggle processed as {0}", readThis);
            }

            //run/glide/use
            if (lineToCheck.Contains(
                    "ContextSensitive | Run | CapeGlide | AcceptConversation | Evade | CancelBatarangCamera") &&
                !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.RGUButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.RGUButton.Text,
                        "\",Command=\"ContextSensitive | Run | CapeGlide | AcceptConversation | Evade | CancelBatarangCamera\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_RUN_GLIDE_USE,0,-1,-1,\"bRunButton\",false,false,CI_RunGlide,CI_Interact");
                }

                logger.Debug("interpretKeys - run/glide/use processed as {0}", readThis);
            }

            //quick batarang
            if (lineToCheck.Contains("QuickBatarang") && !lineToCheck.Contains("ThumbMouseButton2"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.quickBatButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.quickBatButton.Text,
                        "\",Command=\"DebugMenuPrevPage | QuickBatarang\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_QUICKBATARANG,1,-1,-1,\"\",false,true,CI_QuickBatarang");
                }

                logger.Debug("interpretKeys - quick batarang processed as {0}", readThis);
            }

            //quick batclaw
            if (lineToCheck.Contains("QuickBatClaw") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.quickClawButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.quickClawButton.Text,
                        "\",Command=\"QuickBatClaw\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_QUICKBATCLAW,1,-1,-1,\"\",false,true,CI_QuickBatClaw");
                }

                logger.Debug("interpretKeys - quick batclaw processed as {0}", readThis);
            }

            //throw
            if (lineToCheck.Contains("TriggerThrow") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.throwButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.throwButton.Text,
                        "\",Command=\"TriggerThrow\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_THROW,1,-1,-1,\"\",false,true,CI_Throw");
                }

                logger.Debug("interpretKeys - throw processed as {0}", readThis);
            }

            //combat takedown
            if (lineToCheck.Contains("TriggerCombatTakedown") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.cTakedownButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.cTakedownButton.Text,
                        "\",Command=\"TriggerCombatTakedown | Button bReadyGadgetButton\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_COMBATTAKEDOWN,1,-1,-1,\"\",false,true,CI_CombatTakeDown");
                }

                logger.Debug("interpretKeys - combat takedown processed as {0}", readThis);
            }

            //gadget secondary
            if (lineToCheck.Contains("\"SecondaryFireGadget\"") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.gadSecButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.gadSecButton.Text,
                        "\",Command=\"SecondaryFireGadget\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_GADGET_SECONDARY,1,2,-1,\"\",true,true,CI_SecondaryFire");
                }

                logger.Debug("interpretKeys - gadget secondary processed as {0}", readThis);
            }

            //detective mode
            if (lineToCheck.Contains("ForensicMode") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.detButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.detButton.Text,
                        "\",Command=\"ForensicMode | Button aLeftShoulder\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_DETECTIVE_MODE,1,-1,-1,\"\",false,true,CI_VisionModes");
                }

                logger.Debug("interpretKeys - detective mode processed as {0}", readThis);
            }

            //use gadget/strike
            if (lineToCheck.Contains("GadgetOrQuickStrike") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.gadStrikeButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.gadStrikeButton.Text,
                        "\",Command=\"GadgetOrQuickStrike | SkipCutscene\", Shift=false, Control=false, Alt=false, bIgnoreShift=true, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_GRAPPLE_USE_STRIKE,1,0,-1,\"\",false,true,CI_Strike,CI_UseGadget,CI_X");
                }

                logger.Debug("interpretKeys - use gadget/strike processed as {0}", readThis);
            }

            //aim gadget/counter/takedown
            if (lineToCheck.Contains("HoldToZoomOrCounter") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.ACTButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.ACTButton.Text,
                        "\",Command=\"HoldToZoomOrCounter | Button bReadyGadgetButton\", Shift = false, Control = false, Alt = false, bIgnoreShift = true, bIgnoreCtrl = false, bIgnoreAlt = false):META: COM_READY,1,1,-1,\"bReadyGadgetButton\",false,false,CI_AimGadget,CI_SilentTakeDown,CI_Y");
                }

                logger.Debug("interpretKeys - aim gadget/counter/takedown processed as {0}", readThis);
            }

            //cape stun
            if (lineToCheck.Contains("DebugMenuNextPage | BlockBreaker") && !lineToCheck.Contains("Unbound"))
            {
                if (read)
                {
                    Program.MyFactory.Keybinds.capeStunButton.Text = readThis;
                }
                else
                {
                    lineToCheck = stringWriter(Program.MyFactory.Keybinds.capeStunButton.Text,
                        "\",Command=\"DebugMenuNextPage | BlockBreaker\", Shift=false, Control=false, Alt=false, bIgnoreShift=false, bIgnoreCtrl=false, bIgnoreAlt=false):META:COM_CAPESTUN,1,2,-1,\"\",true,true,CI_CapeStun");
                }

                logger.Debug("interpretKeys - cape stun processed as {0}", readThis);
            }

            return lineToCheck;
        }

        /// <summary>
        ///     Reads an input string, modifies it so it is accurately displayed in the Keybindform.
        /// </summary>
        /// <param name="lineToCheck">Line to check</param>
        /// <param name="placeHolder">Contains full string starting with input parameter</param>
        /// <returns>trimmed & corrected input parameter</returns>
        private static string stringModifier(string lineToCheck, string placeHolder)
        {
            if (lineToCheck.Contains("Alt=true"))
            {
                lineToCheck = "A+" + placeHolder.Substring(0, placeHolder.IndexOf("\""));
                return lineToCheck;
            }

            if (lineToCheck.Contains("Shift=true") && !lineToCheck.Contains("bIgnoreShift=true"))
            {
                lineToCheck = "S+" + placeHolder.Substring(0, placeHolder.IndexOf("\""));
                return lineToCheck;
            }

            if (lineToCheck.Contains("Control=true"))
            {
                lineToCheck = "C+" + placeHolder.Substring(0, placeHolder.IndexOf("\""));
                return lineToCheck;
            }

            return placeHolder.Substring(0, placeHolder.IndexOf("\""));
        }

        /// <summary>
        ///     Uses RegEx to detect string pattern in the line to check, to edit ALT/SHIFT/CTRL modifiers
        /// </summary>
        /// <param name="lineToCheck">Line to check</param>
        /// <param name="configLine">Line, starting after the input parameter</param>
        /// <returns>Line with corrected modifiers</returns>
        private static string stringWriter(string lineToCheck, string configLine)
        {
            TimeSpan time = new TimeSpan(0, 0, 0, 3);
            if (lineToCheck.Length <= 2)
            {
                return NameConstant + lineToCheck + configLine;
            }

            if (lineToCheck.Substring(0, 2).Equals("A+"))
            {
                lineToCheck = lineToCheck.Substring(2);
                configLine = Regex.Replace(configLine, @"\bAlt=false\b", "Alt=true", RegexOptions.Compiled, time);
                configLine = Regex.Replace(configLine, @"\bShift=true\b", "Shift=false", RegexOptions.Compiled, time);
                configLine = Regex.Replace(configLine, @"\bControl=true\b", "Control=false", RegexOptions.Compiled,
                    time);
            }

            if (lineToCheck.Substring(0, 2).Equals("S+"))
            {
                lineToCheck = lineToCheck.Substring(2);
                configLine = Regex.Replace(configLine, @"\bAlt=true\b", "Alt=false", RegexOptions.Compiled, time);
                configLine = Regex.Replace(configLine, @"\bShift=false\b", "Shift=true", RegexOptions.Compiled, time);
                configLine = Regex.Replace(configLine, @"\bControl=true\b", "Control=false", RegexOptions.Compiled,
                    time);
            }

            if (lineToCheck.Substring(0, 2).Equals("C+"))
            {
                lineToCheck = lineToCheck.Substring(2);
                configLine = Regex.Replace(configLine, @"\bAlt=true\b", "Alt=false", RegexOptions.Compiled, time);
                configLine = Regex.Replace(configLine, @"\bShift=true\b", "Shift=false", RegexOptions.Compiled, time);
                configLine = Regex.Replace(configLine, @"\bControl=false\b", "Control=true", RegexOptions.Compiled,
                    time);
            }

            return NameConstant + lineToCheck + configLine;
        }

        /// <summary>
        ///     Called by applyButton in Keybindform.
        ///     Checks if there are any unbound keys, sets 'inputsOK' accordingly.
        /// </summary>
        /// <returns>inputsOK</returns>
        public static bool validateInput()
        {
            bool inputsOk = true;
            foreach (Button bt in Program.MyFactory.Keybinds.ButtonList)
            {
                if (bt.Text.Equals("Unbound"))
                {
                    inputsOk = false;
                }
            }

            return inputsOk;
        }
    }
}