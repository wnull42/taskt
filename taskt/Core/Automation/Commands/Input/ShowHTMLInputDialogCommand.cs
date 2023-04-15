﻿using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using taskt.Core.Automation.Attributes.PropertyAttributes;

namespace taskt.Core.Automation.Commands
{
    [Serializable]
    [Attributes.ClassAttributes.Group("Input Commands")]
    [Attributes.ClassAttributes.CommandSettings("Show HTML Input Dialog")]
    [Attributes.ClassAttributes.Description("Allows the entry of data into a web-enabled form")]
    [Attributes.ClassAttributes.UsesDescription("Use this command when you want a fancy data collection.")]
    [Attributes.ClassAttributes.ImplementationDescription("This command implements 'WebBrowser Control' to achieve automation.")]
    [Attributes.ClassAttributes.EnableAutomateRender(true)]
    [Attributes.ClassAttributes.EnableAutomateDisplayText(true)]
    public class ShowHTMLInputDialogCommand : ScriptCommand
    {
        [XmlAttribute]
        [PropertyVirtualProperty(nameof(GeneralPropertyControls), nameof(GeneralPropertyControls.v_MultiLinesTextBox))]
        [PropertyDescription("HTML for the Dialog")]
        [InputSpecification("HTML", true)]
        [PropertyCustomUIHelper("Launch HTML Builder", nameof(ShowHTMLBuilder))]
        [PropertyValidationRule("HTML", PropertyValidationRule.ValidationRuleFlags.Empty)]
        [PropertyDisplayText(false, "")]
        // TODO: more shorter!
        [PropertyFirstValue(
@"<!DOCTYPE html>
<html lang=\""en\"" xmlns=\""http://www.w3.org/1999/xhtml\"">
<head>
  <meta charset=\""utf-8\"" />
  <title>Please Provide Information</title>
  <style type=\""text/css\"">
  /*!
   * Bootstrap v4.0.0 (https://getbootstrap.com)
   * Copyright 2011-2018 The Bootstrap Authors
   * Copyright 2011-2018 Twitter, Inc.
   * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
   */ 
   :root {
            --blue: #007bff;
            --indigo: #6610f2;
            --purple: #6f42c1;
            --pink: #e83e8c;
            --red: #dc3545;
            --orange: #fd7e14;
            --yellow: #ffc107;
            --green: #28a745;
            --teal: #20c997;
            --cyan: #17a2b8;
            --white: #fff;
            --gray: #6c757d;
            --gray-dark: #343a40;
            --primary: #007bff;
            --secondary: #6c757d;
            --success: #28a745;
            --info: #17a2b8;
            --warning: #ffc107;
            --danger: #dc3545;
            --light: #f8f9fa;
            --dark: #343a40;
            --breakpoint-xs: 0;
            --breakpoint-sm: 576px;
            --breakpoint-md: 768px;
            --breakpoint-lg: 992px;
            --breakpoint-xl: 1200px;
            --font-family-sans-serif: -apple-system,BlinkMacSystemFont,\""Segoe UI\"",Roboto,\""Helvetica Neue\"",Arial,sans-serif,\""Apple Color Emoji\"",\""Segoe UI Emoji\"",\""Segoe UI Symbol\"";
            --font-family-monospace: SFMono-Regular,Menlo,Monaco,Consolas,\""Liberation Mono\"",\""Courier New\"",monospace
        }

        *, ::after, ::before {
            box-sizing: border-box
        }

        html {
            font-family: sans-serif;
            line-height: 1.15;
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
            -ms-overflow-style: scrollbar;
            -webkit-tap-highlight-color: transparent
        }

        @-ms-viewport {
            width: device-width
        }

        article, aside, dialog, figcaption, figure, footer, header, hgroup, main, nav, section {
            display: block
        }

        body {
            margin: 0;
            font-family: -apple-system,BlinkMacSystemFont,\""Segoe UI\"",Roboto,\""Helvetica Neue\"",Arial,sans-serif,\""Apple Color Emoji\"",\""Segoe UI Emoji\"",\""Segoe UI Symbol\"";
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #212529;
            text-align: left;
            background-color: #fff
        }

        [tabindex=\""-1\""]:focus {
            outline: 0 !important
        }

        hr {
            box-sizing: content-box;
            height: 0;
            overflow: visible
        }

        h1, h2, h3, h4, h5, h6 {
            margin-top: 0;
            margin-bottom: .5rem
        }

        p {
            margin-top: 0;
            margin-bottom: 1rem
        }

        abbr[data-original-title], abbr[title] {
            text-decoration: underline;
            -webkit-text-decoration: underline dotted;
            text-decoration: underline dotted;
            cursor: help;
            border-bottom: 0
        }

        address {
            margin-bottom: 1rem;
            font-style: normal;
            line-height: inherit
        }

        dl, ol, ul {
            margin-top: 0;
            margin-bottom: 1rem
        }

            ol ol, ol ul, ul ol, ul ul {
                margin-bottom: 0
            }

        dt {
            font-weight: 700
        }

        dd {
            margin-bottom: .5rem;
            margin-left: 0
        }

        blockquote {
            margin: 0 0 1rem
        }

        dfn {
            font-style: italic
        }

        b, strong {
            font-weight: bolder
        }

        small {
            font-size: 80%
        }

        sub, sup {
            position: relative;
            font-size: 75%;
            line-height: 0;
            vertical-align: baseline
        }

        sub {
            bottom: -.25em
        }

        sup {
            top: -.5em
        }

        a {
            color: #007bff;
            text-decoration: none;
            background-color: transparent;
            -webkit-text-decoration-skip: objects
        }

            a:hover {
                color: #0056b3;
                text-decoration: underline
            }

            a:not([href]):not([tabindex]) {
                color: inherit;
                text-decoration: none
            }

                a:not([href]):not([tabindex]):focus, a:not([href]):not([tabindex]):hover {
                    color: inherit;
                    text-decoration: none
                }

                a:not([href]):not([tabindex]):focus {
                    outline: 0
                }

        code, kbd, pre, samp {
            font-family: monospace,monospace;
            font-size: 1em
        }

        pre {
            margin-top: 0;
            margin-bottom: 1rem;
            overflow: auto;
            -ms-overflow-style: scrollbar
        }

        figure {
            margin: 0 0 1rem
        }

        img {
            vertical-align: middle;
            border-style: none
        }

        svg:not(:root) {
            overflow: hidden
        }

        table {
            border-collapse: collapse
        }

        caption {
            padding-top: .75rem;
            padding-bottom: .75rem;
            color: #6c757d;
            text-align: left;
            caption-side: bottom
        }

        th {
            text-align: inherit
        }

        label {
            display: inline-block;
            margin-bottom: .5rem
        }

        button {
            border-radius: 0
        }

            button:focus {
                outline: 1px dotted;
                outline: 5px auto -webkit-focus-ring-color
            }

        button, input, optgroup, select, textarea {
            margin: 0;
            font-family: inherit;
            font-size: inherit;
            line-height: inherit
        }

        button, input {
            overflow: visible
        }

        button, select {
            text-transform: none
        }

        [type=reset], [type=submit], button, html [type=button] {
            -webkit-appearance: button
        }

            [type=button]::-moz-focus-inner, [type=reset]::-moz-focus-inner, [type=submit]::-moz-focus-inner, button::-moz-focus-inner {
                padding: 0;
                border-style: none
            }

        input[type=checkbox], input[type=radio] {
            box-sizing: border-box;
            padding: 0
        }

        input[type=date], input[type=datetime-local], input[type=month], input[type=time] {
            -webkit-appearance: listbox
        }

        textarea {
            overflow: auto;
            resize: vertical
        }

        fieldset {
            min-width: 0;
            padding: 0;
            margin: 0;
            border: 0
        }

        legend {
            display: block;
            width: 100%;
            max-width: 100%;
            padding: 0;
            margin-bottom: .5rem;
            font-size: 1.5rem;
            line-height: inherit;
            color: inherit;
            white-space: normal
        }

        progress {
            vertical-align: baseline
        }

        [type=number]::-webkit-inner-spin-button, [type=number]::-webkit-outer-spin-button {
            height: auto
        }

        [type=search] {
            outline-offset: -2px;
            -webkit-appearance: none
        }

            [type=search]::-webkit-search-cancel-button, [type=search]::-webkit-search-decoration {
                -webkit-appearance: none
            }

        ::-webkit-file-upload-button {
            font: inherit;
            -webkit-appearance: button
        }

        output {
            display: inline-block
        }

        summary {
            display: list-item;
            cursor: pointer
        }

        template {
            display: none
        }

        [hidden] {
            display: none !important
        }

        .h1, .h2, .h3, .h4, .h5, .h6, h1, h2, h3, h4, h5, h6 {
            margin-bottom: .5rem;
            font-family: inherit;
            font-weight: 500;
            line-height: 1.2;
            color: inherit
        }

        .h1, h1 {
            font-size: 2.5rem
        }

        .h2, h2 {
            font-size: 2rem
        }

        .h3, h3 {
            font-size: 1.75rem
        }

        .h4, h4 {
            font-size: 1.5rem
        }

        .h5, h5 {
            font-size: 1.25rem
        }

        .h6, h6 {
            font-size: 1rem
        }

        .lead {
            font-size: 1.25rem;
            font-weight: 300
        }

        .display-1 {
            font-size: 6rem;
            font-weight: 300;
            line-height: 1.2
        }

        .display-2 {
            font-size: 5.5rem;
            font-weight: 300;
            line-height: 1.2
        }

        .display-3 {
            font-size: 4.5rem;
            font-weight: 300;
            line-height: 1.2
        }

        .display-4 {
            font-size: 3.5rem;
            font-weight: 300;
            line-height: 1.2
        }

        hr {
            margin-top: 1rem;
            margin-bottom: 1rem;
            border: 0;
            border-top: 1px solid rgba(0,0,0,.1)
        }

        .small, small {
            font-size: 80%;
            font-weight: 400
        }

        .mark, mark {
            padding: .2em;
            background-color: #fcf8e3
        }

        .list-unstyled {
            padding-left: 0;
            list-style: none
        }

        .list-inline {
            padding-left: 0;
            list-style: none
        }

        .list-inline-item {
            display: inline-block
        }

            .list-inline-item:not(:last-child) {
                margin-right: .5rem
            }

        .initialism {
            font-size: 90%;
            text-transform: uppercase
        }

        .blockquote {
            margin-bottom: 1rem;
            font-size: 1.25rem
        }

        .blockquote-footer {
            display: block;
            font-size: 80%;
            color: #6c757d
        }

            .blockquote-footer::before {
                content: \""\\2014 \\00A0\""
            }

        .img-fluid {
            max-width: 100%;
            height: auto
        }

        .img-thumbnail {
            padding: .25rem;
            background-color: #fff;
            border: 1px solid #dee2e6;
            border-radius: .25rem;
            max-width: 100%;
            height: auto
        }

        .figure {
            display: inline-block
        }

        .figure-img {
            margin-bottom: .5rem;
            line-height: 1
        }

        .figure-caption {
            font-size: 90%;
            color: #6c757d
        }

        code, kbd, pre, samp {
            font-family: SFMono-Regular,Menlo,Monaco,Consolas,\""Liberation Mono\"",\""Courier New\"",monospace
        }

        code {
            font-size: 87.5%;
            color: #e83e8c;
            word-break: break-word
        }

        a > code {
            color: inherit
        }

        kbd {
            padding: .2rem .4rem;
            font-size: 87.5%;
            color: #fff;
            background-color: #212529;
            border-radius: .2rem
        }

            kbd kbd {
                padding: 0;
                font-size: 100%;
                font-weight: 700
            }

        pre {
            display: block;
            font-size: 87.5%;
            color: #212529
        }

            pre code {
                font-size: inherit;
                color: inherit;
                word-break: normal
            }

        .pre-scrollable {
            max-height: 340px;
            overflow-y: scroll
        }

        .container {
            width: 100%;
            padding-right: 15px;
            padding-left: 15px;
            margin-right: auto;
            margin-left: auto
        }

        @media (min-width:576px) {
            .container {
                max-width: 540px
            }
        }

        @media (min-width:768px) {
            .container {
                max-width: 720px
            }
        }

        @media (min-width:992px) {
            .container {
                max-width: 960px
            }
        }

        @media (min-width:1200px) {
            .container {
                max-width: 1140px
            }
        }

        .container-fluid {
            width: 100%;
            padding-right: 15px;
            padding-left: 15px;
            margin-right: auto;
            margin-left: auto
        }

        .row {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            margin-right: -15px;
            margin-left: -15px
        }

        .no-gutters {
            margin-right: 0;
            margin-left: 0
        }

            .no-gutters > .col, .no-gutters > [class*=col-] {
                padding-right: 0;
                padding-left: 0
            }

        .col, .col-1, .col-10, .col-11, .col-12, .col-2, .col-3, .col-4, .col-5, .col-6, .col-7, .col-8, .col-9, .col-auto, .col-lg, .col-lg-1, .col-lg-10, .col-lg-11, .col-lg-12, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-auto, .col-md, .col-md-1, .col-md-10, .col-md-11, .col-md-12, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-auto, .col-sm, .col-sm-1, .col-sm-10, .col-sm-11, .col-sm-12, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-auto, .col-xl, .col-xl-1, .col-xl-10, .col-xl-11, .col-xl-12, .col-xl-2, .col-xl-3, .col-xl-4, .col-xl-5, .col-xl-6, .col-xl-7, .col-xl-8, .col-xl-9, .col-xl-auto {
            position: relative;
            width: 100%;
            min-height: 1px;
            padding-right: 15px;
            padding-left: 15px
        }

        .col {
            -ms-flex-preferred-size: 0;
            flex-basis: 0;
            -webkit-box-flex: 1;
            -ms-flex-positive: 1;
            flex-grow: 1;
            max-width: 100%
        }

        .col-auto {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 auto;
            flex: 0 0 auto;
            width: auto;
            max-width: none
        }

        .col-1 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 8.333333%;
            flex: 0 0 8.333333%;
            max-width: 8.333333%
        }

        .col-2 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 16.666667%;
            flex: 0 0 16.666667%;
            max-width: 16.666667%
        }

        .col-3 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 25%;
            flex: 0 0 25%;
            max-width: 25%
        }

        .col-4 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 33.333333%;
            flex: 0 0 33.333333%;
            max-width: 33.333333%
        }

        .col-5 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 41.666667%;
            flex: 0 0 41.666667%;
            max-width: 41.666667%
        }

        .col-6 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 50%;
            flex: 0 0 50%;
            max-width: 50%
        }

        .col-7 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 58.333333%;
            flex: 0 0 58.333333%;
            max-width: 58.333333%
        }

        .col-8 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 66.666667%;
            flex: 0 0 66.666667%;
            max-width: 66.666667%
        }

        .col-9 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 75%;
            flex: 0 0 75%;
            max-width: 75%
        }

        .col-10 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 83.333333%;
            flex: 0 0 83.333333%;
            max-width: 83.333333%
        }

        .col-11 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 91.666667%;
            flex: 0 0 91.666667%;
            max-width: 91.666667%
        }

        .col-12 {
            -webkit-box-flex: 0;
            -ms-flex: 0 0 100%;
            flex: 0 0 100%;
            max-width: 100%
        }

        .order-first {
            -webkit-box-ordinal-group: 0;
            -ms-flex-order: -1;
            order: -1
        }

        .order-last {
            -webkit-box-ordinal-group: 14;
            -ms-flex-order: 13;
            order: 13
        }

        .order-0 {
            -webkit-box-ordinal-group: 1;
            -ms-flex-order: 0;
            order: 0
        }

        .order-1 {
            -webkit-box-ordinal-group: 2;
            -ms-flex-order: 1;
            order: 1
        }

        .order-2 {
            -webkit-box-ordinal-group: 3;
            -ms-flex-order: 2;
            order: 2
        }

        .order-3 {
            -webkit-box-ordinal-group: 4;
            -ms-flex-order: 3;
            order: 3
        }

        .order-4 {
            -webkit-box-ordinal-group: 5;
            -ms-flex-order: 4;
            order: 4
        }

        .order-5 {
            -webkit-box-ordinal-group: 6;
            -ms-flex-order: 5;
            order: 5
        }

        .order-6 {
            -webkit-box-ordinal-group: 7;
            -ms-flex-order: 6;
            order: 6
        }

        .order-7 {
            -webkit-box-ordinal-group: 8;
            -ms-flex-order: 7;
            order: 7
        }

        .order-8 {
            -webkit-box-ordinal-group: 9;
            -ms-flex-order: 8;
            order: 8
        }

        .order-9 {
            -webkit-box-ordinal-group: 10;
            -ms-flex-order: 9;
            order: 9
        }

        .order-10 {
            -webkit-box-ordinal-group: 11;
            -ms-flex-order: 10;
            order: 10
        }

        .order-11 {
            -webkit-box-ordinal-group: 12;
            -ms-flex-order: 11;
            order: 11
        }

        .order-12 {
            -webkit-box-ordinal-group: 13;
            -ms-flex-order: 12;
            order: 12
        }

        .offset-1 {
            margin-left: 8.333333%
        }

        .offset-2 {
            margin-left: 16.666667%
        }

        .offset-3 {
            margin-left: 25%
        }

        .offset-4 {
            margin-left: 33.333333%
        }

        .offset-5 {
            margin-left: 41.666667%
        }

        .offset-6 {
            margin-left: 50%
        }

        .offset-7 {
            margin-left: 58.333333%
        }

        .offset-8 {
            margin-left: 66.666667%
        }

        .offset-9 {
            margin-left: 75%
        }

        .offset-10 {
            margin-left: 83.333333%
        }

        .offset-11 {
            margin-left: 91.666667%
        }

        @media (min-width:576px) {
            .col-sm {
                -ms-flex-preferred-size: 0;
                flex-basis: 0;
                -webkit-box-flex: 1;
                -ms-flex-positive: 1;
                flex-grow: 1;
                max-width: 100%
            }

            .col-sm-auto {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 auto;
                flex: 0 0 auto;
                width: auto;
                max-width: none
            }

            .col-sm-1 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 8.333333%;
                flex: 0 0 8.333333%;
                max-width: 8.333333%
            }

            .col-sm-2 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 16.666667%;
                flex: 0 0 16.666667%;
                max-width: 16.666667%
            }

            .col-sm-3 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 25%;
                flex: 0 0 25%;
                max-width: 25%
            }

            .col-sm-4 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 33.333333%;
                flex: 0 0 33.333333%;
                max-width: 33.333333%
            }

            .col-sm-5 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 41.666667%;
                flex: 0 0 41.666667%;
                max-width: 41.666667%
            }

            .col-sm-6 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 50%;
                flex: 0 0 50%;
                max-width: 50%
            }

            .col-sm-7 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 58.333333%;
                flex: 0 0 58.333333%;
                max-width: 58.333333%
            }

            .col-sm-8 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 66.666667%;
                flex: 0 0 66.666667%;
                max-width: 66.666667%
            }

            .col-sm-9 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 75%;
                flex: 0 0 75%;
                max-width: 75%
            }

            .col-sm-10 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 83.333333%;
                flex: 0 0 83.333333%;
                max-width: 83.333333%
            }

            .col-sm-11 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 91.666667%;
                flex: 0 0 91.666667%;
                max-width: 91.666667%
            }

            .col-sm-12 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 100%;
                flex: 0 0 100%;
                max-width: 100%
            }

            .order-sm-first {
                -webkit-box-ordinal-group: 0;
                -ms-flex-order: -1;
                order: -1
            }

            .order-sm-last {
                -webkit-box-ordinal-group: 14;
                -ms-flex-order: 13;
                order: 13
            }

            .order-sm-0 {
                -webkit-box-ordinal-group: 1;
                -ms-flex-order: 0;
                order: 0
            }

            .order-sm-1 {
                -webkit-box-ordinal-group: 2;
                -ms-flex-order: 1;
                order: 1
            }

            .order-sm-2 {
                -webkit-box-ordinal-group: 3;
                -ms-flex-order: 2;
                order: 2
            }

            .order-sm-3 {
                -webkit-box-ordinal-group: 4;
                -ms-flex-order: 3;
                order: 3
            }

            .order-sm-4 {
                -webkit-box-ordinal-group: 5;
                -ms-flex-order: 4;
                order: 4
            }

            .order-sm-5 {
                -webkit-box-ordinal-group: 6;
                -ms-flex-order: 5;
                order: 5
            }

            .order-sm-6 {
                -webkit-box-ordinal-group: 7;
                -ms-flex-order: 6;
                order: 6
            }

            .order-sm-7 {
                -webkit-box-ordinal-group: 8;
                -ms-flex-order: 7;
                order: 7
            }

            .order-sm-8 {
                -webkit-box-ordinal-group: 9;
                -ms-flex-order: 8;
                order: 8
            }

            .order-sm-9 {
                -webkit-box-ordinal-group: 10;
                -ms-flex-order: 9;
                order: 9
            }

            .order-sm-10 {
                -webkit-box-ordinal-group: 11;
                -ms-flex-order: 10;
                order: 10
            }

            .order-sm-11 {
                -webkit-box-ordinal-group: 12;
                -ms-flex-order: 11;
                order: 11
            }

            .order-sm-12 {
                -webkit-box-ordinal-group: 13;
                -ms-flex-order: 12;
                order: 12
            }

            .offset-sm-0 {
                margin-left: 0
            }

            .offset-sm-1 {
                margin-left: 8.333333%
            }

            .offset-sm-2 {
                margin-left: 16.666667%
            }

            .offset-sm-3 {
                margin-left: 25%
            }

            .offset-sm-4 {
                margin-left: 33.333333%
            }

            .offset-sm-5 {
                margin-left: 41.666667%
            }

            .offset-sm-6 {
                margin-left: 50%
            }

            .offset-sm-7 {
                margin-left: 58.333333%
            }

            .offset-sm-8 {
                margin-left: 66.666667%
            }

            .offset-sm-9 {
                margin-left: 75%
            }

            .offset-sm-10 {
                margin-left: 83.333333%
            }

            .offset-sm-11 {
                margin-left: 91.666667%
            }
        }

        @media (min-width:768px) {
            .col-md {
                -ms-flex-preferred-size: 0;
                flex-basis: 0;
                -webkit-box-flex: 1;
                -ms-flex-positive: 1;
                flex-grow: 1;
                max-width: 100%
            }

            .col-md-auto {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 auto;
                flex: 0 0 auto;
                width: auto;
                max-width: none
            }

            .col-md-1 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 8.333333%;
                flex: 0 0 8.333333%;
                max-width: 8.333333%
            }

            .col-md-2 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 16.666667%;
                flex: 0 0 16.666667%;
                max-width: 16.666667%
            }

            .col-md-3 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 25%;
                flex: 0 0 25%;
                max-width: 25%
            }

            .col-md-4 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 33.333333%;
                flex: 0 0 33.333333%;
                max-width: 33.333333%
            }

            .col-md-5 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 41.666667%;
                flex: 0 0 41.666667%;
                max-width: 41.666667%
            }

            .col-md-6 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 50%;
                flex: 0 0 50%;
                max-width: 50%
            }

            .col-md-7 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 58.333333%;
                flex: 0 0 58.333333%;
                max-width: 58.333333%
            }

            .col-md-8 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 66.666667%;
                flex: 0 0 66.666667%;
                max-width: 66.666667%
            }

            .col-md-9 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 75%;
                flex: 0 0 75%;
                max-width: 75%
            }

            .col-md-10 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 83.333333%;
                flex: 0 0 83.333333%;
                max-width: 83.333333%
            }

            .col-md-11 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 91.666667%;
                flex: 0 0 91.666667%;
                max-width: 91.666667%
            }

            .col-md-12 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 100%;
                flex: 0 0 100%;
                max-width: 100%
            }

            .order-md-first {
                -webkit-box-ordinal-group: 0;
                -ms-flex-order: -1;
                order: -1
            }

            .order-md-last {
                -webkit-box-ordinal-group: 14;
                -ms-flex-order: 13;
                order: 13
            }

            .order-md-0 {
                -webkit-box-ordinal-group: 1;
                -ms-flex-order: 0;
                order: 0
            }

            .order-md-1 {
                -webkit-box-ordinal-group: 2;
                -ms-flex-order: 1;
                order: 1
            }

            .order-md-2 {
                -webkit-box-ordinal-group: 3;
                -ms-flex-order: 2;
                order: 2
            }

            .order-md-3 {
                -webkit-box-ordinal-group: 4;
                -ms-flex-order: 3;
                order: 3
            }

            .order-md-4 {
                -webkit-box-ordinal-group: 5;
                -ms-flex-order: 4;
                order: 4
            }

            .order-md-5 {
                -webkit-box-ordinal-group: 6;
                -ms-flex-order: 5;
                order: 5
            }

            .order-md-6 {
                -webkit-box-ordinal-group: 7;
                -ms-flex-order: 6;
                order: 6
            }

            .order-md-7 {
                -webkit-box-ordinal-group: 8;
                -ms-flex-order: 7;
                order: 7
            }

            .order-md-8 {
                -webkit-box-ordinal-group: 9;
                -ms-flex-order: 8;
                order: 8
            }

            .order-md-9 {
                -webkit-box-ordinal-group: 10;
                -ms-flex-order: 9;
                order: 9
            }

            .order-md-10 {
                -webkit-box-ordinal-group: 11;
                -ms-flex-order: 10;
                order: 10
            }

            .order-md-11 {
                -webkit-box-ordinal-group: 12;
                -ms-flex-order: 11;
                order: 11
            }

            .order-md-12 {
                -webkit-box-ordinal-group: 13;
                -ms-flex-order: 12;
                order: 12
            }

            .offset-md-0 {
                margin-left: 0
            }

            .offset-md-1 {
                margin-left: 8.333333%
            }

            .offset-md-2 {
                margin-left: 16.666667%
            }

            .offset-md-3 {
                margin-left: 25%
            }

            .offset-md-4 {
                margin-left: 33.333333%
            }

            .offset-md-5 {
                margin-left: 41.666667%
            }

            .offset-md-6 {
                margin-left: 50%
            }

            .offset-md-7 {
                margin-left: 58.333333%
            }

            .offset-md-8 {
                margin-left: 66.666667%
            }

            .offset-md-9 {
                margin-left: 75%
            }

            .offset-md-10 {
                margin-left: 83.333333%
            }

            .offset-md-11 {
                margin-left: 91.666667%
            }
        }

        @media (min-width:992px) {
            .col-lg {
                -ms-flex-preferred-size: 0;
                flex-basis: 0;
                -webkit-box-flex: 1;
                -ms-flex-positive: 1;
                flex-grow: 1;
                max-width: 100%
            }

            .col-lg-auto {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 auto;
                flex: 0 0 auto;
                width: auto;
                max-width: none
            }

            .col-lg-1 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 8.333333%;
                flex: 0 0 8.333333%;
                max-width: 8.333333%
            }

            .col-lg-2 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 16.666667%;
                flex: 0 0 16.666667%;
                max-width: 16.666667%
            }

            .col-lg-3 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 25%;
                flex: 0 0 25%;
                max-width: 25%
            }

            .col-lg-4 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 33.333333%;
                flex: 0 0 33.333333%;
                max-width: 33.333333%
            }

            .col-lg-5 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 41.666667%;
                flex: 0 0 41.666667%;
                max-width: 41.666667%
            }

            .col-lg-6 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 50%;
                flex: 0 0 50%;
                max-width: 50%
            }

            .col-lg-7 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 58.333333%;
                flex: 0 0 58.333333%;
                max-width: 58.333333%
            }

            .col-lg-8 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 66.666667%;
                flex: 0 0 66.666667%;
                max-width: 66.666667%
            }

            .col-lg-9 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 75%;
                flex: 0 0 75%;
                max-width: 75%
            }

            .col-lg-10 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 83.333333%;
                flex: 0 0 83.333333%;
                max-width: 83.333333%
            }

            .col-lg-11 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 91.666667%;
                flex: 0 0 91.666667%;
                max-width: 91.666667%
            }

            .col-lg-12 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 100%;
                flex: 0 0 100%;
                max-width: 100%
            }

            .order-lg-first {
                -webkit-box-ordinal-group: 0;
                -ms-flex-order: -1;
                order: -1
            }

            .order-lg-last {
                -webkit-box-ordinal-group: 14;
                -ms-flex-order: 13;
                order: 13
            }

            .order-lg-0 {
                -webkit-box-ordinal-group: 1;
                -ms-flex-order: 0;
                order: 0
            }

            .order-lg-1 {
                -webkit-box-ordinal-group: 2;
                -ms-flex-order: 1;
                order: 1
            }

            .order-lg-2 {
                -webkit-box-ordinal-group: 3;
                -ms-flex-order: 2;
                order: 2
            }

            .order-lg-3 {
                -webkit-box-ordinal-group: 4;
                -ms-flex-order: 3;
                order: 3
            }

            .order-lg-4 {
                -webkit-box-ordinal-group: 5;
                -ms-flex-order: 4;
                order: 4
            }

            .order-lg-5 {
                -webkit-box-ordinal-group: 6;
                -ms-flex-order: 5;
                order: 5
            }

            .order-lg-6 {
                -webkit-box-ordinal-group: 7;
                -ms-flex-order: 6;
                order: 6
            }

            .order-lg-7 {
                -webkit-box-ordinal-group: 8;
                -ms-flex-order: 7;
                order: 7
            }

            .order-lg-8 {
                -webkit-box-ordinal-group: 9;
                -ms-flex-order: 8;
                order: 8
            }

            .order-lg-9 {
                -webkit-box-ordinal-group: 10;
                -ms-flex-order: 9;
                order: 9
            }

            .order-lg-10 {
                -webkit-box-ordinal-group: 11;
                -ms-flex-order: 10;
                order: 10
            }

            .order-lg-11 {
                -webkit-box-ordinal-group: 12;
                -ms-flex-order: 11;
                order: 11
            }

            .order-lg-12 {
                -webkit-box-ordinal-group: 13;
                -ms-flex-order: 12;
                order: 12
            }

            .offset-lg-0 {
                margin-left: 0
            }

            .offset-lg-1 {
                margin-left: 8.333333%
            }

            .offset-lg-2 {
                margin-left: 16.666667%
            }

            .offset-lg-3 {
                margin-left: 25%
            }

            .offset-lg-4 {
                margin-left: 33.333333%
            }

            .offset-lg-5 {
                margin-left: 41.666667%
            }

            .offset-lg-6 {
                margin-left: 50%
            }

            .offset-lg-7 {
                margin-left: 58.333333%
            }

            .offset-lg-8 {
                margin-left: 66.666667%
            }

            .offset-lg-9 {
                margin-left: 75%
            }

            .offset-lg-10 {
                margin-left: 83.333333%
            }

            .offset-lg-11 {
                margin-left: 91.666667%
            }
        }

        @media (min-width:1200px) {
            .col-xl {
                -ms-flex-preferred-size: 0;
                flex-basis: 0;
                -webkit-box-flex: 1;
                -ms-flex-positive: 1;
                flex-grow: 1;
                max-width: 100%
            }

            .col-xl-auto {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 auto;
                flex: 0 0 auto;
                width: auto;
                max-width: none
            }

            .col-xl-1 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 8.333333%;
                flex: 0 0 8.333333%;
                max-width: 8.333333%
            }

            .col-xl-2 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 16.666667%;
                flex: 0 0 16.666667%;
                max-width: 16.666667%
            }

            .col-xl-3 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 25%;
                flex: 0 0 25%;
                max-width: 25%
            }

            .col-xl-4 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 33.333333%;
                flex: 0 0 33.333333%;
                max-width: 33.333333%
            }

            .col-xl-5 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 41.666667%;
                flex: 0 0 41.666667%;
                max-width: 41.666667%
            }

            .col-xl-6 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 50%;
                flex: 0 0 50%;
                max-width: 50%
            }

            .col-xl-7 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 58.333333%;
                flex: 0 0 58.333333%;
                max-width: 58.333333%
            }

            .col-xl-8 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 66.666667%;
                flex: 0 0 66.666667%;
                max-width: 66.666667%
            }

            .col-xl-9 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 75%;
                flex: 0 0 75%;
                max-width: 75%
            }

            .col-xl-10 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 83.333333%;
                flex: 0 0 83.333333%;
                max-width: 83.333333%
            }

            .col-xl-11 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 91.666667%;
                flex: 0 0 91.666667%;
                max-width: 91.666667%
            }

            .col-xl-12 {
                -webkit-box-flex: 0;
                -ms-flex: 0 0 100%;
                flex: 0 0 100%;
                max-width: 100%
            }

            .order-xl-first {
                -webkit-box-ordinal-group: 0;
                -ms-flex-order: -1;
                order: -1
            }

            .order-xl-last {
                -webkit-box-ordinal-group: 14;
                -ms-flex-order: 13;
                order: 13
            }

            .order-xl-0 {
                -webkit-box-ordinal-group: 1;
                -ms-flex-order: 0;
                order: 0
            }

            .order-xl-1 {
                -webkit-box-ordinal-group: 2;
                -ms-flex-order: 1;
                order: 1
            }

            .order-xl-2 {
                -webkit-box-ordinal-group: 3;
                -ms-flex-order: 2;
                order: 2
            }

            .order-xl-3 {
                -webkit-box-ordinal-group: 4;
                -ms-flex-order: 3;
                order: 3
            }

            .order-xl-4 {
                -webkit-box-ordinal-group: 5;
                -ms-flex-order: 4;
                order: 4
            }

            .order-xl-5 {
                -webkit-box-ordinal-group: 6;
                -ms-flex-order: 5;
                order: 5
            }

            .order-xl-6 {
                -webkit-box-ordinal-group: 7;
                -ms-flex-order: 6;
                order: 6
            }

            .order-xl-7 {
                -webkit-box-ordinal-group: 8;
                -ms-flex-order: 7;
                order: 7
            }

            .order-xl-8 {
                -webkit-box-ordinal-group: 9;
                -ms-flex-order: 8;
                order: 8
            }

            .order-xl-9 {
                -webkit-box-ordinal-group: 10;
                -ms-flex-order: 9;
                order: 9
            }

            .order-xl-10 {
                -webkit-box-ordinal-group: 11;
                -ms-flex-order: 10;
                order: 10
            }

            .order-xl-11 {
                -webkit-box-ordinal-group: 12;
                -ms-flex-order: 11;
                order: 11
            }

            .order-xl-12 {
                -webkit-box-ordinal-group: 13;
                -ms-flex-order: 12;
                order: 12
            }

            .offset-xl-0 {
                margin-left: 0
            }

            .offset-xl-1 {
                margin-left: 8.333333%
            }

            .offset-xl-2 {
                margin-left: 16.666667%
            }

            .offset-xl-3 {
                margin-left: 25%
            }

            .offset-xl-4 {
                margin-left: 33.333333%
            }

            .offset-xl-5 {
                margin-left: 41.666667%
            }

            .offset-xl-6 {
                margin-left: 50%
            }

            .offset-xl-7 {
                margin-left: 58.333333%
            }

            .offset-xl-8 {
                margin-left: 66.666667%
            }

            .offset-xl-9 {
                margin-left: 75%
            }

            .offset-xl-10 {
                margin-left: 83.333333%
            }

            .offset-xl-11 {
                margin-left: 91.666667%
            }
        }

        .table {
            width: 100%;
            max-width: 100%;
            margin-bottom: 1rem;
            background-color: transparent
        }

            .table td, .table th {
                padding: .75rem;
                vertical-align: top;
                border-top: 1px solid #dee2e6
            }

            .table thead th {
                vertical-align: bottom;
                border-bottom: 2px solid #dee2e6
            }

            .table tbody + tbody {
                border-top: 2px solid #dee2e6
            }

            .table .table {
                background-color: #fff
            }

        .table-sm td, .table-sm th {
            padding: .3rem
        }

        .table-bordered {
            border: 1px solid #dee2e6
        }

            .table-bordered td, .table-bordered th {
                border: 1px solid #dee2e6
            }

            .table-bordered thead td, .table-bordered thead th {
                border-bottom-width: 2px
            }

        .table-striped tbody tr:nth-of-type(odd) {
            background-color: rgba(0,0,0,.05)
        }

        .table-hover tbody tr:hover {
            background-color: rgba(0,0,0,.075)
        }

        .table-primary, .table-primary > td, .table-primary > th {
            background-color: #b8daff
        }

        .table-hover .table-primary:hover {
            background-color: #9fcdff
        }

            .table-hover .table-primary:hover > td, .table-hover .table-primary:hover > th {
                background-color: #9fcdff
            }

        .table-secondary, .table-secondary > td, .table-secondary > th {
            background-color: #d6d8db
        }

        .table-hover .table-secondary:hover {
            background-color: #c8cbcf
        }

            .table-hover .table-secondary:hover > td, .table-hover .table-secondary:hover > th {
                background-color: #c8cbcf
            }

        .table-success, .table-success > td, .table-success > th {
            background-color: #c3e6cb
        }

        .table-hover .table-success:hover {
            background-color: #b1dfbb
        }

            .table-hover .table-success:hover > td, .table-hover .table-success:hover > th {
                background-color: #b1dfbb
            }

        .table-info, .table-info > td, .table-info > th {
            background-color: #bee5eb
        }

        .table-hover .table-info:hover {
            background-color: #abdde5
        }

            .table-hover .table-info:hover > td, .table-hover .table-info:hover > th {
                background-color: #abdde5
            }

        .table-warning, .table-warning > td, .table-warning > th {
            background-color: #ffeeba
        }

        .table-hover .table-warning:hover {
            background-color: #ffe8a1
        }

            .table-hover .table-warning:hover > td, .table-hover .table-warning:hover > th {
                background-color: #ffe8a1
            }

        .table-danger, .table-danger > td, .table-danger > th {
            background-color: #f5c6cb
        }

        .table-hover .table-danger:hover {
            background-color: #f1b0b7
        }

            .table-hover .table-danger:hover > td, .table-hover .table-danger:hover > th {
                background-color: #f1b0b7
            }

        .table-light, .table-light > td, .table-light > th {
            background-color: #fdfdfe
        }

        .table-hover .table-light:hover {
            background-color: #ececf6
        }

            .table-hover .table-light:hover > td, .table-hover .table-light:hover > th {
                background-color: #ececf6
            }

        .table-dark, .table-dark > td, .table-dark > th {
            background-color: #c6c8ca
        }

        .table-hover .table-dark:hover {
            background-color: #b9bbbe
        }

            .table-hover .table-dark:hover > td, .table-hover .table-dark:hover > th {
                background-color: #b9bbbe
            }

        .table-active, .table-active > td, .table-active > th {
            background-color: rgba(0,0,0,.075)
        }

        .table-hover .table-active:hover {
            background-color: rgba(0,0,0,.075)
        }

            .table-hover .table-active:hover > td, .table-hover .table-active:hover > th {
                background-color: rgba(0,0,0,.075)
            }

        .table .thead-dark th {
            color: #fff;
            background-color: #212529;
            border-color: #32383e
        }

        .table .thead-light th {
            color: #495057;
            background-color: #e9ecef;
            border-color: #dee2e6
        }

        .table-dark {
            color: #fff;
            background-color: #212529
        }

            .table-dark td, .table-dark th, .table-dark thead th {
                border-color: #32383e
            }

            .table-dark.table-bordered {
                border: 0
            }

            .table-dark.table-striped tbody tr:nth-of-type(odd) {
                background-color: rgba(255,255,255,.05)
            }

            .table-dark.table-hover tbody tr:hover {
                background-color: rgba(255,255,255,.075)
            }

        @media (max-width:575.98px) {
            .table-responsive-sm {
                display: block;
                width: 100%;
                overflow-x: auto;
                -webkit-overflow-scrolling: touch;
                -ms-overflow-style: -ms-autohiding-scrollbar
            }

                .table-responsive-sm > .table-bordered {
                    border: 0
                }
        }

        @media (max-width:767.98px) {
            .table-responsive-md {
                display: block;
                width: 100%;
                overflow-x: auto;
                -webkit-overflow-scrolling: touch;
                -ms-overflow-style: -ms-autohiding-scrollbar
            }

                .table-responsive-md > .table-bordered {
                    border: 0
                }
        }

        @media (max-width:991.98px) {
            .table-responsive-lg {
                display: block;
                width: 100%;
                overflow-x: auto;
                -webkit-overflow-scrolling: touch;
                -ms-overflow-style: -ms-autohiding-scrollbar
            }

                .table-responsive-lg > .table-bordered {
                    border: 0
                }
        }

        @media (max-width:1199.98px) {
            .table-responsive-xl {
                display: block;
                width: 100%;
                overflow-x: auto;
                -webkit-overflow-scrolling: touch;
                -ms-overflow-style: -ms-autohiding-scrollbar
            }

                .table-responsive-xl > .table-bordered {
                    border: 0
                }
        }

        .table-responsive {
            display: block;
            width: 100%;
            overflow-x: auto;
            -webkit-overflow-scrolling: touch;
            -ms-overflow-style: -ms-autohiding-scrollbar
        }

            .table-responsive > .table-bordered {
                border: 0
            }

        .form-control {
            display: block;
            width: 100%;
            padding: .375rem .75rem;
            font-size: 1rem;
            line-height: 1.5;
            color: #495057;
            background-color: #fff;
            background-clip: padding-box;
            border: 1px solid #ced4da;
            border-radius: .25rem;
            transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out
        }

            .form-control::-ms-expand {
                background-color: transparent;
                border: 0
            }

            .form-control:focus {
                color: #495057;
                background-color: #fff;
                border-color: #80bdff;
                outline: 0;
                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)
            }

            .form-control::-webkit-input-placeholder {
                color: #6c757d;
                opacity: 1
            }

            .form-control::-moz-placeholder {
                color: #6c757d;
                opacity: 1
            }

            .form-control:-ms-input-placeholder {
                color: #6c757d;
                opacity: 1
            }

            .form-control::-ms-input-placeholder {
                color: #6c757d;
                opacity: 1
            }

            .form-control::placeholder {
                color: #6c757d;
                opacity: 1
            }

            .form-control:disabled, .form-control[readonly] {
                background-color: #e9ecef;
                opacity: 1
            }

        select.form-control:not([size]):not([multiple]) {
            height: calc(2.25rem + 2px)
        }

        select.form-control:focus::-ms-value {
            color: #495057;
            background-color: #fff
        }

        .form-control-file, .form-control-range {
            display: block;
            width: 100%
        }

        .col-form-label {
            padding-top: calc(.375rem + 1px);
            padding-bottom: calc(.375rem + 1px);
            margin-bottom: 0;
            font-size: inherit;
            line-height: 1.5
        }

        .col-form-label-lg {
            padding-top: calc(.5rem + 1px);
            padding-bottom: calc(.5rem + 1px);
            font-size: 1.25rem;
            line-height: 1.5
        }

        .col-form-label-sm {
            padding-top: calc(.25rem + 1px);
            padding-bottom: calc(.25rem + 1px);
            font-size: .875rem;
            line-height: 1.5
        }

        .form-control-plaintext {
            display: block;
            width: 100%;
            padding-top: .375rem;
            padding-bottom: .375rem;
            margin-bottom: 0;
            line-height: 1.5;
            background-color: transparent;
            border: solid transparent;
            border-width: 1px 0
        }

            .form-control-plaintext.form-control-lg, .form-control-plaintext.form-control-sm, .input-group-lg > .form-control-plaintext.form-control, .input-group-lg > .input-group-append > .form-control-plaintext.btn, .input-group-lg > .input-group-append > .form-control-plaintext.input-group-text, .input-group-lg > .input-group-prepend > .form-control-plaintext.btn, .input-group-lg > .input-group-prepend > .form-control-plaintext.input-group-text, .input-group-sm > .form-control-plaintext.form-control, .input-group-sm > .input-group-append > .form-control-plaintext.btn, .input-group-sm > .input-group-append > .form-control-plaintext.input-group-text, .input-group-sm > .input-group-prepend > .form-control-plaintext.btn, .input-group-sm > .input-group-prepend > .form-control-plaintext.input-group-text {
                padding-right: 0;
                padding-left: 0
            }

        .form-control-sm, .input-group-sm > .form-control, .input-group-sm > .input-group-append > .btn, .input-group-sm > .input-group-append > .input-group-text, .input-group-sm > .input-group-prepend > .btn, .input-group-sm > .input-group-prepend > .input-group-text {
            padding: .25rem .5rem;
            font-size: .875rem;
            line-height: 1.5;
            border-radius: .2rem
        }

        .input-group-sm > .input-group-append > select.btn:not([size]):not([multiple]), .input-group-sm > .input-group-append > select.input-group-text:not([size]):not([multiple]), .input-group-sm > .input-group-prepend > select.btn:not([size]):not([multiple]), .input-group-sm > .input-group-prepend > select.input-group-text:not([size]):not([multiple]), .input-group-sm > select.form-control:not([size]):not([multiple]), select.form-control-sm:not([size]):not([multiple]) {
            height: calc(1.8125rem + 2px)
        }

        .form-control-lg, .input-group-lg > .form-control, .input-group-lg > .input-group-append > .btn, .input-group-lg > .input-group-append > .input-group-text, .input-group-lg > .input-group-prepend > .btn, .input-group-lg > .input-group-prepend > .input-group-text {
            padding: .5rem 1rem;
            font-size: 1.25rem;
            line-height: 1.5;
            border-radius: .3rem
        }

        .input-group-lg > .input-group-append > select.btn:not([size]):not([multiple]), .input-group-lg > .input-group-append > select.input-group-text:not([size]):not([multiple]), .input-group-lg > .input-group-prepend > select.btn:not([size]):not([multiple]), .input-group-lg > .input-group-prepend > select.input-group-text:not([size]):not([multiple]), .input-group-lg > select.form-control:not([size]):not([multiple]), select.form-control-lg:not([size]):not([multiple]) {
            height: calc(2.875rem + 2px)
        }

        .form-group {
            margin-bottom: 1rem
        }

        .form-text {
            display: block;
            margin-top: .25rem
        }

        .form-row {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            margin-right: -5px;
            margin-left: -5px
        }

            .form-row > .col, .form-row > [class*=col-] {
                padding-right: 5px;
                padding-left: 5px
            }

        .form-check {
            position: relative;
            display: block;
            padding-left: 1.25rem
        }

        .form-check-input {
            position: absolute;
            margin-top: .3rem;
            margin-left: -1.25rem
        }

            .form-check-input:disabled ~ .form-check-label {
                color: #6c757d
            }

        .form-check-label {
            margin-bottom: 0
        }

        .form-check-inline {
            display: -webkit-inline-box;
            display: -ms-inline-flexbox;
            display: inline-flex;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center;
            padding-left: 0;
            margin-right: .75rem
        }

            .form-check-inline .form-check-input {
                position: static;
                margin-top: 0;
                margin-right: .3125rem;
                margin-left: 0
            }

        .valid-feedback {
            display: none;
            width: 100%;
            margin-top: .25rem;
            font-size: 80%;
            color: #28a745
        }

        .valid-tooltip {
            position: absolute;
            top: 100%;
            z-index: 5;
            display: none;
            max-width: 100%;
            padding: .5rem;
            margin-top: .1rem;
            font-size: .875rem;
            line-height: 1;
            color: #fff;
            background-color: rgba(40,167,69,.8);
            border-radius: .2rem
        }

        .custom-select.is-valid, .form-control.is-valid, .was-validated .custom-select:valid, .was-validated .form-control:valid {
            border-color: #28a745
        }

            .custom-select.is-valid:focus, .form-control.is-valid:focus, .was-validated .custom-select:valid:focus, .was-validated .form-control:valid:focus {
                border-color: #28a745;
                box-shadow: 0 0 0 .2rem rgba(40,167,69,.25)
            }

            .custom-select.is-valid ~ .valid-feedback, .custom-select.is-valid ~ .valid-tooltip, .form-control.is-valid ~ .valid-feedback, .form-control.is-valid ~ .valid-tooltip, .was-validated .custom-select:valid ~ .valid-feedback, .was-validated .custom-select:valid ~ .valid-tooltip, .was-validated .form-control:valid ~ .valid-feedback, .was-validated .form-control:valid ~ .valid-tooltip {
                display: block
            }

        .form-check-input.is-valid ~ .form-check-label, .was-validated .form-check-input:valid ~ .form-check-label {
            color: #28a745
        }

        .form-check-input.is-valid ~ .valid-feedback, .form-check-input.is-valid ~ .valid-tooltip, .was-validated .form-check-input:valid ~ .valid-feedback, .was-validated .form-check-input:valid ~ .valid-tooltip {
            display: block
        }

        .custom-control-input.is-valid ~ .custom-control-label, .was-validated .custom-control-input:valid ~ .custom-control-label {
            color: #28a745
        }

            .custom-control-input.is-valid ~ .custom-control-label::before, .was-validated .custom-control-input:valid ~ .custom-control-label::before {
                background-color: #71dd8a
            }

        .custom-control-input.is-valid ~ .valid-feedback, .custom-control-input.is-valid ~ .valid-tooltip, .was-validated .custom-control-input:valid ~ .valid-feedback, .was-validated .custom-control-input:valid ~ .valid-tooltip {
            display: block
        }

        .custom-control-input.is-valid:checked ~ .custom-control-label::before, .was-validated .custom-control-input:valid:checked ~ .custom-control-label::before {
            background-color: #34ce57
        }

        .custom-control-input.is-valid:focus ~ .custom-control-label::before, .was-validated .custom-control-input:valid:focus ~ .custom-control-label::before {
            box-shadow: 0 0 0 1px #fff,0 0 0 .2rem rgba(40,167,69,.25)
        }

        .custom-file-input.is-valid ~ .custom-file-label, .was-validated .custom-file-input:valid ~ .custom-file-label {
            border-color: #28a745
        }

            .custom-file-input.is-valid ~ .custom-file-label::before, .was-validated .custom-file-input:valid ~ .custom-file-label::before {
                border-color: inherit
            }

        .custom-file-input.is-valid ~ .valid-feedback, .custom-file-input.is-valid ~ .valid-tooltip, .was-validated .custom-file-input:valid ~ .valid-feedback, .was-validated .custom-file-input:valid ~ .valid-tooltip {
            display: block
        }

        .custom-file-input.is-valid:focus ~ .custom-file-label, .was-validated .custom-file-input:valid:focus ~ .custom-file-label {
            box-shadow: 0 0 0 .2rem rgba(40,167,69,.25)
        }

        .invalid-feedback {
            display: none;
            width: 100%;
            margin-top: .25rem;
            font-size: 80%;
            color: #dc3545
        }

        .invalid-tooltip {
            position: absolute;
            top: 100%;
            z-index: 5;
            display: none;
            max-width: 100%;
            padding: .5rem;
            margin-top: .1rem;
            font-size: .875rem;
            line-height: 1;
            color: #fff;
            background-color: rgba(220,53,69,.8);
            border-radius: .2rem
        }

        .custom-select.is-invalid, .form-control.is-invalid, .was-validated .custom-select:invalid, .was-validated .form-control:invalid {
            border-color: #dc3545
        }

            .custom-select.is-invalid:focus, .form-control.is-invalid:focus, .was-validated .custom-select:invalid:focus, .was-validated .form-control:invalid:focus {
                border-color: #dc3545;
                box-shadow: 0 0 0 .2rem rgba(220,53,69,.25)
            }

            .custom-select.is-invalid ~ .invalid-feedback, .custom-select.is-invalid ~ .invalid-tooltip, .form-control.is-invalid ~ .invalid-feedback, .form-control.is-invalid ~ .invalid-tooltip, .was-validated .custom-select:invalid ~ .invalid-feedback, .was-validated .custom-select:invalid ~ .invalid-tooltip, .was-validated .form-control:invalid ~ .invalid-feedback, .was-validated .form-control:invalid ~ .invalid-tooltip {
                display: block
            }

        .form-check-input.is-invalid ~ .form-check-label, .was-validated .form-check-input:invalid ~ .form-check-label {
            color: #dc3545
        }

        .form-check-input.is-invalid ~ .invalid-feedback, .form-check-input.is-invalid ~ .invalid-tooltip, .was-validated .form-check-input:invalid ~ .invalid-feedback, .was-validated .form-check-input:invalid ~ .invalid-tooltip {
            display: block
        }

        .custom-control-input.is-invalid ~ .custom-control-label, .was-validated .custom-control-input:invalid ~ .custom-control-label {
            color: #dc3545
        }

            .custom-control-input.is-invalid ~ .custom-control-label::before, .was-validated .custom-control-input:invalid ~ .custom-control-label::before {
                background-color: #efa2a9
            }

        .custom-control-input.is-invalid ~ .invalid-feedback, .custom-control-input.is-invalid ~ .invalid-tooltip, .was-validated .custom-control-input:invalid ~ .invalid-feedback, .was-validated .custom-control-input:invalid ~ .invalid-tooltip {
            display: block
        }

        .custom-control-input.is-invalid:checked ~ .custom-control-label::before, .was-validated .custom-control-input:invalid:checked ~ .custom-control-label::before {
            background-color: #e4606d
        }

        .custom-control-input.is-invalid:focus ~ .custom-control-label::before, .was-validated .custom-control-input:invalid:focus ~ .custom-control-label::before {
            box-shadow: 0 0 0 1px #fff,0 0 0 .2rem rgba(220,53,69,.25)
        }

        .custom-file-input.is-invalid ~ .custom-file-label, .was-validated .custom-file-input:invalid ~ .custom-file-label {
            border-color: #dc3545
        }

            .custom-file-input.is-invalid ~ .custom-file-label::before, .was-validated .custom-file-input:invalid ~ .custom-file-label::before {
                border-color: inherit
            }

        .custom-file-input.is-invalid ~ .invalid-feedback, .custom-file-input.is-invalid ~ .invalid-tooltip, .was-validated .custom-file-input:invalid ~ .invalid-feedback, .was-validated .custom-file-input:invalid ~ .invalid-tooltip {
            display: block
        }

        .custom-file-input.is-invalid:focus ~ .custom-file-label, .was-validated .custom-file-input:invalid:focus ~ .custom-file-label {
            box-shadow: 0 0 0 .2rem rgba(220,53,69,.25)
        }

        .form-inline {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: horizontal;
            -webkit-box-direction: normal;
            -ms-flex-flow: row wrap;
            flex-flow: row wrap;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center
        }

            .form-inline .form-check {
                width: 100%
            }

        @media (min-width:576px) {
            .form-inline label {
                display: -webkit-box;
                display: -ms-flexbox;
                display: flex;
                -webkit-box-align: center;
                -ms-flex-align: center;
                align-items: center;
                -webkit-box-pack: center;
                -ms-flex-pack: center;
                justify-content: center;
                margin-bottom: 0
            }

            .form-inline .form-group {
                display: -webkit-box;
                display: -ms-flexbox;
                display: flex;
                -webkit-box-flex: 0;
                -ms-flex: 0 0 auto;
                flex: 0 0 auto;
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-flow: row wrap;
                flex-flow: row wrap;
                -webkit-box-align: center;
                -ms-flex-align: center;
                align-items: center;
                margin-bottom: 0
            }

            .form-inline .form-control {
                display: inline-block;
                width: auto;
                vertical-align: middle
            }

            .form-inline .form-control-plaintext {
                display: inline-block
            }

            .form-inline .input-group {
                width: auto
            }

            .form-inline .form-check {
                display: -webkit-box;
                display: -ms-flexbox;
                display: flex;
                -webkit-box-align: center;
                -ms-flex-align: center;
                align-items: center;
                -webkit-box-pack: center;
                -ms-flex-pack: center;
                justify-content: center;
                width: auto;
                padding-left: 0
            }

            .form-inline .form-check-input {
                position: relative;
                margin-top: 0;
                margin-right: .25rem;
                margin-left: 0
            }

            .form-inline .custom-control {
                -webkit-box-align: center;
                -ms-flex-align: center;
                align-items: center;
                -webkit-box-pack: center;
                -ms-flex-pack: center;
                justify-content: center
            }

            .form-inline .custom-control-label {
                margin-bottom: 0
            }
        }

        .btn {
            display: inline-block;
            font-weight: 400;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
            border: 1px solid transparent;
            padding: .375rem .75rem;
            font-size: 1rem;
            line-height: 1.5;
            border-radius: .25rem;
            transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out
        }

            .btn:focus, .btn:hover {
                text-decoration: none
            }

            .btn.focus, .btn:focus {
                outline: 0;
                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)
            }

            .btn.disabled, .btn:disabled {
                opacity: .65
            }

            .btn:not(:disabled):not(.disabled) {
                cursor: pointer
            }

                .btn:not(:disabled):not(.disabled).active, .btn:not(:disabled):not(.disabled):active {
                    background-image: none
                }

        a.btn.disabled, fieldset:disabled a.btn {
            pointer-events: none
        }

        .btn-primary {
            color: #fff;
            background-color: #007bff;
            border-color: #007bff
        }

            .btn-primary:hover {
                color: #fff;
                background-color: #0069d9;
                border-color: #0062cc
            }

            .btn-primary.focus, .btn-primary:focus {
                box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)
            }

            .btn-primary.disabled, .btn-primary:disabled {
                color: #fff;
                background-color: #007bff;
                border-color: #007bff
            }

            .btn-primary:not(:disabled):not(.disabled).active, .btn-primary:not(:disabled):not(.disabled):active, .show > .btn-primary.dropdown-toggle {
                color: #fff;
                background-color: #0062cc;
                border-color: #005cbf
            }

                .btn-primary:not(:disabled):not(.disabled).active:focus, .btn-primary:not(:disabled):not(.disabled):active:focus, .show > .btn-primary.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)
                }

        .btn-secondary {
            color: #fff;
            background-color: #6c757d;
            border-color: #6c757d
        }

            .btn-secondary:hover {
                color: #fff;
                background-color: #5a6268;
                border-color: #545b62
            }

            .btn-secondary.focus, .btn-secondary:focus {
                box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)
            }

            .btn-secondary.disabled, .btn-secondary:disabled {
                color: #fff;
                background-color: #6c757d;
                border-color: #6c757d
            }

            .btn-secondary:not(:disabled):not(.disabled).active, .btn-secondary:not(:disabled):not(.disabled):active, .show > .btn-secondary.dropdown-toggle {
                color: #fff;
                background-color: #545b62;
                border-color: #4e555b
            }

                .btn-secondary:not(:disabled):not(.disabled).active:focus, .btn-secondary:not(:disabled):not(.disabled):active:focus, .show > .btn-secondary.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)
                }

        .btn-success {
            color: #fff;
            background-color: #28a745;
            border-color: #28a745
        }

            .btn-success:hover {
                color: #fff;
                background-color: #218838;
                border-color: #1e7e34
            }

            .btn-success.focus, .btn-success:focus {
                box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)
            }

            .btn-success.disabled, .btn-success:disabled {
                color: #fff;
                background-color: #28a745;
                border-color: #28a745
            }

            .btn-success:not(:disabled):not(.disabled).active, .btn-success:not(:disabled):not(.disabled):active, .show > .btn-success.dropdown-toggle {
                color: #fff;
                background-color: #1e7e34;
                border-color: #1c7430
            }

                .btn-success:not(:disabled):not(.disabled).active:focus, .btn-success:not(:disabled):not(.disabled):active:focus, .show > .btn-success.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)
                }

        .btn-info {
            color: #fff;
            background-color: #17a2b8;
            border-color: #17a2b8
        }

            .btn-info:hover {
                color: #fff;
                background-color: #138496;
                border-color: #117a8b
            }

            .btn-info.focus, .btn-info:focus {
                box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)
            }

            .btn-info.disabled, .btn-info:disabled {
                color: #fff;
                background-color: #17a2b8;
                border-color: #17a2b8
            }

            .btn-info:not(:disabled):not(.disabled).active, .btn-info:not(:disabled):not(.disabled):active, .show > .btn-info.dropdown-toggle {
                color: #fff;
                background-color: #117a8b;
                border-color: #10707f
            }

                .btn-info:not(:disabled):not(.disabled).active:focus, .btn-info:not(:disabled):not(.disabled):active:focus, .show > .btn-info.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)
                }

        .btn-warning {
            color: #212529;
            background-color: #ffc107;
            border-color: #ffc107
        }

            .btn-warning:hover {
                color: #212529;
                background-color: #e0a800;
                border-color: #d39e00
            }

            .btn-warning.focus, .btn-warning:focus {
                box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)
            }

            .btn-warning.disabled, .btn-warning:disabled {
                color: #212529;
                background-color: #ffc107;
                border-color: #ffc107
            }

            .btn-warning:not(:disabled):not(.disabled).active, .btn-warning:not(:disabled):not(.disabled):active, .show > .btn-warning.dropdown-toggle {
                color: #212529;
                background-color: #d39e00;
                border-color: #c69500
            }

                .btn-warning:not(:disabled):not(.disabled).active:focus, .btn-warning:not(:disabled):not(.disabled):active:focus, .show > .btn-warning.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)
                }

        .btn-danger {
            color: #fff;
            background-color: #dc3545;
            border-color: #dc3545
        }

            .btn-danger:hover {
                color: #fff;
                background-color: #c82333;
                border-color: #bd2130
            }

            .btn-danger.focus, .btn-danger:focus {
                box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)
            }

            .btn-danger.disabled, .btn-danger:disabled {
                color: #fff;
                background-color: #dc3545;
                border-color: #dc3545
            }

            .btn-danger:not(:disabled):not(.disabled).active, .btn-danger:not(:disabled):not(.disabled):active, .show > .btn-danger.dropdown-toggle {
                color: #fff;
                background-color: #bd2130;
                border-color: #b21f2d
            }

                .btn-danger:not(:disabled):not(.disabled).active:focus, .btn-danger:not(:disabled):not(.disabled):active:focus, .show > .btn-danger.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)
                }

        .btn-light {
            color: #212529;
            background-color: #f8f9fa;
            border-color: #f8f9fa
        }

            .btn-light:hover {
                color: #212529;
                background-color: #e2e6ea;
                border-color: #dae0e5
            }

            .btn-light.focus, .btn-light:focus {
                box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)
            }

            .btn-light.disabled, .btn-light:disabled {
                color: #212529;
                background-color: #f8f9fa;
                border-color: #f8f9fa
            }

            .btn-light:not(:disabled):not(.disabled).active, .btn-light:not(:disabled):not(.disabled):active, .show > .btn-light.dropdown-toggle {
                color: #212529;
                background-color: #dae0e5;
                border-color: #d3d9df
            }

                .btn-light:not(:disabled):not(.disabled).active:focus, .btn-light:not(:disabled):not(.disabled):active:focus, .show > .btn-light.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)
                }

        .btn-dark {
            color: #fff;
            background-color: #343a40;
            border-color: #343a40
        }

            .btn-dark:hover {
                color: #fff;
                background-color: #23272b;
                border-color: #1d2124
            }

            .btn-dark.focus, .btn-dark:focus {
                box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)
            }

            .btn-dark.disabled, .btn-dark:disabled {
                color: #fff;
                background-color: #343a40;
                border-color: #343a40
            }

            .btn-dark:not(:disabled):not(.disabled).active, .btn-dark:not(:disabled):not(.disabled):active, .show > .btn-dark.dropdown-toggle {
                color: #fff;
                background-color: #1d2124;
                border-color: #171a1d
            }

                .btn-dark:not(:disabled):not(.disabled).active:focus, .btn-dark:not(:disabled):not(.disabled):active:focus, .show > .btn-dark.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)
                }

        .btn-outline-primary {
            color: #007bff;
            background-color: transparent;
            background-image: none;
            border-color: #007bff
        }

            .btn-outline-primary:hover {
                color: #fff;
                background-color: #007bff;
                border-color: #007bff
            }

            .btn-outline-primary.focus, .btn-outline-primary:focus {
                box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)
            }

            .btn-outline-primary.disabled, .btn-outline-primary:disabled {
                color: #007bff;
                background-color: transparent
            }

            .btn-outline-primary:not(:disabled):not(.disabled).active, .btn-outline-primary:not(:disabled):not(.disabled):active, .show > .btn-outline-primary.dropdown-toggle {
                color: #fff;
                background-color: #007bff;
                border-color: #007bff
            }

                .btn-outline-primary:not(:disabled):not(.disabled).active:focus, .btn-outline-primary:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-primary.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)
                }

        .btn-outline-secondary {
            color: #6c757d;
            background-color: transparent;
            background-image: none;
            border-color: #6c757d
        }

            .btn-outline-secondary:hover {
                color: #fff;
                background-color: #6c757d;
                border-color: #6c757d
            }

            .btn-outline-secondary.focus, .btn-outline-secondary:focus {
                box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)
            }

            .btn-outline-secondary.disabled, .btn-outline-secondary:disabled {
                color: #6c757d;
                background-color: transparent
            }

            .btn-outline-secondary:not(:disabled):not(.disabled).active, .btn-outline-secondary:not(:disabled):not(.disabled):active, .show > .btn-outline-secondary.dropdown-toggle {
                color: #fff;
                background-color: #6c757d;
                border-color: #6c757d
            }

                .btn-outline-secondary:not(:disabled):not(.disabled).active:focus, .btn-outline-secondary:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-secondary.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)
                }

        .btn-outline-success {
            color: #28a745;
            background-color: transparent;
            background-image: none;
            border-color: #28a745
        }

            .btn-outline-success:hover {
                color: #fff;
                background-color: #28a745;
                border-color: #28a745
            }

            .btn-outline-success.focus, .btn-outline-success:focus {
                box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)
            }

            .btn-outline-success.disabled, .btn-outline-success:disabled {
                color: #28a745;
                background-color: transparent
            }

            .btn-outline-success:not(:disabled):not(.disabled).active, .btn-outline-success:not(:disabled):not(.disabled):active, .show > .btn-outline-success.dropdown-toggle {
                color: #fff;
                background-color: #28a745;
                border-color: #28a745
            }

                .btn-outline-success:not(:disabled):not(.disabled).active:focus, .btn-outline-success:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-success.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)
                }

        .btn-outline-info {
            color: #17a2b8;
            background-color: transparent;
            background-image: none;
            border-color: #17a2b8
        }

            .btn-outline-info:hover {
                color: #fff;
                background-color: #17a2b8;
                border-color: #17a2b8
            }

            .btn-outline-info.focus, .btn-outline-info:focus {
                box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)
            }

            .btn-outline-info.disabled, .btn-outline-info:disabled {
                color: #17a2b8;
                background-color: transparent
            }

            .btn-outline-info:not(:disabled):not(.disabled).active, .btn-outline-info:not(:disabled):not(.disabled):active, .show > .btn-outline-info.dropdown-toggle {
                color: #fff;
                background-color: #17a2b8;
                border-color: #17a2b8
            }

                .btn-outline-info:not(:disabled):not(.disabled).active:focus, .btn-outline-info:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-info.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)
                }

        .btn-outline-warning {
            color: #ffc107;
            background-color: transparent;
            background-image: none;
            border-color: #ffc107
        }

            .btn-outline-warning:hover {
                color: #212529;
                background-color: #ffc107;
                border-color: #ffc107
            }

            .btn-outline-warning.focus, .btn-outline-warning:focus {
                box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)
            }

            .btn-outline-warning.disabled, .btn-outline-warning:disabled {
                color: #ffc107;
                background-color: transparent
            }

            .btn-outline-warning:not(:disabled):not(.disabled).active, .btn-outline-warning:not(:disabled):not(.disabled):active, .show > .btn-outline-warning.dropdown-toggle {
                color: #212529;
                background-color: #ffc107;
                border-color: #ffc107
            }

                .btn-outline-warning:not(:disabled):not(.disabled).active:focus, .btn-outline-warning:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-warning.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)
                }

        .btn-outline-danger {
            color: #dc3545;
            background-color: transparent;
            background-image: none;
            border-color: #dc3545
        }

            .btn-outline-danger:hover {
                color: #fff;
                background-color: #dc3545;
                border-color: #dc3545
            }

            .btn-outline-danger.focus, .btn-outline-danger:focus {
                box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)
            }

            .btn-outline-danger.disabled, .btn-outline-danger:disabled {
                color: #dc3545;
                background-color: transparent
            }

            .btn-outline-danger:not(:disabled):not(.disabled).active, .btn-outline-danger:not(:disabled):not(.disabled):active, .show > .btn-outline-danger.dropdown-toggle {
                color: #fff;
                background-color: #dc3545;
                border-color: #dc3545
            }

                .btn-outline-danger:not(:disabled):not(.disabled).active:focus, .btn-outline-danger:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-danger.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)
                }

        .btn-outline-light {
            color: #f8f9fa;
            background-color: transparent;
            background-image: none;
            border-color: #f8f9fa
        }

            .btn-outline-light:hover {
                color: #212529;
                background-color: #f8f9fa;
                border-color: #f8f9fa
            }

            .btn-outline-light.focus, .btn-outline-light:focus {
                box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)
            }

            .btn-outline-light.disabled, .btn-outline-light:disabled {
                color: #f8f9fa;
                background-color: transparent
            }

            .btn-outline-light:not(:disabled):not(.disabled).active, .btn-outline-light:not(:disabled):not(.disabled):active, .show > .btn-outline-light.dropdown-toggle {
                color: #212529;
                background-color: #f8f9fa;
                border-color: #f8f9fa
            }

                .btn-outline-light:not(:disabled):not(.disabled).active:focus, .btn-outline-light:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-light.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)
                }

        .btn-outline-dark {
            color: #343a40;
            background-color: transparent;
            background-image: none;
            border-color: #343a40
        }

            .btn-outline-dark:hover {
                color: #fff;
                background-color: #343a40;
                border-color: #343a40
            }

            .btn-outline-dark.focus, .btn-outline-dark:focus {
                box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)
            }

            .btn-outline-dark.disabled, .btn-outline-dark:disabled {
                color: #343a40;
                background-color: transparent
            }

            .btn-outline-dark:not(:disabled):not(.disabled).active, .btn-outline-dark:not(:disabled):not(.disabled):active, .show > .btn-outline-dark.dropdown-toggle {
                color: #fff;
                background-color: #343a40;
                border-color: #343a40
            }

                .btn-outline-dark:not(:disabled):not(.disabled).active:focus, .btn-outline-dark:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-dark.dropdown-toggle:focus {
                    box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)
                }

        .btn-link {
            font-weight: 400;
            color: #007bff;
            background-color: transparent
        }

            .btn-link:hover {
                color: #0056b3;
                text-decoration: underline;
                background-color: transparent;
                border-color: transparent
            }

            .btn-link.focus, .btn-link:focus {
                text-decoration: underline;
                border-color: transparent;
                box-shadow: none
            }

            .btn-link.disabled, .btn-link:disabled {
                color: #6c757d
            }

        .btn-group-lg > .btn, .btn-lg {
            padding: .5rem 1rem;
            font-size: 1.25rem;
            line-height: 1.5;
            border-radius: .3rem
        }

        .btn-group-sm > .btn, .btn-sm {
            padding: .25rem .5rem;
            font-size: .875rem;
            line-height: 1.5;
            border-radius: .2rem
        }

        .btn-block {
            display: block;
            width: 100%
        }

            .btn-block + .btn-block {
                margin-top: .5rem
            }

        input[type=button].btn-block, input[type=reset].btn-block, input[type=submit].btn-block {
            width: 100%
        }

        .fade {
            opacity: 0;
            transition: opacity .15s linear
        }

            .fade.show {
                opacity: 1
            }

        .collapse {
            display: none
        }

            .collapse.show {
                display: block
            }

        tr.collapse.show {
            display: table-row
        }

        tbody.collapse.show {
            display: table-row-group
        }

        .collapsing {
            position: relative;
            height: 0;
            overflow: hidden;
            transition: height .35s ease
        }

        .dropdown, .dropup {
            position: relative
        }

        .dropdown-toggle::after {
            display: inline-block;
            width: 0;
            height: 0;
            margin-left: .255em;
            vertical-align: .255em;
            content: \""\"";
            border-top: .3em solid;
            border-right: .3em solid transparent;
            border-bottom: 0;
            border-left: .3em solid transparent
        }

        .dropdown-toggle:empty::after {
            margin-left: 0
        }

        .dropdown-menu {
            position: absolute;
            top: 100%;
            left: 0;
            z-index: 1000;
            display: none;
            float: left;
            min-width: 10rem;
            padding: .5rem 0;
            margin: .125rem 0 0;
            font-size: 1rem;
            color: #212529;
            text-align: left;
            list-style: none;
            background-color: #fff;
            background-clip: padding-box;
            border: 1px solid rgba(0,0,0,.15);
            border-radius: .25rem
        }

        .dropup .dropdown-menu {
            margin-top: 0;
            margin-bottom: .125rem
        }

        .dropup .dropdown-toggle::after {
            display: inline-block;
            width: 0;
            height: 0;
            margin-left: .255em;
            vertical-align: .255em;
            content: \""\"";
            border-top: 0;
            border-right: .3em solid transparent;
            border-bottom: .3em solid;
            border-left: .3em solid transparent
        }

        .dropup .dropdown-toggle:empty::after {
            margin-left: 0
        }

        .dropright .dropdown-menu {
            margin-top: 0;
            margin-left: .125rem
        }

        .dropright .dropdown-toggle::after {
            display: inline-block;
            width: 0;
            height: 0;
            margin-left: .255em;
            vertical-align: .255em;
            content: \""\"";
            border-top: .3em solid transparent;
            border-bottom: .3em solid transparent;
            border-left: .3em solid
        }

        .dropright .dropdown-toggle:empty::after {
            margin-left: 0
        }

        .dropright .dropdown-toggle::after {
            vertical-align: 0
        }

        .dropleft .dropdown-menu {
            margin-top: 0;
            margin-right: .125rem
        }

        .dropleft .dropdown-toggle::after {
            display: inline-block;
            width: 0;
            height: 0;
            margin-left: .255em;
            vertical-align: .255em;
            content: \""\""
        }

        .dropleft .dropdown-toggle::after {
            display: none
        }

        .dropleft .dropdown-toggle::before {
            display: inline-block;
            width: 0;
            height: 0;
            margin-right: .255em;
            vertical-align: .255em;
            content: \""\"";
            border-top: .3em solid transparent;
            border-right: .3em solid;
            border-bottom: .3em solid transparent
        }

        .dropleft .dropdown-toggle:empty::after {
            margin-left: 0
        }

        .dropleft .dropdown-toggle::before {
            vertical-align: 0
        }

        .dropdown-divider {
            height: 0;
            margin: .5rem 0;
            overflow: hidden;
            border-top: 1px solid #e9ecef
        }

        .dropdown-item {
            display: block;
            width: 100%;
            padding: .25rem 1.5rem;
            clear: both;
            font-weight: 400;
            color: #212529;
            text-align: inherit;
            white-space: nowrap;
            background-color: transparent;
            border: 0
        }

            .dropdown-item:focus, .dropdown-item:hover {
                color: #16181b;
                text-decoration: none;
                background-color: #f8f9fa
            }

            .dropdown-item.active, .dropdown-item:active {
                color: #fff;
                text-decoration: none;
                background-color: #007bff
            }

            .dropdown-item.disabled, .dropdown-item:disabled {
                color: #6c757d;
                background-color: transparent
            }

        .dropdown-menu.show {
            display: block
        }

        .dropdown-header {
            display: block;
            padding: .5rem 1.5rem;
            margin-bottom: 0;
            font-size: .875rem;
            color: #6c757d;
            white-space: nowrap
        }

        .btn-group, .btn-group-vertical {
            position: relative;
            display: -webkit-inline-box;
            display: -ms-inline-flexbox;
            display: inline-flex;
            vertical-align: middle
        }

            .btn-group-vertical > .btn, .btn-group > .btn {
                position: relative;
                -webkit-box-flex: 0;
                -ms-flex: 0 1 auto;
                flex: 0 1 auto
            }

                .btn-group-vertical > .btn:hover, .btn-group > .btn:hover {
                    z-index: 1
                }

                .btn-group-vertical > .btn.active, .btn-group-vertical > .btn:active, .btn-group-vertical > .btn:focus, .btn-group > .btn.active, .btn-group > .btn:active, .btn-group > .btn:focus {
                    z-index: 1
                }

            .btn-group .btn + .btn, .btn-group .btn + .btn-group, .btn-group .btn-group + .btn, .btn-group .btn-group + .btn-group, .btn-group-vertical .btn + .btn, .btn-group-vertical .btn + .btn-group, .btn-group-vertical .btn-group + .btn, .btn-group-vertical .btn-group + .btn-group {
                margin-left: -1px
            }

        .btn-toolbar {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            -webkit-box-pack: start;
            -ms-flex-pack: start;
            justify-content: flex-start
        }

            .btn-toolbar .input-group {
                width: auto
            }

        .btn-group > .btn:first-child {
            margin-left: 0
        }

        .btn-group > .btn-group:not(:last-child) > .btn, .btn-group > .btn:not(:last-child):not(.dropdown-toggle) {
            border-top-right-radius: 0;
            border-bottom-right-radius: 0
        }

        .btn-group > .btn-group:not(:first-child) > .btn, .btn-group > .btn:not(:first-child) {
            border-top-left-radius: 0;
            border-bottom-left-radius: 0
        }

        .dropdown-toggle-split {
            padding-right: .5625rem;
            padding-left: .5625rem
        }

            .dropdown-toggle-split::after {
                margin-left: 0
            }

        .btn-group-sm > .btn + .dropdown-toggle-split, .btn-sm + .dropdown-toggle-split {
            padding-right: .375rem;
            padding-left: .375rem
        }

        .btn-group-lg > .btn + .dropdown-toggle-split, .btn-lg + .dropdown-toggle-split {
            padding-right: .75rem;
            padding-left: .75rem
        }

        .btn-group-vertical {
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column;
            -webkit-box-align: start;
            -ms-flex-align: start;
            align-items: flex-start;
            -webkit-box-pack: center;
            -ms-flex-pack: center;
            justify-content: center
        }

            .btn-group-vertical .btn, .btn-group-vertical .btn-group {
                width: 100%
            }

            .btn-group-vertical > .btn + .btn, .btn-group-vertical > .btn + .btn-group, .btn-group-vertical > .btn-group + .btn, .btn-group-vertical > .btn-group + .btn-group {
                margin-top: -1px;
                margin-left: 0
            }

            .btn-group-vertical > .btn-group:not(:last-child) > .btn, .btn-group-vertical > .btn:not(:last-child):not(.dropdown-toggle) {
                border-bottom-right-radius: 0;
                border-bottom-left-radius: 0
            }

            .btn-group-vertical > .btn-group:not(:first-child) > .btn, .btn-group-vertical > .btn:not(:first-child) {
                border-top-left-radius: 0;
                border-top-right-radius: 0
            }

        .btn-group-toggle > .btn, .btn-group-toggle > .btn-group > .btn {
            margin-bottom: 0
        }

            .btn-group-toggle > .btn input[type=checkbox], .btn-group-toggle > .btn input[type=radio], .btn-group-toggle > .btn-group > .btn input[type=checkbox], .btn-group-toggle > .btn-group > .btn input[type=radio] {
                position: absolute;
                clip: rect(0,0,0,0);
                pointer-events: none
            }

        .input-group {
            position: relative;
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            -webkit-box-align: stretch;
            -ms-flex-align: stretch;
            align-items: stretch;
            width: 100%
        }

            .input-group > .custom-file, .input-group > .custom-select, .input-group > .form-control {
                position: relative;
                -webkit-box-flex: 1;
                -ms-flex: 1 1 auto;
                flex: 1 1 auto;
                width: 1%;
                margin-bottom: 0
            }

                .input-group > .custom-file:focus, .input-group > .custom-select:focus, .input-group > .form-control:focus {
                    z-index: 3
                }

                .input-group > .custom-file + .custom-file, .input-group > .custom-file + .custom-select, .input-group > .custom-file + .form-control, .input-group > .custom-select + .custom-file, .input-group > .custom-select + .custom-select, .input-group > .custom-select + .form-control, .input-group > .form-control + .custom-file, .input-group > .form-control + .custom-select, .input-group > .form-control + .form-control {
                    margin-left: -1px
                }

                .input-group > .custom-select:not(:last-child), .input-group > .form-control:not(:last-child) {
                    border-top-right-radius: 0;
                    border-bottom-right-radius: 0
                }

                .input-group > .custom-select:not(:first-child), .input-group > .form-control:not(:first-child) {
                    border-top-left-radius: 0;
                    border-bottom-left-radius: 0
                }

            .input-group > .custom-file {
                display: -webkit-box;
                display: -ms-flexbox;
                display: flex;
                -webkit-box-align: center;
                -ms-flex-align: center;
                align-items: center
            }

                .input-group > .custom-file:not(:last-child) .custom-file-label, .input-group > .custom-file:not(:last-child) .custom-file-label::before {
                    border-top-right-radius: 0;
                    border-bottom-right-radius: 0
                }

                .input-group > .custom-file:not(:first-child) .custom-file-label, .input-group > .custom-file:not(:first-child) .custom-file-label::before {
                    border-top-left-radius: 0;
                    border-bottom-left-radius: 0
                }

        .input-group-append, .input-group-prepend {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex
        }

            .input-group-append .btn, .input-group-prepend .btn {
                position: relative;
                z-index: 2
            }

                .input-group-append .btn + .btn, .input-group-append .btn + .input-group-text, .input-group-append .input-group-text + .btn, .input-group-append .input-group-text + .input-group-text, .input-group-prepend .btn + .btn, .input-group-prepend .btn + .input-group-text, .input-group-prepend .input-group-text + .btn, .input-group-prepend .input-group-text + .input-group-text {
                    margin-left: -1px
                }

        .input-group-prepend {
            margin-right: -1px
        }

        .input-group-append {
            margin-left: -1px
        }

        .input-group-text {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center;
            padding: .375rem .75rem;
            margin-bottom: 0;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            text-align: center;
            white-space: nowrap;
            background-color: #e9ecef;
            border: 1px solid #ced4da;
            border-radius: .25rem
        }

            .input-group-text input[type=checkbox], .input-group-text input[type=radio] {
                margin-top: 0
            }

        .input-group > .input-group-append:last-child > .btn:not(:last-child):not(.dropdown-toggle), .input-group > .input-group-append:last-child > .input-group-text:not(:last-child), .input-group > .input-group-append:not(:last-child) > .btn, .input-group > .input-group-append:not(:last-child) > .input-group-text, .input-group > .input-group-prepend > .btn, .input-group > .input-group-prepend > .input-group-text {
            border-top-right-radius: 0;
            border-bottom-right-radius: 0
        }

        .input-group > .input-group-append > .btn, .input-group > .input-group-append > .input-group-text, .input-group > .input-group-prepend:first-child > .btn:not(:first-child), .input-group > .input-group-prepend:first-child > .input-group-text:not(:first-child), .input-group > .input-group-prepend:not(:first-child) > .btn, .input-group > .input-group-prepend:not(:first-child) > .input-group-text {
            border-top-left-radius: 0;
            border-bottom-left-radius: 0
        }

        .custom-control {
            position: relative;
            display: block;
            min-height: 1.5rem;
            padding-left: 1.5rem
        }

        .custom-control-inline {
            display: -webkit-inline-box;
            display: -ms-inline-flexbox;
            display: inline-flex;
            margin-right: 1rem
        }

        .custom-control-input {
            position: absolute;
            z-index: -1;
            opacity: 0
        }

            .custom-control-input:checked ~ .custom-control-label::before {
                color: #fff;
                background-color: #007bff
            }

            .custom-control-input:focus ~ .custom-control-label::before {
                box-shadow: 0 0 0 1px #fff,0 0 0 .2rem rgba(0,123,255,.25)
            }

            .custom-control-input:active ~ .custom-control-label::before {
                color: #fff;
                background-color: #b3d7ff
            }

            .custom-control-input:disabled ~ .custom-control-label {
                color: #6c757d
            }

                .custom-control-input:disabled ~ .custom-control-label::before {
                    background-color: #e9ecef
                }

        .custom-control-label {
            margin-bottom: 0
        }

            .custom-control-label::before {
                position: absolute;
                top: .25rem;
                left: 0;
                display: block;
                width: 1rem;
                height: 1rem;
                pointer-events: none;
                content: \""\"";
                -webkit-user-select: none;
                -moz-user-select: none;
                -ms-user-select: none;
                user-select: none;
                background-color: #dee2e6
            }

            .custom-control-label::after {
                position: absolute;
                top: .25rem;
                left: 0;
                display: block;
                width: 1rem;
                height: 1rem;
                content: \""\"";
                background-repeat: no-repeat;
                background-position: center center;
                background-size: 50% 50%
            }

        .custom-checkbox .custom-control-label::before {
            border-radius: .25rem
        }

        .custom-checkbox .custom-control-input:checked ~ .custom-control-label::before {
            background-color: #007bff
        }

        .custom-checkbox .custom-control-input:checked ~ .custom-control-label::after {
            background-image: url(\""data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 8 8'%3E%3Cpath fill='%23fff' d='M6.564.75l-3.59 3.612-1.538-1.55L0 4.26 2.974 7.25 8 2.193z'/%3E%3C/svg%3E\"")
        }

        .custom-checkbox .custom-control-input:indeterminate ~ .custom-control-label::before {
            background-color: #007bff
        }

        .custom-checkbox .custom-control-input:indeterminate ~ .custom-control-label::after {
            background-image: url(\""data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 4 4'%3E%3Cpath stroke='%23fff' d='M0 2h4'/%3E%3C/svg%3E\"")
        }

        .custom-checkbox .custom-control-input:disabled:checked ~ .custom-control-label::before {
            background-color: rgba(0,123,255,.5)
        }

        .custom-checkbox .custom-control-input:disabled:indeterminate ~ .custom-control-label::before {
            background-color: rgba(0,123,255,.5)
        }

        .custom-radio .custom-control-label::before {
            border-radius: 50%
        }

        .custom-radio .custom-control-input:checked ~ .custom-control-label::before {
            background-color: #007bff
        }

        .custom-radio .custom-control-input:checked ~ .custom-control-label::after {
            background-image: url(\""data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='-4 -4 8 8'%3E%3Ccircle r='3' fill='%23fff'/%3E%3C/svg%3E\"")
        }

        .custom-radio .custom-control-input:disabled:checked ~ .custom-control-label::before {
            background-color: rgba(0,123,255,.5)
        }

        .custom-select {
            display: inline-block;
            width: 100%;
            height: calc(2.25rem + 2px);
            padding: .375rem 1.75rem .375rem .75rem;
            line-height: 1.5;
            color: #495057;
            vertical-align: middle;
            background: #fff url(\""data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 4 5'%3E%3Cpath fill='%23343a40' d='M2 0L0 2h4zm0 5L0 3h4z'/%3E%3C/svg%3E\"") no-repeat right .75rem center;
            background-size: 8px 10px;
            border: 1px solid #ced4da;
            border-radius: .25rem;
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none
        }

            .custom-select:focus {
                border-color: #80bdff;
                outline: 0;
                box-shadow: inset 0 1px 2px rgba(0,0,0,.075),0 0 5px rgba(128,189,255,.5)
            }

                .custom-select:focus::-ms-value {
                    color: #495057;
                    background-color: #fff
                }

            .custom-select[multiple], .custom-select[size]:not([size=\""1\""]) {
                height: auto;
                padding-right: .75rem;
                background-image: none
            }

            .custom-select:disabled {
                color: #6c757d;
                background-color: #e9ecef
            }

            .custom-select::-ms-expand {
                opacity: 0
            }

        .custom-select-sm {
            height: calc(1.8125rem + 2px);
            padding-top: .375rem;
            padding-bottom: .375rem;
            font-size: 75%
        }

        .custom-select-lg {
            height: calc(2.875rem + 2px);
            padding-top: .375rem;
            padding-bottom: .375rem;
            font-size: 125%
        }

        .custom-file {
            position: relative;
            display: inline-block;
            width: 100%;
            height: calc(2.25rem + 2px);
            margin-bottom: 0
        }

        .custom-file-input {
            position: relative;
            z-index: 2;
            width: 100%;
            height: calc(2.25rem + 2px);
            margin: 0;
            opacity: 0
        }

            .custom-file-input:focus ~ .custom-file-control {
                border-color: #80bdff;
                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)
            }

                .custom-file-input:focus ~ .custom-file-control::before {
                    border-color: #80bdff
                }

            .custom-file-input:lang(en) ~ .custom-file-label::after {
                content: \""Browse\""
            }

        .custom-file-label {
            position: absolute;
            top: 0;
            right: 0;
            left: 0;
            z-index: 1;
            height: calc(2.25rem + 2px);
            padding: .375rem .75rem;
            line-height: 1.5;
            color: #495057;
            background-color: #fff;
            border: 1px solid #ced4da;
            border-radius: .25rem
        }

            .custom-file-label::after {
                position: absolute;
                top: 0;
                right: 0;
                bottom: 0;
                z-index: 3;
                display: block;
                height: calc(calc(2.25rem + 2px) - 1px * 2);
                padding: .375rem .75rem;
                line-height: 1.5;
                color: #495057;
                content: \""Browse\"";
                background-color: #e9ecef;
                border-left: 1px solid #ced4da;
                border-radius: 0 .25rem .25rem 0
            }

        .nav {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            padding-left: 0;
            margin-bottom: 0;
            list-style: none
        }

        .nav-link {
            display: block;
            padding: .5rem 1rem
        }

            .nav-link:focus, .nav-link:hover {
                text-decoration: none
            }

            .nav-link.disabled {
                color: #6c757d
            }

        .nav-tabs {
            border-bottom: 1px solid #dee2e6
        }

            .nav-tabs .nav-item {
                margin-bottom: -1px
            }

            .nav-tabs .nav-link {
                border: 1px solid transparent;
                border-top-left-radius: .25rem;
                border-top-right-radius: .25rem
            }

                .nav-tabs .nav-link:focus, .nav-tabs .nav-link:hover {
                    border-color: #e9ecef #e9ecef #dee2e6
                }

                .nav-tabs .nav-link.disabled {
                    color: #6c757d;
                    background-color: transparent;
                    border-color: transparent
                }

                .nav-tabs .nav-item.show .nav-link, .nav-tabs .nav-link.active {
                    color: #495057;
                    background-color: #fff;
                    border-color: #dee2e6 #dee2e6 #fff
                }

            .nav-tabs .dropdown-menu {
                margin-top: -1px;
                border-top-left-radius: 0;
                border-top-right-radius: 0
            }

        .nav-pills .nav-link {
            border-radius: .25rem
        }

            .nav-pills .nav-link.active, .nav-pills .show > .nav-link {
                color: #fff;
                background-color: #007bff
            }

        .nav-fill .nav-item {
            -webkit-box-flex: 1;
            -ms-flex: 1 1 auto;
            flex: 1 1 auto;
            text-align: center
        }

        .nav-justified .nav-item {
            -ms-flex-preferred-size: 0;
            flex-basis: 0;
            -webkit-box-flex: 1;
            -ms-flex-positive: 1;
            flex-grow: 1;
            text-align: center
        }

        .tab-content > .tab-pane {
            display: none
        }

        .tab-content > .active {
            display: block
        }

        .navbar {
            position: relative;
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center;
            -webkit-box-pack: justify;
            -ms-flex-pack: justify;
            justify-content: space-between;
            padding: .5rem 1rem
        }

            .navbar > .container, .navbar > .container-fluid {
                display: -webkit-box;
                display: -ms-flexbox;
                display: flex;
                -ms-flex-wrap: wrap;
                flex-wrap: wrap;
                -webkit-box-align: center;
                -ms-flex-align: center;
                align-items: center;
                -webkit-box-pack: justify;
                -ms-flex-pack: justify;
                justify-content: space-between
            }

        .navbar-brand {
            display: inline-block;
            padding-top: .3125rem;
            padding-bottom: .3125rem;
            margin-right: 1rem;
            font-size: 1.25rem;
            line-height: inherit;
            white-space: nowrap
        }

            .navbar-brand:focus, .navbar-brand:hover {
                text-decoration: none
            }

        .navbar-nav {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column;
            padding-left: 0;
            margin-bottom: 0;
            list-style: none
        }

            .navbar-nav .nav-link {
                padding-right: 0;
                padding-left: 0
            }

            .navbar-nav .dropdown-menu {
                position: static;
                float: none
            }

        .navbar-text {
            display: inline-block;
            padding-top: .5rem;
            padding-bottom: .5rem
        }

        .navbar-collapse {
            -ms-flex-preferred-size: 100%;
            flex-basis: 100%;
            -webkit-box-flex: 1;
            -ms-flex-positive: 1;
            flex-grow: 1;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center
        }

        .navbar-toggler {
            padding: .25rem .75rem;
            font-size: 1.25rem;
            line-height: 1;
            background-color: transparent;
            border: 1px solid transparent;
            border-radius: .25rem
        }

            .navbar-toggler:focus, .navbar-toggler:hover {
                text-decoration: none
            }

            .navbar-toggler:not(:disabled):not(.disabled) {
                cursor: pointer
            }

        .navbar-toggler-icon {
            display: inline-block;
            width: 1.5em;
            height: 1.5em;
            vertical-align: middle;
            content: \""\"";
            background: no-repeat center center;
            background-size: 100% 100%
        }

        @media (max-width:575.98px) {
            .navbar-expand-sm > .container, .navbar-expand-sm > .container-fluid {
                padding-right: 0;
                padding-left: 0
            }
        }

        @media (min-width:576px) {
            .navbar-expand-sm {
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-flow: row nowrap;
                flex-flow: row nowrap;
                -webkit-box-pack: start;
                -ms-flex-pack: start;
                justify-content: flex-start
            }

                .navbar-expand-sm .navbar-nav {
                    -webkit-box-orient: horizontal;
                    -webkit-box-direction: normal;
                    -ms-flex-direction: row;
                    flex-direction: row
                }

                    .navbar-expand-sm .navbar-nav .dropdown-menu {
                        position: absolute
                    }

                    .navbar-expand-sm .navbar-nav .dropdown-menu-right {
                        right: 0;
                        left: auto
                    }

                    .navbar-expand-sm .navbar-nav .nav-link {
                        padding-right: .5rem;
                        padding-left: .5rem
                    }

                .navbar-expand-sm > .container, .navbar-expand-sm > .container-fluid {
                    -ms-flex-wrap: nowrap;
                    flex-wrap: nowrap
                }

                .navbar-expand-sm .navbar-collapse {
                    display: -webkit-box !important;
                    display: -ms-flexbox !important;
                    display: flex !important;
                    -ms-flex-preferred-size: auto;
                    flex-basis: auto
                }

                .navbar-expand-sm .navbar-toggler {
                    display: none
                }

                .navbar-expand-sm .dropup .dropdown-menu {
                    top: auto;
                    bottom: 100%
                }
        }

        @media (max-width:767.98px) {
            .navbar-expand-md > .container, .navbar-expand-md > .container-fluid {
                padding-right: 0;
                padding-left: 0
            }
        }

        @media (min-width:768px) {
            .navbar-expand-md {
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-flow: row nowrap;
                flex-flow: row nowrap;
                -webkit-box-pack: start;
                -ms-flex-pack: start;
                justify-content: flex-start
            }

                .navbar-expand-md .navbar-nav {
                    -webkit-box-orient: horizontal;
                    -webkit-box-direction: normal;
                    -ms-flex-direction: row;
                    flex-direction: row
                }

                    .navbar-expand-md .navbar-nav .dropdown-menu {
                        position: absolute
                    }

                    .navbar-expand-md .navbar-nav .dropdown-menu-right {
                        right: 0;
                        left: auto
                    }

                    .navbar-expand-md .navbar-nav .nav-link {
                        padding-right: .5rem;
                        padding-left: .5rem
                    }

                .navbar-expand-md > .container, .navbar-expand-md > .container-fluid {
                    -ms-flex-wrap: nowrap;
                    flex-wrap: nowrap
                }

                .navbar-expand-md .navbar-collapse {
                    display: -webkit-box !important;
                    display: -ms-flexbox !important;
                    display: flex !important;
                    -ms-flex-preferred-size: auto;
                    flex-basis: auto
                }

                .navbar-expand-md .navbar-toggler {
                    display: none
                }

                .navbar-expand-md .dropup .dropdown-menu {
                    top: auto;
                    bottom: 100%
                }
        }

        @media (max-width:991.98px) {
            .navbar-expand-lg > .container, .navbar-expand-lg > .container-fluid {
                padding-right: 0;
                padding-left: 0
            }
        }

        @media (min-width:992px) {
            .navbar-expand-lg {
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-flow: row nowrap;
                flex-flow: row nowrap;
                -webkit-box-pack: start;
                -ms-flex-pack: start;
                justify-content: flex-start
            }

                .navbar-expand-lg .navbar-nav {
                    -webkit-box-orient: horizontal;
                    -webkit-box-direction: normal;
                    -ms-flex-direction: row;
                    flex-direction: row
                }

                    .navbar-expand-lg .navbar-nav .dropdown-menu {
                        position: absolute
                    }

                    .navbar-expand-lg .navbar-nav .dropdown-menu-right {
                        right: 0;
                        left: auto
                    }

                    .navbar-expand-lg .navbar-nav .nav-link {
                        padding-right: .5rem;
                        padding-left: .5rem
                    }

                .navbar-expand-lg > .container, .navbar-expand-lg > .container-fluid {
                    -ms-flex-wrap: nowrap;
                    flex-wrap: nowrap
                }

                .navbar-expand-lg .navbar-collapse {
                    display: -webkit-box !important;
                    display: -ms-flexbox !important;
                    display: flex !important;
                    -ms-flex-preferred-size: auto;
                    flex-basis: auto
                }

                .navbar-expand-lg .navbar-toggler {
                    display: none
                }

                .navbar-expand-lg .dropup .dropdown-menu {
                    top: auto;
                    bottom: 100%
                }
        }

        @media (max-width:1199.98px) {
            .navbar-expand-xl > .container, .navbar-expand-xl > .container-fluid {
                padding-right: 0;
                padding-left: 0
            }
        }

        @media (min-width:1200px) {
            .navbar-expand-xl {
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-flow: row nowrap;
                flex-flow: row nowrap;
                -webkit-box-pack: start;
                -ms-flex-pack: start;
                justify-content: flex-start
            }

                .navbar-expand-xl .navbar-nav {
                    -webkit-box-orient: horizontal;
                    -webkit-box-direction: normal;
                    -ms-flex-direction: row;
                    flex-direction: row
                }

                    .navbar-expand-xl .navbar-nav .dropdown-menu {
                        position: absolute
                    }

                    .navbar-expand-xl .navbar-nav .dropdown-menu-right {
                        right: 0;
                        left: auto
                    }

                    .navbar-expand-xl .navbar-nav .nav-link {
                        padding-right: .5rem;
                        padding-left: .5rem
                    }

                .navbar-expand-xl > .container, .navbar-expand-xl > .container-fluid {
                    -ms-flex-wrap: nowrap;
                    flex-wrap: nowrap
                }

                .navbar-expand-xl .navbar-collapse {
                    display: -webkit-box !important;
                    display: -ms-flexbox !important;
                    display: flex !important;
                    -ms-flex-preferred-size: auto;
                    flex-basis: auto
                }

                .navbar-expand-xl .navbar-toggler {
                    display: none
                }

                .navbar-expand-xl .dropup .dropdown-menu {
                    top: auto;
                    bottom: 100%
                }
        }

        .navbar-expand {
            -webkit-box-orient: horizontal;
            -webkit-box-direction: normal;
            -ms-flex-flow: row nowrap;
            flex-flow: row nowrap;
            -webkit-box-pack: start;
            -ms-flex-pack: start;
            justify-content: flex-start
        }

            .navbar-expand > .container, .navbar-expand > .container-fluid {
                padding-right: 0;
                padding-left: 0
            }

            .navbar-expand .navbar-nav {
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-direction: row;
                flex-direction: row
            }

                .navbar-expand .navbar-nav .dropdown-menu {
                    position: absolute
                }

                .navbar-expand .navbar-nav .dropdown-menu-right {
                    right: 0;
                    left: auto
                }

                .navbar-expand .navbar-nav .nav-link {
                    padding-right: .5rem;
                    padding-left: .5rem
                }

            .navbar-expand > .container, .navbar-expand > .container-fluid {
                -ms-flex-wrap: nowrap;
                flex-wrap: nowrap
            }

            .navbar-expand .navbar-collapse {
                display: -webkit-box !important;
                display: -ms-flexbox !important;
                display: flex !important;
                -ms-flex-preferred-size: auto;
                flex-basis: auto
            }

            .navbar-expand .navbar-toggler {
                display: none
            }

            .navbar-expand .dropup .dropdown-menu {
                top: auto;
                bottom: 100%
            }

        .navbar-light .navbar-brand {
            color: rgba(0,0,0,.9)
        }

            .navbar-light .navbar-brand:focus, .navbar-light .navbar-brand:hover {
                color: rgba(0,0,0,.9)
            }

        .navbar-light .navbar-nav .nav-link {
            color: rgba(0,0,0,.5)
        }

            .navbar-light .navbar-nav .nav-link:focus, .navbar-light .navbar-nav .nav-link:hover {
                color: rgba(0,0,0,.7)
            }

            .navbar-light .navbar-nav .nav-link.disabled {
                color: rgba(0,0,0,.3)
            }

            .navbar-light .navbar-nav .active > .nav-link, .navbar-light .navbar-nav .nav-link.active, .navbar-light .navbar-nav .nav-link.show, .navbar-light .navbar-nav .show > .nav-link {
                color: rgba(0,0,0,.9)
            }

        .navbar-light .navbar-toggler {
            color: rgba(0,0,0,.5);
            border-color: rgba(0,0,0,.1)
        }

        .navbar-light .navbar-toggler-icon {
            background-image: url(\""data:image/svg+xml;charset=utf8,%3Csvg viewBox='0 0 30 30' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath stroke='rgba(0, 0, 0, 0.5)' stroke-width='2' stroke-linecap='round' stroke-miterlimit='10' d='M4 7h22M4 15h22M4 23h22'/%3E%3C/svg%3E\"")
        }

        .navbar-light .navbar-text {
            color: rgba(0,0,0,.5)
        }

            .navbar-light .navbar-text a {
                color: rgba(0,0,0,.9)
            }

                .navbar-light .navbar-text a:focus, .navbar-light .navbar-text a:hover {
                    color: rgba(0,0,0,.9)
                }

        .navbar-dark .navbar-brand {
            color: #fff
        }

            .navbar-dark .navbar-brand:focus, .navbar-dark .navbar-brand:hover {
                color: #fff
            }

        .navbar-dark .navbar-nav .nav-link {
            color: rgba(255,255,255,.5)
        }

            .navbar-dark .navbar-nav .nav-link:focus, .navbar-dark .navbar-nav .nav-link:hover {
                color: rgba(255,255,255,.75)
            }

            .navbar-dark .navbar-nav .nav-link.disabled {
                color: rgba(255,255,255,.25)
            }

            .navbar-dark .navbar-nav .active > .nav-link, .navbar-dark .navbar-nav .nav-link.active, .navbar-dark .navbar-nav .nav-link.show, .navbar-dark .navbar-nav .show > .nav-link {
                color: #fff
            }

        .navbar-dark .navbar-toggler {
            color: rgba(255,255,255,.5);
            border-color: rgba(255,255,255,.1)
        }

        .navbar-dark .navbar-toggler-icon {
            background-image: url(\""data:image/svg+xml;charset=utf8,%3Csvg viewBox='0 0 30 30' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath stroke='rgba(255, 255, 255, 0.5)' stroke-width='2' stroke-linecap='round' stroke-miterlimit='10' d='M4 7h22M4 15h22M4 23h22'/%3E%3C/svg%3E\"")
        }

        .navbar-dark .navbar-text {
            color: rgba(255,255,255,.5)
        }

            .navbar-dark .navbar-text a {
                color: #fff
            }

                .navbar-dark .navbar-text a:focus, .navbar-dark .navbar-text a:hover {
                    color: #fff
                }

        .card {
            position: relative;
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column;
            min-width: 0;
            word-wrap: break-word;
            background-color: #fff;
            background-clip: border-box;
            border: 1px solid rgba(0,0,0,.125);
            border-radius: .25rem
        }

            .card > hr {
                margin-right: 0;
                margin-left: 0
            }

            .card > .list-group:first-child .list-group-item:first-child {
                border-top-left-radius: .25rem;
                border-top-right-radius: .25rem
            }

            .card > .list-group:last-child .list-group-item:last-child {
                border-bottom-right-radius: .25rem;
                border-bottom-left-radius: .25rem
            }

        .card-body {
            -webkit-box-flex: 1;
            -ms-flex: 1 1 auto;
            flex: 1 1 auto;
            padding: 1.25rem
        }

        .card-title {
            margin-bottom: .75rem
        }

        .card-subtitle {
            margin-top: -.375rem;
            margin-bottom: 0
        }

        .card-text:last-child {
            margin-bottom: 0
        }

        .card-link:hover {
            text-decoration: none
        }

        .card-link + .card-link {
            margin-left: 1.25rem
        }

        .card-header {
            padding: .75rem 1.25rem;
            margin-bottom: 0;
            background-color: rgba(0,0,0,.03);
            border-bottom: 1px solid rgba(0,0,0,.125)
        }

            .card-header:first-child {
                border-radius: calc(.25rem - 1px) calc(.25rem - 1px) 0 0
            }

            .card-header + .list-group .list-group-item:first-child {
                border-top: 0
            }

        .card-footer {
            padding: .75rem 1.25rem;
            background-color: rgba(0,0,0,.03);
            border-top: 1px solid rgba(0,0,0,.125)
        }

            .card-footer:last-child {
                border-radius: 0 0 calc(.25rem - 1px) calc(.25rem - 1px)
            }

        .card-header-tabs {
            margin-right: -.625rem;
            margin-bottom: -.75rem;
            margin-left: -.625rem;
            border-bottom: 0
        }

        .card-header-pills {
            margin-right: -.625rem;
            margin-left: -.625rem
        }

        .card-img-overlay {
            position: absolute;
            top: 0;
            right: 0;
            bottom: 0;
            left: 0;
            padding: 1.25rem
        }

        .card-img {
            width: 100%;
            border-radius: calc(.25rem - 1px)
        }

        .card-img-top {
            width: 100%;
            border-top-left-radius: calc(.25rem - 1px);
            border-top-right-radius: calc(.25rem - 1px)
        }

        .card-img-bottom {
            width: 100%;
            border-bottom-right-radius: calc(.25rem - 1px);
            border-bottom-left-radius: calc(.25rem - 1px)
        }

        .card-deck {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column
        }

            .card-deck .card {
                margin-bottom: 15px
            }

        @media (min-width:576px) {
            .card-deck {
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-flow: row wrap;
                flex-flow: row wrap;
                margin-right: -15px;
                margin-left: -15px
            }

                .card-deck .card {
                    display: -webkit-box;
                    display: -ms-flexbox;
                    display: flex;
                    -webkit-box-flex: 1;
                    -ms-flex: 1 0 0%;
                    flex: 1 0 0%;
                    -webkit-box-orient: vertical;
                    -webkit-box-direction: normal;
                    -ms-flex-direction: column;
                    flex-direction: column;
                    margin-right: 15px;
                    margin-bottom: 0;
                    margin-left: 15px
                }
        }

        .card-group {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column
        }

            .card-group > .card {
                margin-bottom: 15px
            }

        @media (min-width:576px) {
            .card-group {
                -webkit-box-orient: horizontal;
                -webkit-box-direction: normal;
                -ms-flex-flow: row wrap;
                flex-flow: row wrap
            }

                .card-group > .card {
                    -webkit-box-flex: 1;
                    -ms-flex: 1 0 0%;
                    flex: 1 0 0%;
                    margin-bottom: 0
                }

                    .card-group > .card + .card {
                        margin-left: 0;
                        border-left: 0
                    }

                    .card-group > .card:first-child {
                        border-top-right-radius: 0;
                        border-bottom-right-radius: 0
                    }

                        .card-group > .card:first-child .card-header, .card-group > .card:first-child .card-img-top {
                            border-top-right-radius: 0
                        }

                        .card-group > .card:first-child .card-footer, .card-group > .card:first-child .card-img-bottom {
                            border-bottom-right-radius: 0
                        }

                    .card-group > .card:last-child {
                        border-top-left-radius: 0;
                        border-bottom-left-radius: 0
                    }

                        .card-group > .card:last-child .card-header, .card-group > .card:last-child .card-img-top {
                            border-top-left-radius: 0
                        }

                        .card-group > .card:last-child .card-footer, .card-group > .card:last-child .card-img-bottom {
                            border-bottom-left-radius: 0
                        }

                    .card-group > .card:only-child {
                        border-radius: .25rem
                    }

                        .card-group > .card:only-child .card-header, .card-group > .card:only-child .card-img-top {
                            border-top-left-radius: .25rem;
                            border-top-right-radius: .25rem
                        }

                        .card-group > .card:only-child .card-footer, .card-group > .card:only-child .card-img-bottom {
                            border-bottom-right-radius: .25rem;
                            border-bottom-left-radius: .25rem
                        }

                    .card-group > .card:not(:first-child):not(:last-child):not(:only-child) {
                        border-radius: 0
                    }

                        .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-footer, .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-header, .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-img-bottom, .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-img-top {
                            border-radius: 0
                        }
        }

        .card-columns .card {
            margin-bottom: .75rem
        }

        @media (min-width:576px) {
            .card-columns {
                -webkit-column-count: 3;
                -moz-column-count: 3;
                column-count: 3;
                -webkit-column-gap: 1.25rem;
                -moz-column-gap: 1.25rem;
                column-gap: 1.25rem
            }

                .card-columns .card {
                    display: inline-block;
                    width: 100%
                }
        }

        .breadcrumb {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -ms-flex-wrap: wrap;
            flex-wrap: wrap;
            padding: .75rem 1rem;
            margin-bottom: 1rem;
            list-style: none;
            background-color: #e9ecef;
            border-radius: .25rem
        }

        .breadcrumb-item + .breadcrumb-item::before {
            display: inline-block;
            padding-right: .5rem;
            padding-left: .5rem;
            color: #6c757d;
            content: \""/\""
        }

        .breadcrumb-item + .breadcrumb-item:hover::before {
            text-decoration: underline
        }

        .breadcrumb-item + .breadcrumb-item:hover::before {
            text-decoration: none
        }

        .breadcrumb-item.active {
            color: #6c757d
        }

        .pagination {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            padding-left: 0;
            list-style: none;
            border-radius: .25rem
        }

        .page-link {
            position: relative;
            display: block;
            padding: .5rem .75rem;
            margin-left: -1px;
            line-height: 1.25;
            color: #007bff;
            background-color: #fff;
            border: 1px solid #dee2e6
        }

            .page-link:hover {
                color: #0056b3;
                text-decoration: none;
                background-color: #e9ecef;
                border-color: #dee2e6
            }

            .page-link:focus {
                z-index: 2;
                outline: 0;
                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)
            }

            .page-link:not(:disabled):not(.disabled) {
                cursor: pointer
            }

        .page-item:first-child .page-link {
            margin-left: 0;
            border-top-left-radius: .25rem;
            border-bottom-left-radius: .25rem
        }

        .page-item:last-child .page-link {
            border-top-right-radius: .25rem;
            border-bottom-right-radius: .25rem
        }

        .page-item.active .page-link {
            z-index: 1;
            color: #fff;
            background-color: #007bff;
            border-color: #007bff
        }

        .page-item.disabled .page-link {
            color: #6c757d;
            pointer-events: none;
            cursor: auto;
            background-color: #fff;
            border-color: #dee2e6
        }

        .pagination-lg .page-link {
            padding: .75rem 1.5rem;
            font-size: 1.25rem;
            line-height: 1.5
        }

        .pagination-lg .page-item:first-child .page-link {
            border-top-left-radius: .3rem;
            border-bottom-left-radius: .3rem
        }

        .pagination-lg .page-item:last-child .page-link {
            border-top-right-radius: .3rem;
            border-bottom-right-radius: .3rem
        }

        .pagination-sm .page-link {
            padding: .25rem .5rem;
            font-size: .875rem;
            line-height: 1.5
        }

        .pagination-sm .page-item:first-child .page-link {
            border-top-left-radius: .2rem;
            border-bottom-left-radius: .2rem
        }

        .pagination-sm .page-item:last-child .page-link {
            border-top-right-radius: .2rem;
            border-bottom-right-radius: .2rem
        }

        .badge {
            display: inline-block;
            padding: .25em .4em;
            font-size: 75%;
            font-weight: 700;
            line-height: 1;
            text-align: center;
            white-space: nowrap;
            vertical-align: baseline;
            border-radius: .25rem
        }

            .badge:empty {
                display: none
            }

        .btn .badge {
            position: relative;
            top: -1px
        }

        .badge-pill {
            padding-right: .6em;
            padding-left: .6em;
            border-radius: 10rem
        }

        .badge-primary {
            color: #fff;
            background-color: #007bff
        }

            .badge-primary[href]:focus, .badge-primary[href]:hover {
                color: #fff;
                text-decoration: none;
                background-color: #0062cc
            }

        .badge-secondary {
            color: #fff;
            background-color: #6c757d
        }

            .badge-secondary[href]:focus, .badge-secondary[href]:hover {
                color: #fff;
                text-decoration: none;
                background-color: #545b62
            }

        .badge-success {
            color: #fff;
            background-color: #28a745
        }

            .badge-success[href]:focus, .badge-success[href]:hover {
                color: #fff;
                text-decoration: none;
                background-color: #1e7e34
            }

        .badge-info {
            color: #fff;
            background-color: #17a2b8
        }

            .badge-info[href]:focus, .badge-info[href]:hover {
                color: #fff;
                text-decoration: none;
                background-color: #117a8b
            }

        .badge-warning {
            color: #212529;
            background-color: #ffc107
        }

            .badge-warning[href]:focus, .badge-warning[href]:hover {
                color: #212529;
                text-decoration: none;
                background-color: #d39e00
            }

        .badge-danger {
            color: #fff;
            background-color: #dc3545
        }

            .badge-danger[href]:focus, .badge-danger[href]:hover {
                color: #fff;
                text-decoration: none;
                background-color: #bd2130
            }

        .badge-light {
            color: #212529;
            background-color: #f8f9fa
        }

            .badge-light[href]:focus, .badge-light[href]:hover {
                color: #212529;
                text-decoration: none;
                background-color: #dae0e5
            }

        .badge-dark {
            color: #fff;
            background-color: #343a40
        }

            .badge-dark[href]:focus, .badge-dark[href]:hover {
                color: #fff;
                text-decoration: none;
                background-color: #1d2124
            }

        .jumbotron {
            padding: 2rem 1rem;
            margin-bottom: 2rem;
            background-color: #e9ecef;
            border-radius: .3rem
        }

        @media (min-width:576px) {
            .jumbotron {
                padding: 4rem 2rem
            }
        }

        .jumbotron-fluid {
            padding-right: 0;
            padding-left: 0;
            border-radius: 0
        }

        .alert {
            position: relative;
            padding: .75rem 1.25rem;
            margin-bottom: 1rem;
            border: 1px solid transparent;
            border-radius: .25rem
        }

        .alert-heading {
            color: inherit
        }

        .alert-link {
            font-weight: 700
        }

        .alert-dismissible {
            padding-right: 4rem
        }

            .alert-dismissible .close {
                position: absolute;
                top: 0;
                right: 0;
                padding: .75rem 1.25rem;
                color: inherit
            }

        .alert-primary {
            color: #004085;
            background-color: #cce5ff;
            border-color: #b8daff
        }

            .alert-primary hr {
                border-top-color: #9fcdff
            }

            .alert-primary .alert-link {
                color: #002752
            }

        .alert-secondary {
            color: #383d41;
            background-color: #e2e3e5;
            border-color: #d6d8db
        }

            .alert-secondary hr {
                border-top-color: #c8cbcf
            }

            .alert-secondary .alert-link {
                color: #202326
            }

        .alert-success {
            color: #155724;
            background-color: #d4edda;
            border-color: #c3e6cb
        }

            .alert-success hr {
                border-top-color: #b1dfbb
            }

            .alert-success .alert-link {
                color: #0b2e13
            }

        .alert-info {
            color: #0c5460;
            background-color: #d1ecf1;
            border-color: #bee5eb
        }

            .alert-info hr {
                border-top-color: #abdde5
            }

            .alert-info .alert-link {
                color: #062c33
            }

        .alert-warning {
            color: #856404;
            background-color: #fff3cd;
            border-color: #ffeeba
        }

            .alert-warning hr {
                border-top-color: #ffe8a1
            }

            .alert-warning .alert-link {
                color: #533f03
            }

        .alert-danger {
            color: #721c24;
            background-color: #f8d7da;
            border-color: #f5c6cb
        }

            .alert-danger hr {
                border-top-color: #f1b0b7
            }

            .alert-danger .alert-link {
                color: #491217
            }

        .alert-light {
            color: #818182;
            background-color: #fefefe;
            border-color: #fdfdfe
        }

            .alert-light hr {
                border-top-color: #ececf6
            }

            .alert-light .alert-link {
                color: #686868
            }

        .alert-dark {
            color: #1b1e21;
            background-color: #d6d8d9;
            border-color: #c6c8ca
        }

            .alert-dark hr {
                border-top-color: #b9bbbe
            }

            .alert-dark .alert-link {
                color: #040505
            }

        @-webkit-keyframes progress-bar-stripes {
            from {
                background-position: 1rem 0
            }

            to {
                background-position: 0 0
            }
        }

        @keyframes progress-bar-stripes {
            from {
                background-position: 1rem 0
            }

            to {
                background-position: 0 0
            }
        }

        .progress {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            height: 1rem;
            overflow: hidden;
            font-size: .75rem;
            background-color: #e9ecef;
            border-radius: .25rem
        }

        .progress-bar {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column;
            -webkit-box-pack: center;
            -ms-flex-pack: center;
            justify-content: center;
            color: #fff;
            text-align: center;
            background-color: #007bff;
            transition: width .6s ease
        }

        .progress-bar-striped {
            background-image: linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);
            background-size: 1rem 1rem
        }

        .progress-bar-animated {
            -webkit-animation: progress-bar-stripes 1s linear infinite;
            animation: progress-bar-stripes 1s linear infinite
        }

        .media {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-align: start;
            -ms-flex-align: start;
            align-items: flex-start
        }

        .media-body {
            -webkit-box-flex: 1;
            -ms-flex: 1;
            flex: 1
        }

        .list-group {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column;
            padding-left: 0;
            margin-bottom: 0
        }

        .list-group-item-action {
            width: 100%;
            color: #495057;
            text-align: inherit
        }

            .list-group-item-action:focus, .list-group-item-action:hover {
                color: #495057;
                text-decoration: none;
                background-color: #f8f9fa
            }

            .list-group-item-action:active {
                color: #212529;
                background-color: #e9ecef
            }

        .list-group-item {
            position: relative;
            display: block;
            padding: .75rem 1.25rem;
            margin-bottom: -1px;
            background-color: #fff;
            border: 1px solid rgba(0,0,0,.125)
        }

            .list-group-item:first-child {
                border-top-left-radius: .25rem;
                border-top-right-radius: .25rem
            }

            .list-group-item:last-child {
                margin-bottom: 0;
                border-bottom-right-radius: .25rem;
                border-bottom-left-radius: .25rem
            }

            .list-group-item:focus, .list-group-item:hover {
                z-index: 1;
                text-decoration: none
            }

            .list-group-item.disabled, .list-group-item:disabled {
                color: #6c757d;
                background-color: #fff
            }

            .list-group-item.active {
                z-index: 2;
                color: #fff;
                background-color: #007bff;
                border-color: #007bff
            }

        .list-group-flush .list-group-item {
            border-right: 0;
            border-left: 0;
            border-radius: 0
        }

        .list-group-flush:first-child .list-group-item:first-child {
            border-top: 0
        }

        .list-group-flush:last-child .list-group-item:last-child {
            border-bottom: 0
        }

        .list-group-item-primary {
            color: #004085;
            background-color: #b8daff
        }

            .list-group-item-primary.list-group-item-action:focus, .list-group-item-primary.list-group-item-action:hover {
                color: #004085;
                background-color: #9fcdff
            }

            .list-group-item-primary.list-group-item-action.active {
                color: #fff;
                background-color: #004085;
                border-color: #004085
            }

        .list-group-item-secondary {
            color: #383d41;
            background-color: #d6d8db
        }

            .list-group-item-secondary.list-group-item-action:focus, .list-group-item-secondary.list-group-item-action:hover {
                color: #383d41;
                background-color: #c8cbcf
            }

            .list-group-item-secondary.list-group-item-action.active {
                color: #fff;
                background-color: #383d41;
                border-color: #383d41
            }

        .list-group-item-success {
            color: #155724;
            background-color: #c3e6cb
        }

            .list-group-item-success.list-group-item-action:focus, .list-group-item-success.list-group-item-action:hover {
                color: #155724;
                background-color: #b1dfbb
            }

            .list-group-item-success.list-group-item-action.active {
                color: #fff;
                background-color: #155724;
                border-color: #155724
            }

        .list-group-item-info {
            color: #0c5460;
            background-color: #bee5eb
        }

            .list-group-item-info.list-group-item-action:focus, .list-group-item-info.list-group-item-action:hover {
                color: #0c5460;
                background-color: #abdde5
            }

            .list-group-item-info.list-group-item-action.active {
                color: #fff;
                background-color: #0c5460;
                border-color: #0c5460
            }

        .list-group-item-warning {
            color: #856404;
            background-color: #ffeeba
        }

            .list-group-item-warning.list-group-item-action:focus, .list-group-item-warning.list-group-item-action:hover {
                color: #856404;
                background-color: #ffe8a1
            }

            .list-group-item-warning.list-group-item-action.active {
                color: #fff;
                background-color: #856404;
                border-color: #856404
            }

        .list-group-item-danger {
            color: #721c24;
            background-color: #f5c6cb
        }

            .list-group-item-danger.list-group-item-action:focus, .list-group-item-danger.list-group-item-action:hover {
                color: #721c24;
                background-color: #f1b0b7
            }

            .list-group-item-danger.list-group-item-action.active {
                color: #fff;
                background-color: #721c24;
                border-color: #721c24
            }

        .list-group-item-light {
            color: #818182;
            background-color: #fdfdfe
        }

            .list-group-item-light.list-group-item-action:focus, .list-group-item-light.list-group-item-action:hover {
                color: #818182;
                background-color: #ececf6
            }

            .list-group-item-light.list-group-item-action.active {
                color: #fff;
                background-color: #818182;
                border-color: #818182
            }

        .list-group-item-dark {
            color: #1b1e21;
            background-color: #c6c8ca
        }

            .list-group-item-dark.list-group-item-action:focus, .list-group-item-dark.list-group-item-action:hover {
                color: #1b1e21;
                background-color: #b9bbbe
            }

            .list-group-item-dark.list-group-item-action.active {
                color: #fff;
                background-color: #1b1e21;
                border-color: #1b1e21
            }

        .close {
            float: right;
            font-size: 1.5rem;
            font-weight: 700;
            line-height: 1;
            color: #000;
            text-shadow: 0 1px 0 #fff;
            opacity: .5
        }

            .close:focus, .close:hover {
                color: #000;
                text-decoration: none;
                opacity: .75
            }

            .close:not(:disabled):not(.disabled) {
                cursor: pointer
            }

        button.close {
            padding: 0;
            background-color: transparent;
            border: 0;
            -webkit-appearance: none
        }

        .modal-open {
            overflow: hidden
        }

        .modal {
            position: fixed;
            top: 0;
            right: 0;
            bottom: 0;
            left: 0;
            z-index: 1050;
            display: none;
            overflow: hidden;
            outline: 0
        }

        .modal-open .modal {
            overflow-x: hidden;
            overflow-y: auto
        }

        .modal-dialog {
            position: relative;
            width: auto;
            margin: .5rem;
            pointer-events: none
        }

        .modal.fade .modal-dialog {
            transition: -webkit-transform .3s ease-out;
            transition: transform .3s ease-out;
            transition: transform .3s ease-out,-webkit-transform .3s ease-out;
            -webkit-transform: translate(0,-25%);
            transform: translate(0,-25%)
        }

        .modal.show .modal-dialog {
            -webkit-transform: translate(0,0);
            transform: translate(0,0)
        }

        .modal-dialog-centered {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center;
            min-height: calc(100% - (.5rem * 2))
        }

        .modal-content {
            position: relative;
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-orient: vertical;
            -webkit-box-direction: normal;
            -ms-flex-direction: column;
            flex-direction: column;
            width: 100%;
            pointer-events: auto;
            background-color: #fff;
            background-clip: padding-box;
            border: 1px solid rgba(0,0,0,.2);
            border-radius: .3rem;
            outline: 0
        }

        .modal-backdrop {
            position: fixed;
            top: 0;
            right: 0;
            bottom: 0;
            left: 0;
            z-index: 1040;
            background-color: #000
        }

            .modal-backdrop.fade {
                opacity: 0
            }

            .modal-backdrop.show {
                opacity: .5
            }

        .modal-header {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-align: start;
            -ms-flex-align: start;
            align-items: flex-start;
            -webkit-box-pack: justify;
            -ms-flex-pack: justify;
            justify-content: space-between;
            padding: 1rem;
            border-bottom: 1px solid #e9ecef;
            border-top-left-radius: .3rem;
            border-top-right-radius: .3rem
        }

            .modal-header .close {
                padding: 1rem;
                margin: -1rem -1rem -1rem auto
            }

        .modal-title {
            margin-bottom: 0;
            line-height: 1.5
        }

        .modal-body {
            position: relative;
            -webkit-box-flex: 1;
            -ms-flex: 1 1 auto;
            flex: 1 1 auto;
            padding: 1rem
        }

        .modal-footer {
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center;
            -webkit-box-pack: end;
            -ms-flex-pack: end;
            justify-content: flex-end;
            padding: 1rem;
            border-top: 1px solid #e9ecef
        }

            .modal-footer > :not(:first-child) {
                margin-left: .25rem
            }

            .modal-footer > :not(:last-child) {
                margin-right: .25rem
            }

        .modal-scrollbar-measure {
            position: absolute;
            top: -9999px;
            width: 50px;
            height: 50px;
            overflow: scroll
        }

        @media (min-width:576px) {
            .modal-dialog {
                max-width: 500px;
                margin: 1.75rem auto
            }

            .modal-dialog-centered {
                min-height: calc(100% - (1.75rem * 2))
            }

            .modal-sm {
                max-width: 300px
            }
        }

        @media (min-width:992px) {
            .modal-lg {
                max-width: 800px
            }
        }

        .tooltip {
            position: absolute;
            z-index: 1070;
            display: block;
            margin: 0;
            font-family: -apple-system,BlinkMacSystemFont,\""Segoe UI\"",Roboto,\""Helvetica Neue\"",Arial,sans-serif,\""Apple Color Emoji\"",\""Segoe UI Emoji\"",\""Segoe UI Symbol\"";
            font-style: normal;
            font-weight: 400;
            line-height: 1.5;
            text-align: left;
            text-align: start;
            text-decoration: none;
            text-shadow: none;
            text-transform: none;
            letter-spacing: normal;
            word-break: normal;
            word-spacing: normal;
            white-space: normal;
            line-break: auto;
            font-size: .875rem;
            word-wrap: break-word;
            opacity: 0
        }

            .tooltip.show {
                opacity: .9
            }

            .tooltip .arrow {
                position: absolute;
                display: block;
                width: .8rem;
                height: .4rem
            }

                .tooltip .arrow::before {
                    position: absolute;
                    content: \""\"";
                    border-color: transparent;
                    border-style: solid
                }

        .bs-tooltip-auto[x-placement^=top], .bs-tooltip-top {
            padding: .4rem 0
        }

            .bs-tooltip-auto[x-placement^=top] .arrow, .bs-tooltip-top .arrow {
                bottom: 0
            }

                .bs-tooltip-auto[x-placement^=top] .arrow::before, .bs-tooltip-top .arrow::before {
                    top: 0;
                    border-width: .4rem .4rem 0;
                    border-top-color: #000
                }

        .bs-tooltip-auto[x-placement^=right], .bs-tooltip-right {
            padding: 0 .4rem
        }

            .bs-tooltip-auto[x-placement^=right] .arrow, .bs-tooltip-right .arrow {
                left: 0;
                width: .4rem;
                height: .8rem
            }

                .bs-tooltip-auto[x-placement^=right] .arrow::before, .bs-tooltip-right .arrow::before {
                    right: 0;
                    border-width: .4rem .4rem .4rem 0;
                    border-right-color: #000
                }

        .bs-tooltip-auto[x-placement^=bottom], .bs-tooltip-bottom {
            padding: .4rem 0
        }

            .bs-tooltip-auto[x-placement^=bottom] .arrow, .bs-tooltip-bottom .arrow {
                top: 0
            }

                .bs-tooltip-auto[x-placement^=bottom] .arrow::before, .bs-tooltip-bottom .arrow::before {
                    bottom: 0;
                    border-width: 0 .4rem .4rem;
                    border-bottom-color: #000
                }

        .bs-tooltip-auto[x-placement^=left], .bs-tooltip-left {
            padding: 0 .4rem
        }

            .bs-tooltip-auto[x-placement^=left] .arrow, .bs-tooltip-left .arrow {
                right: 0;
                width: .4rem;
                height: .8rem
            }

                .bs-tooltip-auto[x-placement^=left] .arrow::before, .bs-tooltip-left .arrow::before {
                    left: 0;
                    border-width: .4rem 0 .4rem .4rem;
                    border-left-color: #000
                }

        .tooltip-inner {
            max-width: 200px;
            padding: .25rem .5rem;
            color: #fff;
            text-align: center;
            background-color: #000;
            border-radius: .25rem
        }

        .popover {
            position: absolute;
            top: 0;
            left: 0;
            z-index: 1060;
            display: block;
            max-width: 276px;
            font-family: -apple-system,BlinkMacSystemFont,\""Segoe UI\"",Roboto,\""Helvetica Neue\"",Arial,sans-serif,\""Apple Color Emoji\"",\""Segoe UI Emoji\"",\""Segoe UI Symbol\"";
            font-style: normal;
            font-weight: 400;
            line-height: 1.5;
            text-align: left;
            text-align: start;
            text-decoration: none;
            text-shadow: none;
            text-transform: none;
            letter-spacing: normal;
            word-break: normal;
            word-spacing: normal;
            white-space: normal;
            line-break: auto;
            font-size: .875rem;
            word-wrap: break-word;
            background-color: #fff;
            background-clip: padding-box;
            border: 1px solid rgba(0,0,0,.2);
            border-radius: .3rem
        }

            .popover .arrow {
                position: absolute;
                display: block;
                width: 1rem;
                height: .5rem;
                margin: 0 .3rem
            }

                .popover .arrow::after, .popover .arrow::before {
                    position: absolute;
                    display: block;
                    content: \""\"";
                    border-color: transparent;
                    border-style: solid
                }

        .bs-popover-auto[x-placement^=top], .bs-popover-top {
            margin-bottom: .5rem
        }

            .bs-popover-auto[x-placement^=top] .arrow, .bs-popover-top .arrow {
                bottom: calc((.5rem + 1px) * -1)
            }

                .bs-popover-auto[x-placement^=top] .arrow::after, .bs-popover-auto[x-placement^=top] .arrow::before, .bs-popover-top .arrow::after, .bs-popover-top .arrow::before {
                    border-width: .5rem .5rem 0
                }

                .bs-popover-auto[x-placement^=top] .arrow::before, .bs-popover-top .arrow::before {
                    bottom: 0;
                    border-top-color: rgba(0,0,0,.25)
                }

                .bs-popover-auto[x-placement^=top] .arrow::after, .bs-popover-top .arrow::after {
                    bottom: 1px;
                    border-top-color: #fff
                }

        .bs-popover-auto[x-placement^=right], .bs-popover-right {
            margin-left: .5rem
        }

            .bs-popover-auto[x-placement^=right] .arrow, .bs-popover-right .arrow {
                left: calc((.5rem + 1px) * -1);
                width: .5rem;
                height: 1rem;
                margin: .3rem 0
            }

                .bs-popover-auto[x-placement^=right] .arrow::after, .bs-popover-auto[x-placement^=right] .arrow::before, .bs-popover-right .arrow::after, .bs-popover-right .arrow::before {
                    border-width: .5rem .5rem .5rem 0
                }

                .bs-popover-auto[x-placement^=right] .arrow::before, .bs-popover-right .arrow::before {
                    left: 0;
                    border-right-color: rgba(0,0,0,.25)
                }

                .bs-popover-auto[x-placement^=right] .arrow::after, .bs-popover-right .arrow::after {
                    left: 1px;
                    border-right-color: #fff
                }

        .bs-popover-auto[x-placement^=bottom], .bs-popover-bottom {
            margin-top: .5rem
        }

            .bs-popover-auto[x-placement^=bottom] .arrow, .bs-popover-bottom .arrow {
                top: calc((.5rem + 1px) * -1)
            }

                .bs-popover-auto[x-placement^=bottom] .arrow::after, .bs-popover-auto[x-placement^=bottom] .arrow::before, .bs-popover-bottom .arrow::after, .bs-popover-bottom .arrow::before {
                    border-width: 0 .5rem .5rem .5rem
                }

                .bs-popover-auto[x-placement^=bottom] .arrow::before, .bs-popover-bottom .arrow::before {
                    top: 0;
                    border-bottom-color: rgba(0,0,0,.25)
                }

                .bs-popover-auto[x-placement^=bottom] .arrow::after, .bs-popover-bottom .arrow::after {
                    top: 1px;
                    border-bottom-color: #fff
                }

            .bs-popover-auto[x-placement^=bottom] .popover-header::before, .bs-popover-bottom .popover-header::before {
                position: absolute;
                top: 0;
                left: 50%;
                display: block;
                width: 1rem;
                margin-left: -.5rem;
                content: \""\"";
                border-bottom: 1px solid #f7f7f7
            }

        .bs-popover-auto[x-placement^=left], .bs-popover-left {
            margin-right: .5rem
        }

            .bs-popover-auto[x-placement^=left] .arrow, .bs-popover-left .arrow {
                right: calc((.5rem + 1px) * -1);
                width: .5rem;
                height: 1rem;
                margin: .3rem 0
            }

                .bs-popover-auto[x-placement^=left] .arrow::after, .bs-popover-auto[x-placement^=left] .arrow::before, .bs-popover-left .arrow::after, .bs-popover-left .arrow::before {
                    border-width: .5rem 0 .5rem .5rem
                }

                .bs-popover-auto[x-placement^=left] .arrow::before, .bs-popover-left .arrow::before {
                    right: 0;
                    border-left-color: rgba(0,0,0,.25)
                }

                .bs-popover-auto[x-placement^=left] .arrow::after, .bs-popover-left .arrow::after {
                    right: 1px;
                    border-left-color: #fff
                }

        .popover-header {
            padding: .5rem .75rem;
            margin-bottom: 0;
            font-size: 1rem;
            color: inherit;
            background-color: #f7f7f7;
            border-bottom: 1px solid #ebebeb;
            border-top-left-radius: calc(.3rem - 1px);
            border-top-right-radius: calc(.3rem - 1px)
        }

            .popover-header:empty {
                display: none
            }

        .popover-body {
            padding: .5rem .75rem;
            color: #212529
        }

        .carousel {
            position: relative
        }

        .carousel-inner {
            position: relative;
            width: 100%;
            overflow: hidden
        }

        .carousel-item {
            position: relative;
            display: none;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center;
            width: 100%;
            transition: -webkit-transform .6s ease;
            transition: transform .6s ease;
            transition: transform .6s ease,-webkit-transform .6s ease;
            -webkit-backface-visibility: hidden;
            backface-visibility: hidden;
            -webkit-perspective: 1000px;
            perspective: 1000px
        }

            .carousel-item-next, .carousel-item-prev, .carousel-item.active {
                display: block
            }

        .carousel-item-next, .carousel-item-prev {
            position: absolute;
            top: 0
        }

            .carousel-item-next.carousel-item-left, .carousel-item-prev.carousel-item-right {
                -webkit-transform: translateX(0);
                transform: translateX(0)
            }

        @supports ((-webkit-transform-style:preserve-3d) or (transform-style:preserve-3d)) {
            .carousel-item-next.carousel-item-left, .carousel-item-prev.carousel-item-right {
                -webkit-transform: translate3d(0,0,0);
                transform: translate3d(0,0,0)
            }
        }

        .active.carousel-item-right, .carousel-item-next {
            -webkit-transform: translateX(100%);
            transform: translateX(100%)
        }

        @supports ((-webkit-transform-style:preserve-3d) or (transform-style:preserve-3d)) {
            .active.carousel-item-right, .carousel-item-next {
                -webkit-transform: translate3d(100%,0,0);
                transform: translate3d(100%,0,0)
            }
        }

        .active.carousel-item-left, .carousel-item-prev {
            -webkit-transform: translateX(-100%);
            transform: translateX(-100%)
        }

        @supports ((-webkit-transform-style:preserve-3d) or (transform-style:preserve-3d)) {
            .active.carousel-item-left, .carousel-item-prev {
                -webkit-transform: translate3d(-100%,0,0);
                transform: translate3d(-100%,0,0)
            }
        }

        .carousel-control-next, .carousel-control-prev {
            position: absolute;
            top: 0;
            bottom: 0;
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-align: center;
            -ms-flex-align: center;
            align-items: center;
            -webkit-box-pack: center;
            -ms-flex-pack: center;
            justify-content: center;
            width: 15%;
            color: #fff;
            text-align: center;
            opacity: .5
        }

            .carousel-control-next:focus, .carousel-control-next:hover, .carousel-control-prev:focus, .carousel-control-prev:hover {
                color: #fff;
                text-decoration: none;
                outline: 0;
                opacity: .9
            }

        .carousel-control-prev {
            left: 0
        }

        .carousel-control-next {
            right: 0
        }

        .carousel-control-next-icon, .carousel-control-prev-icon {
            display: inline-block;
            width: 20px;
            height: 20px;
            background: transparent no-repeat center center;
            background-size: 100% 100%
        }

        .carousel-control-prev-icon {
            background-image: url(\""data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M5.25 0l-4 4 4 4 1.5-1.5-2.5-2.5 2.5-2.5-1.5-1.5z'/%3E%3C/svg%3E\"")
        }

        .carousel-control-next-icon {
            background-image: url(\""data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M2.75 0l-1.5 1.5 2.5 2.5-2.5 2.5 1.5 1.5 4-4-4-4z'/%3E%3C/svg%3E\"")
        }

        .carousel-indicators {
            position: absolute;
            right: 0;
            bottom: 10px;
            left: 0;
            z-index: 15;
            display: -webkit-box;
            display: -ms-flexbox;
            display: flex;
            -webkit-box-pack: center;
            -ms-flex-pack: center;
            justify-content: center;
            padding-left: 0;
            margin-right: 15%;
            margin-left: 15%;
            list-style: none
        }

            .carousel-indicators li {
                position: relative;
                -webkit-box-flex: 0;
                -ms-flex: 0 1 auto;
                flex: 0 1 auto;
                width: 30px;
                height: 3px;
                margin-right: 3px;
                margin-left: 3px;
                text-indent: -999px;
                background-color: rgba(255,255,255,.5)
            }

                .carousel-indicators li::before {
                    position: absolute;
                    top: -10px;
                    left: 0;
                    display: inline-block;
                    width: 100%;
                    height: 10px;
                    content: \""\""
                }

                .carousel-indicators li::after {
                    position: absolute;
                    bottom: -10px;
                    left: 0;
                    display: inline-block;
                    width: 100%;
                    height: 10px;
                    content: \""\""
                }

            .carousel-indicators .active {
                background-color: #fff
            }

        .carousel-caption {
            position: absolute;
            right: 15%;
            bottom: 20px;
            left: 15%;
            z-index: 10;
            padding-top: 20px;
            padding-bottom: 20px;
            color: #fff;
            text-align: center
        }

        .align-baseline {
            vertical-align: baseline !important
        }

        .align-top {
            vertical-align: top !important
        }

        .align-middle {
            vertical-align: middle !important
        }

        .align-bottom {
            vertical-align: bottom !important
        }

        .align-text-bottom {
            vertical-align: text-bottom !important
        }

        .align-text-top {
            vertical-align: text-top !important
        }

        .bg-primary {
            background-color: #007bff !important
        }

        a.bg-primary:focus, a.bg-primary:hover, button.bg-primary:focus, button.bg-primary:hover {
            background-color: #0062cc !important
        }

        .bg-secondary {
            background-color: #6c757d !important
        }

        a.bg-secondary:focus, a.bg-secondary:hover, button.bg-secondary:focus, button.bg-secondary:hover {
            background-color: #545b62 !important
        }

        .bg-success {
            background-color: #28a745 !important
        }

        a.bg-success:focus, a.bg-success:hover, button.bg-success:focus, button.bg-success:hover {
            background-color: #1e7e34 !important
        }

        .bg-info {
            background-color: #17a2b8 !important
        }

        a.bg-info:focus, a.bg-info:hover, button.bg-info:focus, button.bg-info:hover {
            background-color: #117a8b !important
        }

        .bg-warning {
            background-color: #ffc107 !important
        }

        a.bg-warning:focus, a.bg-warning:hover, button.bg-warning:focus, button.bg-warning:hover {
            background-color: #d39e00 !important
        }

        .bg-danger {
            background-color: #dc3545 !important
        }

        a.bg-danger:focus, a.bg-danger:hover, button.bg-danger:focus, button.bg-danger:hover {
            background-color: #bd2130 !important
        }

        .bg-light {
            background-color: #f8f9fa !important
        }

        a.bg-light:focus, a.bg-light:hover, button.bg-light:focus, button.bg-light:hover {
            background-color: #dae0e5 !important
        }

        .bg-dark {
            background-color: #343a40 !important
        }

        a.bg-dark:focus, a.bg-dark:hover, button.bg-dark:focus, button.bg-dark:hover {
            background-color: #1d2124 !important
        }

        .bg-white {
            background-color: #fff !important
        }

        .bg-transparent {
            background-color: transparent !important
        }

        .border {
            border: 1px solid #dee2e6 !important
        }

        .border-top {
            border-top: 1px solid #dee2e6 !important
        }

        .border-right {
            border-right: 1px solid #dee2e6 !important
        }

        .border-bottom {
            border-bottom: 1px solid #dee2e6 !important
        }

        .border-left {
            border-left: 1px solid #dee2e6 !important
        }

        .border-0 {
            border: 0 !important
        }

        .border-top-0 {
            border-top: 0 !important
        }

        .border-right-0 {
            border-right: 0 !important
        }

        .border-bottom-0 {
            border-bottom: 0 !important
        }

        .border-left-0 {
            border-left: 0 !important
        }

        .border-primary {
            border-color: #007bff !important
        }

        .border-secondary {
            border-color: #6c757d !important
        }

        .border-success {
            border-color: #28a745 !important
        }

        .border-info {
            border-color: #17a2b8 !important
        }

        .border-warning {
            border-color: #ffc107 !important
        }

        .border-danger {
            border-color: #dc3545 !important
        }

        .border-light {
            border-color: #f8f9fa !important
        }

        .border-dark {
            border-color: #343a40 !important
        }

        .border-white {
            border-color: #fff !important
        }

        .rounded {
            border-radius: .25rem !important
        }

        .rounded-top {
            border-top-left-radius: .25rem !important;
            border-top-right-radius: .25rem !important
        }

        .rounded-right {
            border-top-right-radius: .25rem !important;
            border-bottom-right-radius: .25rem !important
        }

        .rounded-bottom {
            border-bottom-right-radius: .25rem !important;
            border-bottom-left-radius: .25rem !important
        }

        .rounded-left {
            border-top-left-radius: .25rem !important;
            border-bottom-left-radius: .25rem !important
        }

        .rounded-circle {
            border-radius: 50% !important
        }

        .rounded-0 {
            border-radius: 0 !important
        }

        .clearfix::after {
            display: block;
            clear: both;
            content: \""\""
        }

        .d-none {
            display: none !important
        }

        .d-inline {
            display: inline !important
        }

        .d-inline-block {
            display: inline-block !important
        }

        .d-block {
            display: block !important
        }

        .d-table {
            display: table !important
        }

        .d-table-row {
            display: table-row !important
        }

        .d-table-cell {
            display: table-cell !important
        }

        .d-flex {
            display: -webkit-box !important;
            display: -ms-flexbox !important;
            display: flex !important
        }

        .d-inline-flex {
            display: -webkit-inline-box !important;
            display: -ms-inline-flexbox !important;
            display: inline-flex !important
        }

        @media (min-width:576px) {
            .d-sm-none {
                display: none !important
            }

            .d-sm-inline {
                display: inline !important
            }

            .d-sm-inline-block {
                display: inline-block !important
            }

            .d-sm-block {
                display: block !important
            }

            .d-sm-table {
                display: table !important
            }

            .d-sm-table-row {
                display: table-row !important
            }

            .d-sm-table-cell {
                display: table-cell !important
            }

            .d-sm-flex {
                display: -webkit-box !important;
                display: -ms-flexbox !important;
                display: flex !important
            }

            .d-sm-inline-flex {
                display: -webkit-inline-box !important;
                display: -ms-inline-flexbox !important;
                display: inline-flex !important
            }
        }

        @media (min-width:768px) {
            .d-md-none {
                display: none !important
            }

            .d-md-inline {
                display: inline !important
            }

            .d-md-inline-block {
                display: inline-block !important
            }

            .d-md-block {
                display: block !important
            }

            .d-md-table {
                display: table !important
            }

            .d-md-table-row {
                display: table-row !important
            }

            .d-md-table-cell {
                display: table-cell !important
            }

            .d-md-flex {
                display: -webkit-box !important;
                display: -ms-flexbox !important;
                display: flex !important
            }

            .d-md-inline-flex {
                display: -webkit-inline-box !important;
                display: -ms-inline-flexbox !important;
                display: inline-flex !important
            }
        }

        @media (min-width:992px) {
            .d-lg-none {
                display: none !important
            }

            .d-lg-inline {
                display: inline !important
            }

            .d-lg-inline-block {
                display: inline-block !important
            }

            .d-lg-block {
                display: block !important
            }

            .d-lg-table {
                display: table !important
            }

            .d-lg-table-row {
                display: table-row !important
            }

            .d-lg-table-cell {
                display: table-cell !important
            }

            .d-lg-flex {
                display: -webkit-box !important;
                display: -ms-flexbox !important;
                display: flex !important
            }

            .d-lg-inline-flex {
                display: -webkit-inline-box !important;
                display: -ms-inline-flexbox !important;
                display: inline-flex !important
            }
        }

        @media (min-width:1200px) {
            .d-xl-none {
                display: none !important
            }

            .d-xl-inline {
                display: inline !important
            }

            .d-xl-inline-block {
                display: inline-block !important
            }

            .d-xl-block {
                display: block !important
            }

            .d-xl-table {
                display: table !important
            }

            .d-xl-table-row {
                display: table-row !important
            }

            .d-xl-table-cell {
                display: table-cell !important
            }

            .d-xl-flex {
                display: -webkit-box !important;
                display: -ms-flexbox !important;
                display: flex !important
            }

            .d-xl-inline-flex {
                display: -webkit-inline-box !important;
                display: -ms-inline-flexbox !important;
                display: inline-flex !important
            }
        }

        @media print {
            .d-print-none {
                display: none !important
            }

            .d-print-inline {
                display: inline !important
            }

            .d-print-inline-block {
                display: inline-block !important
            }

            .d-print-block {
                display: block !important
            }

            .d-print-table {
                display: table !important
            }

            .d-print-table-row {
                display: table-row !important
            }

            .d-print-table-cell {
                display: table-cell !important
            }

            .d-print-flex {
                display: -webkit-box !important;
                display: -ms-flexbox !important;
                display: flex !important
            }

            .d-print-inline-flex {
                display: -webkit-inline-box !important;
                display: -ms-inline-flexbox !important;
                display: inline-flex !important
            }
        }

        .embed-responsive {
            position: relative;
            display: block;
            width: 100%;
            padding: 0;
            overflow: hidden
        }

            .embed-responsive::before {
                display: block;
                content: \""\""
            }

            .embed-responsive .embed-responsive-item, .embed-responsive embed, .embed-responsive iframe, .embed-responsive object, .embed-responsive video {
                position: absolute;
                top: 0;
                bottom: 0;
                left: 0;
                width: 100%;
                height: 100%;
                border: 0
            }

        .embed-responsive-21by9::before {
            padding-top: 42.857143%
        }

        .embed-responsive-16by9::before {
            padding-top: 56.25%
        }

        .embed-responsive-4by3::before {
            padding-top: 75%
        }

        .embed-responsive-1by1::before {
            padding-top: 100%
        }

        .flex-row {
            -webkit-box-orient: horizontal !important;
            -webkit-box-direction: normal !important;
            -ms-flex-direction: row !important;
            flex-direction: row !important
        }

        .flex-column {
            -webkit-box-orient: vertical !important;
            -webkit-box-direction: normal !important;
            -ms-flex-direction: column !important;
            flex-direction: column !important
        }

        .flex-row-reverse {
            -webkit-box-orient: horizontal !important;
            -webkit-box-direction: reverse !important;
            -ms-flex-direction: row-reverse !important;
            flex-direction: row-reverse !important
        }

        .flex-column-reverse {
            -webkit-box-orient: vertical !important;
            -webkit-box-direction: reverse !important;
            -ms-flex-direction: column-reverse !important;
            flex-direction: column-reverse !important
        }

        .flex-wrap {
            -ms-flex-wrap: wrap !important;
            flex-wrap: wrap !important
        }

        .flex-nowrap {
            -ms-flex-wrap: nowrap !important;
            flex-wrap: nowrap !important
        }

        .flex-wrap-reverse {
            -ms-flex-wrap: wrap-reverse !important;
            flex-wrap: wrap-reverse !important
        }

        .justify-content-start {
            -webkit-box-pack: start !important;
            -ms-flex-pack: start !important;
            justify-content: flex-start !important
        }

        .justify-content-end {
            -webkit-box-pack: end !important;
            -ms-flex-pack: end !important;
            justify-content: flex-end !important
        }

        .justify-content-center {
            -webkit-box-pack: center !important;
            -ms-flex-pack: center !important;
            justify-content: center !important
        }

        .justify-content-between {
            -webkit-box-pack: justify !important;
            -ms-flex-pack: justify !important;
            justify-content: space-between !important
        }

        .justify-content-around {
            -ms-flex-pack: distribute !important;
            justify-content: space-around !important
        }

        .align-items-start {
            -webkit-box-align: start !important;
            -ms-flex-align: start !important;
            align-items: flex-start !important
        }

        .align-items-end {
            -webkit-box-align: end !important;
            -ms-flex-align: end !important;
            align-items: flex-end !important
        }

        .align-items-center {
            -webkit-box-align: center !important;
            -ms-flex-align: center !important;
            align-items: center !important
        }

        .align-items-baseline {
            -webkit-box-align: baseline !important;
            -ms-flex-align: baseline !important;
            align-items: baseline !important
        }

        .align-items-stretch {
            -webkit-box-align: stretch !important;
            -ms-flex-align: stretch !important;
            align-items: stretch !important
        }

        .align-content-start {
            -ms-flex-line-pack: start !important;
            align-content: flex-start !important
        }

        .align-content-end {
            -ms-flex-line-pack: end !important;
            align-content: flex-end !important
        }

        .align-content-center {
            -ms-flex-line-pack: center !important;
            align-content: center !important
        }

        .align-content-between {
            -ms-flex-line-pack: justify !important;
            align-content: space-between !important
        }

        .align-content-around {
            -ms-flex-line-pack: distribute !important;
            align-content: space-around !important
        }

        .align-content-stretch {
            -ms-flex-line-pack: stretch !important;
            align-content: stretch !important
        }

        .align-self-auto {
            -ms-flex-item-align: auto !important;
            align-self: auto !important
        }

        .align-self-start {
            -ms-flex-item-align: start !important;
            align-self: flex-start !important
        }

        .align-self-end {
            -ms-flex-item-align: end !important;
            align-self: flex-end !important
        }

        .align-self-center {
            -ms-flex-item-align: center !important;
            align-self: center !important
        }

        .align-self-baseline {
            -ms-flex-item-align: baseline !important;
            align-self: baseline !important
        }

        .align-self-stretch {
            -ms-flex-item-align: stretch !important;
            align-self: stretch !important
        }

        @media (min-width:576px) {
            .flex-sm-row {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: row !important;
                flex-direction: row !important
            }

            .flex-sm-column {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: column !important;
                flex-direction: column !important
            }

            .flex-sm-row-reverse {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: row-reverse !important;
                flex-direction: row-reverse !important
            }

            .flex-sm-column-reverse {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: column-reverse !important;
                flex-direction: column-reverse !important
            }

            .flex-sm-wrap {
                -ms-flex-wrap: wrap !important;
                flex-wrap: wrap !important
            }

            .flex-sm-nowrap {
                -ms-flex-wrap: nowrap !important;
                flex-wrap: nowrap !important
            }

            .flex-sm-wrap-reverse {
                -ms-flex-wrap: wrap-reverse !important;
                flex-wrap: wrap-reverse !important
            }

            .justify-content-sm-start {
                -webkit-box-pack: start !important;
                -ms-flex-pack: start !important;
                justify-content: flex-start !important
            }

            .justify-content-sm-end {
                -webkit-box-pack: end !important;
                -ms-flex-pack: end !important;
                justify-content: flex-end !important
            }

            .justify-content-sm-center {
                -webkit-box-pack: center !important;
                -ms-flex-pack: center !important;
                justify-content: center !important
            }

            .justify-content-sm-between {
                -webkit-box-pack: justify !important;
                -ms-flex-pack: justify !important;
                justify-content: space-between !important
            }

            .justify-content-sm-around {
                -ms-flex-pack: distribute !important;
                justify-content: space-around !important
            }

            .align-items-sm-start {
                -webkit-box-align: start !important;
                -ms-flex-align: start !important;
                align-items: flex-start !important
            }

            .align-items-sm-end {
                -webkit-box-align: end !important;
                -ms-flex-align: end !important;
                align-items: flex-end !important
            }

            .align-items-sm-center {
                -webkit-box-align: center !important;
                -ms-flex-align: center !important;
                align-items: center !important
            }

            .align-items-sm-baseline {
                -webkit-box-align: baseline !important;
                -ms-flex-align: baseline !important;
                align-items: baseline !important
            }

            .align-items-sm-stretch {
                -webkit-box-align: stretch !important;
                -ms-flex-align: stretch !important;
                align-items: stretch !important
            }

            .align-content-sm-start {
                -ms-flex-line-pack: start !important;
                align-content: flex-start !important
            }

            .align-content-sm-end {
                -ms-flex-line-pack: end !important;
                align-content: flex-end !important
            }

            .align-content-sm-center {
                -ms-flex-line-pack: center !important;
                align-content: center !important
            }

            .align-content-sm-between {
                -ms-flex-line-pack: justify !important;
                align-content: space-between !important
            }

            .align-content-sm-around {
                -ms-flex-line-pack: distribute !important;
                align-content: space-around !important
            }

            .align-content-sm-stretch {
                -ms-flex-line-pack: stretch !important;
                align-content: stretch !important
            }

            .align-self-sm-auto {
                -ms-flex-item-align: auto !important;
                align-self: auto !important
            }

            .align-self-sm-start {
                -ms-flex-item-align: start !important;
                align-self: flex-start !important
            }

            .align-self-sm-end {
                -ms-flex-item-align: end !important;
                align-self: flex-end !important
            }

            .align-self-sm-center {
                -ms-flex-item-align: center !important;
                align-self: center !important
            }

            .align-self-sm-baseline {
                -ms-flex-item-align: baseline !important;
                align-self: baseline !important
            }

            .align-self-sm-stretch {
                -ms-flex-item-align: stretch !important;
                align-self: stretch !important
            }
        }

        @media (min-width:768px) {
            .flex-md-row {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: row !important;
                flex-direction: row !important
            }

            .flex-md-column {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: column !important;
                flex-direction: column !important
            }

            .flex-md-row-reverse {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: row-reverse !important;
                flex-direction: row-reverse !important
            }

            .flex-md-column-reverse {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: column-reverse !important;
                flex-direction: column-reverse !important
            }

            .flex-md-wrap {
                -ms-flex-wrap: wrap !important;
                flex-wrap: wrap !important
            }

            .flex-md-nowrap {
                -ms-flex-wrap: nowrap !important;
                flex-wrap: nowrap !important
            }

            .flex-md-wrap-reverse {
                -ms-flex-wrap: wrap-reverse !important;
                flex-wrap: wrap-reverse !important
            }

            .justify-content-md-start {
                -webkit-box-pack: start !important;
                -ms-flex-pack: start !important;
                justify-content: flex-start !important
            }

            .justify-content-md-end {
                -webkit-box-pack: end !important;
                -ms-flex-pack: end !important;
                justify-content: flex-end !important
            }

            .justify-content-md-center {
                -webkit-box-pack: center !important;
                -ms-flex-pack: center !important;
                justify-content: center !important
            }

            .justify-content-md-between {
                -webkit-box-pack: justify !important;
                -ms-flex-pack: justify !important;
                justify-content: space-between !important
            }

            .justify-content-md-around {
                -ms-flex-pack: distribute !important;
                justify-content: space-around !important
            }

            .align-items-md-start {
                -webkit-box-align: start !important;
                -ms-flex-align: start !important;
                align-items: flex-start !important
            }

            .align-items-md-end {
                -webkit-box-align: end !important;
                -ms-flex-align: end !important;
                align-items: flex-end !important
            }

            .align-items-md-center {
                -webkit-box-align: center !important;
                -ms-flex-align: center !important;
                align-items: center !important
            }

            .align-items-md-baseline {
                -webkit-box-align: baseline !important;
                -ms-flex-align: baseline !important;
                align-items: baseline !important
            }

            .align-items-md-stretch {
                -webkit-box-align: stretch !important;
                -ms-flex-align: stretch !important;
                align-items: stretch !important
            }

            .align-content-md-start {
                -ms-flex-line-pack: start !important;
                align-content: flex-start !important
            }

            .align-content-md-end {
                -ms-flex-line-pack: end !important;
                align-content: flex-end !important
            }

            .align-content-md-center {
                -ms-flex-line-pack: center !important;
                align-content: center !important
            }

            .align-content-md-between {
                -ms-flex-line-pack: justify !important;
                align-content: space-between !important
            }

            .align-content-md-around {
                -ms-flex-line-pack: distribute !important;
                align-content: space-around !important
            }

            .align-content-md-stretch {
                -ms-flex-line-pack: stretch !important;
                align-content: stretch !important
            }

            .align-self-md-auto {
                -ms-flex-item-align: auto !important;
                align-self: auto !important
            }

            .align-self-md-start {
                -ms-flex-item-align: start !important;
                align-self: flex-start !important
            }

            .align-self-md-end {
                -ms-flex-item-align: end !important;
                align-self: flex-end !important
            }

            .align-self-md-center {
                -ms-flex-item-align: center !important;
                align-self: center !important
            }

            .align-self-md-baseline {
                -ms-flex-item-align: baseline !important;
                align-self: baseline !important
            }

            .align-self-md-stretch {
                -ms-flex-item-align: stretch !important;
                align-self: stretch !important
            }
        }

        @media (min-width:992px) {
            .flex-lg-row {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: row !important;
                flex-direction: row !important
            }

            .flex-lg-column {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: column !important;
                flex-direction: column !important
            }

            .flex-lg-row-reverse {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: row-reverse !important;
                flex-direction: row-reverse !important
            }

            .flex-lg-column-reverse {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: column-reverse !important;
                flex-direction: column-reverse !important
            }

            .flex-lg-wrap {
                -ms-flex-wrap: wrap !important;
                flex-wrap: wrap !important
            }

            .flex-lg-nowrap {
                -ms-flex-wrap: nowrap !important;
                flex-wrap: nowrap !important
            }

            .flex-lg-wrap-reverse {
                -ms-flex-wrap: wrap-reverse !important;
                flex-wrap: wrap-reverse !important
            }

            .justify-content-lg-start {
                -webkit-box-pack: start !important;
                -ms-flex-pack: start !important;
                justify-content: flex-start !important
            }

            .justify-content-lg-end {
                -webkit-box-pack: end !important;
                -ms-flex-pack: end !important;
                justify-content: flex-end !important
            }

            .justify-content-lg-center {
                -webkit-box-pack: center !important;
                -ms-flex-pack: center !important;
                justify-content: center !important
            }

            .justify-content-lg-between {
                -webkit-box-pack: justify !important;
                -ms-flex-pack: justify !important;
                justify-content: space-between !important
            }

            .justify-content-lg-around {
                -ms-flex-pack: distribute !important;
                justify-content: space-around !important
            }

            .align-items-lg-start {
                -webkit-box-align: start !important;
                -ms-flex-align: start !important;
                align-items: flex-start !important
            }

            .align-items-lg-end {
                -webkit-box-align: end !important;
                -ms-flex-align: end !important;
                align-items: flex-end !important
            }

            .align-items-lg-center {
                -webkit-box-align: center !important;
                -ms-flex-align: center !important;
                align-items: center !important
            }

            .align-items-lg-baseline {
                -webkit-box-align: baseline !important;
                -ms-flex-align: baseline !important;
                align-items: baseline !important
            }

            .align-items-lg-stretch {
                -webkit-box-align: stretch !important;
                -ms-flex-align: stretch !important;
                align-items: stretch !important
            }

            .align-content-lg-start {
                -ms-flex-line-pack: start !important;
                align-content: flex-start !important
            }

            .align-content-lg-end {
                -ms-flex-line-pack: end !important;
                align-content: flex-end !important
            }

            .align-content-lg-center {
                -ms-flex-line-pack: center !important;
                align-content: center !important
            }

            .align-content-lg-between {
                -ms-flex-line-pack: justify !important;
                align-content: space-between !important
            }

            .align-content-lg-around {
                -ms-flex-line-pack: distribute !important;
                align-content: space-around !important
            }

            .align-content-lg-stretch {
                -ms-flex-line-pack: stretch !important;
                align-content: stretch !important
            }

            .align-self-lg-auto {
                -ms-flex-item-align: auto !important;
                align-self: auto !important
            }

            .align-self-lg-start {
                -ms-flex-item-align: start !important;
                align-self: flex-start !important
            }

            .align-self-lg-end {
                -ms-flex-item-align: end !important;
                align-self: flex-end !important
            }

            .align-self-lg-center {
                -ms-flex-item-align: center !important;
                align-self: center !important
            }

            .align-self-lg-baseline {
                -ms-flex-item-align: baseline !important;
                align-self: baseline !important
            }

            .align-self-lg-stretch {
                -ms-flex-item-align: stretch !important;
                align-self: stretch !important
            }
        }

        @media (min-width:1200px) {
            .flex-xl-row {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: row !important;
                flex-direction: row !important
            }

            .flex-xl-column {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: normal !important;
                -ms-flex-direction: column !important;
                flex-direction: column !important
            }

            .flex-xl-row-reverse {
                -webkit-box-orient: horizontal !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: row-reverse !important;
                flex-direction: row-reverse !important
            }

            .flex-xl-column-reverse {
                -webkit-box-orient: vertical !important;
                -webkit-box-direction: reverse !important;
                -ms-flex-direction: column-reverse !important;
                flex-direction: column-reverse !important
            }

            .flex-xl-wrap {
                -ms-flex-wrap: wrap !important;
                flex-wrap: wrap !important
            }

            .flex-xl-nowrap {
                -ms-flex-wrap: nowrap !important;
                flex-wrap: nowrap !important
            }

            .flex-xl-wrap-reverse {
                -ms-flex-wrap: wrap-reverse !important;
                flex-wrap: wrap-reverse !important
            }

            .justify-content-xl-start {
                -webkit-box-pack: start !important;
                -ms-flex-pack: start !important;
                justify-content: flex-start !important
            }

            .justify-content-xl-end {
                -webkit-box-pack: end !important;
                -ms-flex-pack: end !important;
                justify-content: flex-end !important
            }

            .justify-content-xl-center {
                -webkit-box-pack: center !important;
                -ms-flex-pack: center !important;
                justify-content: center !important
            }

            .justify-content-xl-between {
                -webkit-box-pack: justify !important;
                -ms-flex-pack: justify !important;
                justify-content: space-between !important
            }

            .justify-content-xl-around {
                -ms-flex-pack: distribute !important;
                justify-content: space-around !important
            }

            .align-items-xl-start {
                -webkit-box-align: start !important;
                -ms-flex-align: start !important;
                align-items: flex-start !important
            }

            .align-items-xl-end {
                -webkit-box-align: end !important;
                -ms-flex-align: end !important;
                align-items: flex-end !important
            }

            .align-items-xl-center {
                -webkit-box-align: center !important;
                -ms-flex-align: center !important;
                align-items: center !important
            }

            .align-items-xl-baseline {
                -webkit-box-align: baseline !important;
                -ms-flex-align: baseline !important;
                align-items: baseline !important
            }

            .align-items-xl-stretch {
                -webkit-box-align: stretch !important;
                -ms-flex-align: stretch !important;
                align-items: stretch !important
            }

            .align-content-xl-start {
                -ms-flex-line-pack: start !important;
                align-content: flex-start !important
            }

            .align-content-xl-end {
                -ms-flex-line-pack: end !important;
                align-content: flex-end !important
            }

            .align-content-xl-center {
                -ms-flex-line-pack: center !important;
                align-content: center !important
            }

            .align-content-xl-between {
                -ms-flex-line-pack: justify !important;
                align-content: space-between !important
            }

            .align-content-xl-around {
                -ms-flex-line-pack: distribute !important;
                align-content: space-around !important
            }

            .align-content-xl-stretch {
                -ms-flex-line-pack: stretch !important;
                align-content: stretch !important
            }

            .align-self-xl-auto {
                -ms-flex-item-align: auto !important;
                align-self: auto !important
            }

            .align-self-xl-start {
                -ms-flex-item-align: start !important;
                align-self: flex-start !important
            }

            .align-self-xl-end {
                -ms-flex-item-align: end !important;
                align-self: flex-end !important
            }

            .align-self-xl-center {
                -ms-flex-item-align: center !important;
                align-self: center !important
            }

            .align-self-xl-baseline {
                -ms-flex-item-align: baseline !important;
                align-self: baseline !important
            }

            .align-self-xl-stretch {
                -ms-flex-item-align: stretch !important;
                align-self: stretch !important
            }
        }

        .float-left {
            float: left !important
        }

        .float-right {
            float: right !important
        }

        .float-none {
            float: none !important
        }

        @media (min-width:576px) {
            .float-sm-left {
                float: left !important
            }

            .float-sm-right {
                float: right !important
            }

            .float-sm-none {
                float: none !important
            }
        }

        @media (min-width:768px) {
            .float-md-left {
                float: left !important
            }

            .float-md-right {
                float: right !important
            }

            .float-md-none {
                float: none !important
            }
        }

        @media (min-width:992px) {
            .float-lg-left {
                float: left !important
            }

            .float-lg-right {
                float: right !important
            }

            .float-lg-none {
                float: none !important
            }
        }

        @media (min-width:1200px) {
            .float-xl-left {
                float: left !important
            }

            .float-xl-right {
                float: right !important
            }

            .float-xl-none {
                float: none !important
            }
        }

        .position-static {
            position: static !important
        }

        .position-relative {
            position: relative !important
        }

        .position-absolute {
            position: absolute !important
        }

        .position-fixed {
            position: fixed !important
        }

        .position-sticky {
            position: -webkit-sticky !important;
            position: sticky !important
        }

        .fixed-top {
            position: fixed;
            top: 0;
            right: 0;
            left: 0;
            z-index: 1030
        }

        .fixed-bottom {
            position: fixed;
            right: 0;
            bottom: 0;
            left: 0;
            z-index: 1030
        }

        @supports ((position:-webkit-sticky) or (position:sticky)) {
            .sticky-top {
                position: -webkit-sticky;
                position: sticky;
                top: 0;
                z-index: 1020
            }
        }

        .sr-only {
            position: absolute;
            width: 1px;
            height: 1px;
            padding: 0;
            overflow: hidden;
            clip: rect(0,0,0,0);
            white-space: nowrap;
            -webkit-clip-path: inset(50%);
            clip-path: inset(50%);
            border: 0
        }

        .sr-only-focusable:active, .sr-only-focusable:focus {
            position: static;
            width: auto;
            height: auto;
            overflow: visible;
            clip: auto;
            white-space: normal;
            -webkit-clip-path: none;
            clip-path: none
        }

        .w-25 {
            width: 25% !important
        }

        .w-50 {
            width: 50% !important
        }

        .w-75 {
            width: 75% !important
        }

        .w-100 {
            width: 100% !important
        }

        .h-25 {
            height: 25% !important
        }

        .h-50 {
            height: 50% !important
        }

        .h-75 {
            height: 75% !important
        }

        .h-100 {
            height: 100% !important
        }

        .mw-100 {
            max-width: 100% !important
        }

        .mh-100 {
            max-height: 100% !important
        }

        .m-0 {
            margin: 0 !important
        }

        .mt-0, .my-0 {
            margin-top: 0 !important
        }

        .mr-0, .mx-0 {
            margin-right: 0 !important
        }

        .mb-0, .my-0 {
            margin-bottom: 0 !important
        }

        .ml-0, .mx-0 {
            margin-left: 0 !important
        }

        .m-1 {
            margin: .25rem !important
        }

        .mt-1, .my-1 {
            margin-top: .25rem !important
        }

        .mr-1, .mx-1 {
            margin-right: .25rem !important
        }

        .mb-1, .my-1 {
            margin-bottom: .25rem !important
        }

        .ml-1, .mx-1 {
            margin-left: .25rem !important
        }

        .m-2 {
            margin: .5rem !important
        }

        .mt-2, .my-2 {
            margin-top: .5rem !important
        }

        .mr-2, .mx-2 {
            margin-right: .5rem !important
        }

        .mb-2, .my-2 {
            margin-bottom: .5rem !important
        }

        .ml-2, .mx-2 {
            margin-left: .5rem !important
        }

        .m-3 {
            margin: 1rem !important
        }

        .mt-3, .my-3 {
            margin-top: 1rem !important
        }

        .mr-3, .mx-3 {
            margin-right: 1rem !important
        }

        .mb-3, .my-3 {
            margin-bottom: 1rem !important
        }

        .ml-3, .mx-3 {
            margin-left: 1rem !important
        }

        .m-4 {
            margin: 1.5rem !important
        }

        .mt-4, .my-4 {
            margin-top: 1.5rem !important
        }

        .mr-4, .mx-4 {
            margin-right: 1.5rem !important
        }

        .mb-4, .my-4 {
            margin-bottom: 1.5rem !important
        }

        .ml-4, .mx-4 {
            margin-left: 1.5rem !important
        }

        .m-5 {
            margin: 3rem !important
        }

        .mt-5, .my-5 {
            margin-top: 3rem !important
        }

        .mr-5, .mx-5 {
            margin-right: 3rem !important
        }

        .mb-5, .my-5 {
            margin-bottom: 3rem !important
        }

        .ml-5, .mx-5 {
            margin-left: 3rem !important
        }

        .p-0 {
            padding: 0 !important
        }

        .pt-0, .py-0 {
            padding-top: 0 !important
        }

        .pr-0, .px-0 {
            padding-right: 0 !important
        }

        .pb-0, .py-0 {
            padding-bottom: 0 !important
        }

        .pl-0, .px-0 {
            padding-left: 0 !important
        }

        .p-1 {
            padding: .25rem !important
        }

        .pt-1, .py-1 {
            padding-top: .25rem !important
        }

        .pr-1, .px-1 {
            padding-right: .25rem !important
        }

        .pb-1, .py-1 {
            padding-bottom: .25rem !important
        }

        .pl-1, .px-1 {
            padding-left: .25rem !important
        }

        .p-2 {
            padding: .5rem !important
        }

        .pt-2, .py-2 {
            padding-top: .5rem !important
        }

        .pr-2, .px-2 {
            padding-right: .5rem !important
        }

        .pb-2, .py-2 {
            padding-bottom: .5rem !important
        }

        .pl-2, .px-2 {
            padding-left: .5rem !important
        }

        .p-3 {
            padding: 1rem !important
        }

        .pt-3, .py-3 {
            padding-top: 1rem !important
        }

        .pr-3, .px-3 {
            padding-right: 1rem !important
        }

        .pb-3, .py-3 {
            padding-bottom: 1rem !important
        }

        .pl-3, .px-3 {
            padding-left: 1rem !important
        }

        .p-4 {
            padding: 1.5rem !important
        }

        .pt-4, .py-4 {
            padding-top: 1.5rem !important
        }

        .pr-4, .px-4 {
            padding-right: 1.5rem !important
        }

        .pb-4, .py-4 {
            padding-bottom: 1.5rem !important
        }

        .pl-4, .px-4 {
            padding-left: 1.5rem !important
        }

        .p-5 {
            padding: 3rem !important
        }

        .pt-5, .py-5 {
            padding-top: 3rem !important
        }

        .pr-5, .px-5 {
            padding-right: 3rem !important
        }

        .pb-5, .py-5 {
            padding-bottom: 3rem !important
        }

        .pl-5, .px-5 {
            padding-left: 3rem !important
        }

        .m-auto {
            margin: auto !important
        }

        .mt-auto, .my-auto {
            margin-top: auto !important
        }

        .mr-auto, .mx-auto {
            margin-right: auto !important
        }

        .mb-auto, .my-auto {
            margin-bottom: auto !important
        }

        .ml-auto, .mx-auto {
            margin-left: auto !important
        }

        @media (min-width:576px) {
            .m-sm-0 {
                margin: 0 !important
            }

            .mt-sm-0, .my-sm-0 {
                margin-top: 0 !important
            }

            .mr-sm-0, .mx-sm-0 {
                margin-right: 0 !important
            }

            .mb-sm-0, .my-sm-0 {
                margin-bottom: 0 !important
            }

            .ml-sm-0, .mx-sm-0 {
                margin-left: 0 !important
            }

            .m-sm-1 {
                margin: .25rem !important
            }

            .mt-sm-1, .my-sm-1 {
                margin-top: .25rem !important
            }

            .mr-sm-1, .mx-sm-1 {
                margin-right: .25rem !important
            }

            .mb-sm-1, .my-sm-1 {
                margin-bottom: .25rem !important
            }

            .ml-sm-1, .mx-sm-1 {
                margin-left: .25rem !important
            }

            .m-sm-2 {
                margin: .5rem !important
            }

            .mt-sm-2, .my-sm-2 {
                margin-top: .5rem !important
            }

            .mr-sm-2, .mx-sm-2 {
                margin-right: .5rem !important
            }

            .mb-sm-2, .my-sm-2 {
                margin-bottom: .5rem !important
            }

            .ml-sm-2, .mx-sm-2 {
                margin-left: .5rem !important
            }

            .m-sm-3 {
                margin: 1rem !important
            }

            .mt-sm-3, .my-sm-3 {
                margin-top: 1rem !important
            }

            .mr-sm-3, .mx-sm-3 {
                margin-right: 1rem !important
            }

            .mb-sm-3, .my-sm-3 {
                margin-bottom: 1rem !important
            }

            .ml-sm-3, .mx-sm-3 {
                margin-left: 1rem !important
            }

            .m-sm-4 {
                margin: 1.5rem !important
            }

            .mt-sm-4, .my-sm-4 {
                margin-top: 1.5rem !important
            }

            .mr-sm-4, .mx-sm-4 {
                margin-right: 1.5rem !important
            }

            .mb-sm-4, .my-sm-4 {
                margin-bottom: 1.5rem !important
            }

            .ml-sm-4, .mx-sm-4 {
                margin-left: 1.5rem !important
            }

            .m-sm-5 {
                margin: 3rem !important
            }

            .mt-sm-5, .my-sm-5 {
                margin-top: 3rem !important
            }

            .mr-sm-5, .mx-sm-5 {
                margin-right: 3rem !important
            }

            .mb-sm-5, .my-sm-5 {
                margin-bottom: 3rem !important
            }

            .ml-sm-5, .mx-sm-5 {
                margin-left: 3rem !important
            }

            .p-sm-0 {
                padding: 0 !important
            }

            .pt-sm-0, .py-sm-0 {
                padding-top: 0 !important
            }

            .pr-sm-0, .px-sm-0 {
                padding-right: 0 !important
            }

            .pb-sm-0, .py-sm-0 {
                padding-bottom: 0 !important
            }

            .pl-sm-0, .px-sm-0 {
                padding-left: 0 !important
            }

            .p-sm-1 {
                padding: .25rem !important
            }

            .pt-sm-1, .py-sm-1 {
                padding-top: .25rem !important
            }

            .pr-sm-1, .px-sm-1 {
                padding-right: .25rem !important
            }

            .pb-sm-1, .py-sm-1 {
                padding-bottom: .25rem !important
            }

            .pl-sm-1, .px-sm-1 {
                padding-left: .25rem !important
            }

            .p-sm-2 {
                padding: .5rem !important
            }

            .pt-sm-2, .py-sm-2 {
                padding-top: .5rem !important
            }

            .pr-sm-2, .px-sm-2 {
                padding-right: .5rem !important
            }

            .pb-sm-2, .py-sm-2 {
                padding-bottom: .5rem !important
            }

            .pl-sm-2, .px-sm-2 {
                padding-left: .5rem !important
            }

            .p-sm-3 {
                padding: 1rem !important
            }

            .pt-sm-3, .py-sm-3 {
                padding-top: 1rem !important
            }

            .pr-sm-3, .px-sm-3 {
                padding-right: 1rem !important
            }

            .pb-sm-3, .py-sm-3 {
                padding-bottom: 1rem !important
            }

            .pl-sm-3, .px-sm-3 {
                padding-left: 1rem !important
            }

            .p-sm-4 {
                padding: 1.5rem !important
            }

            .pt-sm-4, .py-sm-4 {
                padding-top: 1.5rem !important
            }

            .pr-sm-4, .px-sm-4 {
                padding-right: 1.5rem !important
            }

            .pb-sm-4, .py-sm-4 {
                padding-bottom: 1.5rem !important
            }

            .pl-sm-4, .px-sm-4 {
                padding-left: 1.5rem !important
            }

            .p-sm-5 {
                padding: 3rem !important
            }

            .pt-sm-5, .py-sm-5 {
                padding-top: 3rem !important
            }

            .pr-sm-5, .px-sm-5 {
                padding-right: 3rem !important
            }

            .pb-sm-5, .py-sm-5 {
                padding-bottom: 3rem !important
            }

            .pl-sm-5, .px-sm-5 {
                padding-left: 3rem !important
            }

            .m-sm-auto {
                margin: auto !important
            }

            .mt-sm-auto, .my-sm-auto {
                margin-top: auto !important
            }

            .mr-sm-auto, .mx-sm-auto {
                margin-right: auto !important
            }

            .mb-sm-auto, .my-sm-auto {
                margin-bottom: auto !important
            }

            .ml-sm-auto, .mx-sm-auto {
                margin-left: auto !important
            }
        }

        @media (min-width:768px) {
            .m-md-0 {
                margin: 0 !important
            }

            .mt-md-0, .my-md-0 {
                margin-top: 0 !important
            }

            .mr-md-0, .mx-md-0 {
                margin-right: 0 !important
            }

            .mb-md-0, .my-md-0 {
                margin-bottom: 0 !important
            }

            .ml-md-0, .mx-md-0 {
                margin-left: 0 !important
            }

            .m-md-1 {
                margin: .25rem !important
            }

            .mt-md-1, .my-md-1 {
                margin-top: .25rem !important
            }

            .mr-md-1, .mx-md-1 {
                margin-right: .25rem !important
            }

            .mb-md-1, .my-md-1 {
                margin-bottom: .25rem !important
            }

            .ml-md-1, .mx-md-1 {
                margin-left: .25rem !important
            }

            .m-md-2 {
                margin: .5rem !important
            }

            .mt-md-2, .my-md-2 {
                margin-top: .5rem !important
            }

            .mr-md-2, .mx-md-2 {
                margin-right: .5rem !important
            }

            .mb-md-2, .my-md-2 {
                margin-bottom: .5rem !important
            }

            .ml-md-2, .mx-md-2 {
                margin-left: .5rem !important
            }

            .m-md-3 {
                margin: 1rem !important
            }

            .mt-md-3, .my-md-3 {
                margin-top: 1rem !important
            }

            .mr-md-3, .mx-md-3 {
                margin-right: 1rem !important
            }

            .mb-md-3, .my-md-3 {
                margin-bottom: 1rem !important
            }

            .ml-md-3, .mx-md-3 {
                margin-left: 1rem !important
            }

            .m-md-4 {
                margin: 1.5rem !important
            }

            .mt-md-4, .my-md-4 {
                margin-top: 1.5rem !important
            }

            .mr-md-4, .mx-md-4 {
                margin-right: 1.5rem !important
            }

            .mb-md-4, .my-md-4 {
                margin-bottom: 1.5rem !important
            }

            .ml-md-4, .mx-md-4 {
                margin-left: 1.5rem !important
            }

            .m-md-5 {
                margin: 3rem !important
            }

            .mt-md-5, .my-md-5 {
                margin-top: 3rem !important
            }

            .mr-md-5, .mx-md-5 {
                margin-right: 3rem !important
            }

            .mb-md-5, .my-md-5 {
                margin-bottom: 3rem !important
            }

            .ml-md-5, .mx-md-5 {
                margin-left: 3rem !important
            }

            .p-md-0 {
                padding: 0 !important
            }

            .pt-md-0, .py-md-0 {
                padding-top: 0 !important
            }

            .pr-md-0, .px-md-0 {
                padding-right: 0 !important
            }

            .pb-md-0, .py-md-0 {
                padding-bottom: 0 !important
            }

            .pl-md-0, .px-md-0 {
                padding-left: 0 !important
            }

            .p-md-1 {
                padding: .25rem !important
            }

            .pt-md-1, .py-md-1 {
                padding-top: .25rem !important
            }

            .pr-md-1, .px-md-1 {
                padding-right: .25rem !important
            }

            .pb-md-1, .py-md-1 {
                padding-bottom: .25rem !important
            }

            .pl-md-1, .px-md-1 {
                padding-left: .25rem !important
            }

            .p-md-2 {
                padding: .5rem !important
            }

            .pt-md-2, .py-md-2 {
                padding-top: .5rem !important
            }

            .pr-md-2, .px-md-2 {
                padding-right: .5rem !important
            }

            .pb-md-2, .py-md-2 {
                padding-bottom: .5rem !important
            }

            .pl-md-2, .px-md-2 {
                padding-left: .5rem !important
            }

            .p-md-3 {
                padding: 1rem !important
            }

            .pt-md-3, .py-md-3 {
                padding-top: 1rem !important
            }

            .pr-md-3, .px-md-3 {
                padding-right: 1rem !important
            }

            .pb-md-3, .py-md-3 {
                padding-bottom: 1rem !important
            }

            .pl-md-3, .px-md-3 {
                padding-left: 1rem !important
            }

            .p-md-4 {
                padding: 1.5rem !important
            }

            .pt-md-4, .py-md-4 {
                padding-top: 1.5rem !important
            }

            .pr-md-4, .px-md-4 {
                padding-right: 1.5rem !important
            }

            .pb-md-4, .py-md-4 {
                padding-bottom: 1.5rem !important
            }

            .pl-md-4, .px-md-4 {
                padding-left: 1.5rem !important
            }

            .p-md-5 {
                padding: 3rem !important
            }

            .pt-md-5, .py-md-5 {
                padding-top: 3rem !important
            }

            .pr-md-5, .px-md-5 {
                padding-right: 3rem !important
            }

            .pb-md-5, .py-md-5 {
                padding-bottom: 3rem !important
            }

            .pl-md-5, .px-md-5 {
                padding-left: 3rem !important
            }

            .m-md-auto {
                margin: auto !important
            }

            .mt-md-auto, .my-md-auto {
                margin-top: auto !important
            }

            .mr-md-auto, .mx-md-auto {
                margin-right: auto !important
            }

            .mb-md-auto, .my-md-auto {
                margin-bottom: auto !important
            }

            .ml-md-auto, .mx-md-auto {
                margin-left: auto !important
            }
        }

        @media (min-width:992px) {
            .m-lg-0 {
                margin: 0 !important
            }

            .mt-lg-0, .my-lg-0 {
                margin-top: 0 !important
            }

            .mr-lg-0, .mx-lg-0 {
                margin-right: 0 !important
            }

            .mb-lg-0, .my-lg-0 {
                margin-bottom: 0 !important
            }

            .ml-lg-0, .mx-lg-0 {
                margin-left: 0 !important
            }

            .m-lg-1 {
                margin: .25rem !important
            }

            .mt-lg-1, .my-lg-1 {
                margin-top: .25rem !important
            }

            .mr-lg-1, .mx-lg-1 {
                margin-right: .25rem !important
            }

            .mb-lg-1, .my-lg-1 {
                margin-bottom: .25rem !important
            }

            .ml-lg-1, .mx-lg-1 {
                margin-left: .25rem !important
            }

            .m-lg-2 {
                margin: .5rem !important
            }

            .mt-lg-2, .my-lg-2 {
                margin-top: .5rem !important
            }

            .mr-lg-2, .mx-lg-2 {
                margin-right: .5rem !important
            }

            .mb-lg-2, .my-lg-2 {
                margin-bottom: .5rem !important
            }

            .ml-lg-2, .mx-lg-2 {
                margin-left: .5rem !important
            }

            .m-lg-3 {
                margin: 1rem !important
            }

            .mt-lg-3, .my-lg-3 {
                margin-top: 1rem !important
            }

            .mr-lg-3, .mx-lg-3 {
                margin-right: 1rem !important
            }

            .mb-lg-3, .my-lg-3 {
                margin-bottom: 1rem !important
            }

            .ml-lg-3, .mx-lg-3 {
                margin-left: 1rem !important
            }

            .m-lg-4 {
                margin: 1.5rem !important
            }

            .mt-lg-4, .my-lg-4 {
                margin-top: 1.5rem !important
            }

            .mr-lg-4, .mx-lg-4 {
                margin-right: 1.5rem !important
            }

            .mb-lg-4, .my-lg-4 {
                margin-bottom: 1.5rem !important
            }

            .ml-lg-4, .mx-lg-4 {
                margin-left: 1.5rem !important
            }

            .m-lg-5 {
                margin: 3rem !important
            }

            .mt-lg-5, .my-lg-5 {
                margin-top: 3rem !important
            }

            .mr-lg-5, .mx-lg-5 {
                margin-right: 3rem !important
            }

            .mb-lg-5, .my-lg-5 {
                margin-bottom: 3rem !important
            }

            .ml-lg-5, .mx-lg-5 {
                margin-left: 3rem !important
            }

            .p-lg-0 {
                padding: 0 !important
            }

            .pt-lg-0, .py-lg-0 {
                padding-top: 0 !important
            }

            .pr-lg-0, .px-lg-0 {
                padding-right: 0 !important
            }

            .pb-lg-0, .py-lg-0 {
                padding-bottom: 0 !important
            }

            .pl-lg-0, .px-lg-0 {
                padding-left: 0 !important
            }

            .p-lg-1 {
                padding: .25rem !important
            }

            .pt-lg-1, .py-lg-1 {
                padding-top: .25rem !important
            }

            .pr-lg-1, .px-lg-1 {
                padding-right: .25rem !important
            }

            .pb-lg-1, .py-lg-1 {
                padding-bottom: .25rem !important
            }

            .pl-lg-1, .px-lg-1 {
                padding-left: .25rem !important
            }

            .p-lg-2 {
                padding: .5rem !important
            }

            .pt-lg-2, .py-lg-2 {
                padding-top: .5rem !important
            }

            .pr-lg-2, .px-lg-2 {
                padding-right: .5rem !important
            }

            .pb-lg-2, .py-lg-2 {
                padding-bottom: .5rem !important
            }

            .pl-lg-2, .px-lg-2 {
                padding-left: .5rem !important
            }

            .p-lg-3 {
                padding: 1rem !important
            }

            .pt-lg-3, .py-lg-3 {
                padding-top: 1rem !important
            }

            .pr-lg-3, .px-lg-3 {
                padding-right: 1rem !important
            }

            .pb-lg-3, .py-lg-3 {
                padding-bottom: 1rem !important
            }

            .pl-lg-3, .px-lg-3 {
                padding-left: 1rem !important
            }

            .p-lg-4 {
                padding: 1.5rem !important
            }

            .pt-lg-4, .py-lg-4 {
                padding-top: 1.5rem !important
            }

            .pr-lg-4, .px-lg-4 {
                padding-right: 1.5rem !important
            }

            .pb-lg-4, .py-lg-4 {
                padding-bottom: 1.5rem !important
            }

            .pl-lg-4, .px-lg-4 {
                padding-left: 1.5rem !important
            }

            .p-lg-5 {
                padding: 3rem !important
            }

            .pt-lg-5, .py-lg-5 {
                padding-top: 3rem !important
            }

            .pr-lg-5, .px-lg-5 {
                padding-right: 3rem !important
            }

            .pb-lg-5, .py-lg-5 {
                padding-bottom: 3rem !important
            }

            .pl-lg-5, .px-lg-5 {
                padding-left: 3rem !important
            }

            .m-lg-auto {
                margin: auto !important
            }

            .mt-lg-auto, .my-lg-auto {
                margin-top: auto !important
            }

            .mr-lg-auto, .mx-lg-auto {
                margin-right: auto !important
            }

            .mb-lg-auto, .my-lg-auto {
                margin-bottom: auto !important
            }

            .ml-lg-auto, .mx-lg-auto {
                margin-left: auto !important
            }
        }

        @media (min-width:1200px) {
            .m-xl-0 {
                margin: 0 !important
            }

            .mt-xl-0, .my-xl-0 {
                margin-top: 0 !important
            }

            .mr-xl-0, .mx-xl-0 {
                margin-right: 0 !important
            }

            .mb-xl-0, .my-xl-0 {
                margin-bottom: 0 !important
            }

            .ml-xl-0, .mx-xl-0 {
                margin-left: 0 !important
            }

            .m-xl-1 {
                margin: .25rem !important
            }

            .mt-xl-1, .my-xl-1 {
                margin-top: .25rem !important
            }

            .mr-xl-1, .mx-xl-1 {
                margin-right: .25rem !important
            }

            .mb-xl-1, .my-xl-1 {
                margin-bottom: .25rem !important
            }

            .ml-xl-1, .mx-xl-1 {
                margin-left: .25rem !important
            }

            .m-xl-2 {
                margin: .5rem !important
            }

            .mt-xl-2, .my-xl-2 {
                margin-top: .5rem !important
            }

            .mr-xl-2, .mx-xl-2 {
                margin-right: .5rem !important
            }

            .mb-xl-2, .my-xl-2 {
                margin-bottom: .5rem !important
            }

            .ml-xl-2, .mx-xl-2 {
                margin-left: .5rem !important
            }

            .m-xl-3 {
                margin: 1rem !important
            }

            .mt-xl-3, .my-xl-3 {
                margin-top: 1rem !important
            }

            .mr-xl-3, .mx-xl-3 {
                margin-right: 1rem !important
            }

            .mb-xl-3, .my-xl-3 {
                margin-bottom: 1rem !important
            }

            .ml-xl-3, .mx-xl-3 {
                margin-left: 1rem !important
            }

            .m-xl-4 {
                margin: 1.5rem !important
            }

            .mt-xl-4, .my-xl-4 {
                margin-top: 1.5rem !important
            }

            .mr-xl-4, .mx-xl-4 {
                margin-right: 1.5rem !important
            }

            .mb-xl-4, .my-xl-4 {
                margin-bottom: 1.5rem !important
            }

            .ml-xl-4, .mx-xl-4 {
                margin-left: 1.5rem !important
            }

            .m-xl-5 {
                margin: 3rem !important
            }

            .mt-xl-5, .my-xl-5 {
                margin-top: 3rem !important
            }

            .mr-xl-5, .mx-xl-5 {
                margin-right: 3rem !important
            }

            .mb-xl-5, .my-xl-5 {
                margin-bottom: 3rem !important
            }

            .ml-xl-5, .mx-xl-5 {
                margin-left: 3rem !important
            }

            .p-xl-0 {
                padding: 0 !important
            }

            .pt-xl-0, .py-xl-0 {
                padding-top: 0 !important
            }

            .pr-xl-0, .px-xl-0 {
                padding-right: 0 !important
            }

            .pb-xl-0, .py-xl-0 {
                padding-bottom: 0 !important
            }

            .pl-xl-0, .px-xl-0 {
                padding-left: 0 !important
            }

            .p-xl-1 {
                padding: .25rem !important
            }

            .pt-xl-1, .py-xl-1 {
                padding-top: .25rem !important
            }

            .pr-xl-1, .px-xl-1 {
                padding-right: .25rem !important
            }

            .pb-xl-1, .py-xl-1 {
                padding-bottom: .25rem !important
            }

            .pl-xl-1, .px-xl-1 {
                padding-left: .25rem !important
            }

            .p-xl-2 {
                padding: .5rem !important
            }

            .pt-xl-2, .py-xl-2 {
                padding-top: .5rem !important
            }

            .pr-xl-2, .px-xl-2 {
                padding-right: .5rem !important
            }

            .pb-xl-2, .py-xl-2 {
                padding-bottom: .5rem !important
            }

            .pl-xl-2, .px-xl-2 {
                padding-left: .5rem !important
            }

            .p-xl-3 {
                padding: 1rem !important
            }

            .pt-xl-3, .py-xl-3 {
                padding-top: 1rem !important
            }

            .pr-xl-3, .px-xl-3 {
                padding-right: 1rem !important
            }

            .pb-xl-3, .py-xl-3 {
                padding-bottom: 1rem !important
            }

            .pl-xl-3, .px-xl-3 {
                padding-left: 1rem !important
            }

            .p-xl-4 {
                padding: 1.5rem !important
            }

            .pt-xl-4, .py-xl-4 {
                padding-top: 1.5rem !important
            }

            .pr-xl-4, .px-xl-4 {
                padding-right: 1.5rem !important
            }

            .pb-xl-4, .py-xl-4 {
                padding-bottom: 1.5rem !important
            }

            .pl-xl-4, .px-xl-4 {
                padding-left: 1.5rem !important
            }

            .p-xl-5 {
                padding: 3rem !important
            }

            .pt-xl-5, .py-xl-5 {
                padding-top: 3rem !important
            }

            .pr-xl-5, .px-xl-5 {
                padding-right: 3rem !important
            }

            .pb-xl-5, .py-xl-5 {
                padding-bottom: 3rem !important
            }

            .pl-xl-5, .px-xl-5 {
                padding-left: 3rem !important
            }

            .m-xl-auto {
                margin: auto !important
            }

            .mt-xl-auto, .my-xl-auto {
                margin-top: auto !important
            }

            .mr-xl-auto, .mx-xl-auto {
                margin-right: auto !important
            }

            .mb-xl-auto, .my-xl-auto {
                margin-bottom: auto !important
            }

            .ml-xl-auto, .mx-xl-auto {
                margin-left: auto !important
            }
        }

        .text-justify {
            text-align: justify !important
        }

        .text-nowrap {
            white-space: nowrap !important
        }

        .text-truncate {
            overflow: hidden;
            text-overflow: ellipsis;
            white-space: nowrap
        }

        .text-left {
            text-align: left !important
        }

        .text-right {
            text-align: right !important
        }

        .text-center {
            text-align: center !important
        }

        @media (min-width:576px) {
            .text-sm-left {
                text-align: left !important
            }

            .text-sm-right {
                text-align: right !important
            }

            .text-sm-center {
                text-align: center !important
            }
        }

        @media (min-width:768px) {
            .text-md-left {
                text-align: left !important
            }

            .text-md-right {
                text-align: right !important
            }

            .text-md-center {
                text-align: center !important
            }
        }

        @media (min-width:992px) {
            .text-lg-left {
                text-align: left !important
            }

            .text-lg-right {
                text-align: right !important
            }

            .text-lg-center {
                text-align: center !important
            }
        }

        @media (min-width:1200px) {
            .text-xl-left {
                text-align: left !important
            }

            .text-xl-right {
                text-align: right !important
            }

            .text-xl-center {
                text-align: center !important
            }
        }

        .text-lowercase {
            text-transform: lowercase !important
        }

        .text-uppercase {
            text-transform: uppercase !important
        }

        .text-capitalize {
            text-transform: capitalize !important
        }

        .font-weight-light {
            font-weight: 300 !important
        }

        .font-weight-normal {
            font-weight: 400 !important
        }

        .font-weight-bold {
            font-weight: 700 !important
        }

        .font-italic {
            font-style: italic !important
        }

        .text-white {
            color: #fff !important
        }

        .text-primary {
            color: #007bff !important
        }

        a.text-primary:focus, a.text-primary:hover {
            color: #0062cc !important
        }

        .text-secondary {
            color: #6c757d !important
        }

        a.text-secondary:focus, a.text-secondary:hover {
            color: #545b62 !important
        }

        .text-success {
            color: #28a745 !important
        }

        a.text-success:focus, a.text-success:hover {
            color: #1e7e34 !important
        }

        .text-info {
            color: #17a2b8 !important
        }

        a.text-info:focus, a.text-info:hover {
            color: #117a8b !important
        }

        .text-warning {
            color: #ffc107 !important
        }

        a.text-warning:focus, a.text-warning:hover {
            color: #d39e00 !important
        }

        .text-danger {
            color: #dc3545 !important
        }

        a.text-danger:focus, a.text-danger:hover {
            color: #bd2130 !important
        }

        .text-light {
            color: #f8f9fa !important
        }

        a.text-light:focus, a.text-light:hover {
            color: #dae0e5 !important
        }

        .text-dark {
            color: #343a40 !important
        }

        a.text-dark:focus, a.text-dark:hover {
            color: #1d2124 !important
        }

        .text-muted {
            color: #6c757d !important
        }

        .text-hide {
            font: 0/0 a;
            color: transparent;
            text-shadow: none;
            background-color: transparent;
            border: 0
        }

        .visible {
            visibility: visible !important
        }

        .invisible {
            visibility: hidden !important
        }

        @media print {
            *, ::after, ::before {
                text-shadow: none !important;
                box-shadow: none !important
            }

            a:not(.btn) {
                text-decoration: underline
            }

            abbr[title]::after {
                content: \"" (\"" attr(title) \"")\""
            }

            pre {
                white-space: pre-wrap !important
            }

            blockquote, pre {
                border: 1px solid #999;
                page-break-inside: avoid
            }

            thead {
                display: table-header-group
            }

            img, tr {
                page-break-inside: avoid
            }

            h2, h3, p {
                orphans: 3;
                widows: 3
            }

            h2, h3 {
                page-break-after: avoid
            }

            @page {
                size: a3
            }

            body {
                min-width: 992px !important
            }

            .container {
                min-width: 992px !important
            }

            .navbar {
                display: none
            }

            .badge {
                border: 1px solid #000
            }

            .table {
                border-collapse: collapse !important
            }

                .table td, .table th {
                    background-color: #fff !important
                }

            .table-bordered td, .table-bordered th {
                border: 1px solid #ddd !important
            }
        }
        /*# sourceMappingURL=bootstrap.min.css.map */
    </style>
    <script type=\""text/javascript\"">
        !function (t, e) { \""object\"" == typeof exports && \""undefined\"" != typeof module ? e(exports, require(\""jquery\""), require(\""popper.js\"")) : \""function\"" == typeof define && define.amd ? define([\""exports\"", \""jquery\"", \""popper.js\""], e) : e(t.bootstrap = {}, t.jQuery, t.Popper) }(this, function (t, e, n) { \""use strict\""; function i(t, e) { for (var n = 0; n < e.length; n++) { var i = e[n]; i.enumerable = i.enumerable || !1, i.configurable = !0, \""value\"" in i && (i.writable = !0), Object.defineProperty(t, i.key, i) } } function s(t, e, n) { return e && i(t.prototype, e), n && i(t, n), t } function r() { return (r = Object.assign || function (t) { for (var e = 1; e < arguments.length; e++) { var n = arguments[e]; for (var i in n) Object.prototype.hasOwnProperty.call(n, i) && (t[i] = n[i]) } return t }).apply(this, arguments) } e = e && e.hasOwnProperty(\""default\"") ? e.default : e, n = n && n.hasOwnProperty(\""default\"") ? n.default : n; var o, a, l, h, c, u, f, d, _, g, p, m, v, E, T, y, C, I, A, b, D, S, w, N, O, k, P = function (t) { var e = !1; function n(e) { var n = this, s = !1; return t(this).one(i.TRANSITION_END, function () { s = !0 }), setTimeout(function () { s || i.triggerTransitionEnd(n) }, e), this } var i = { TRANSITION_END: \""bsTransitionEnd\"", getUID: function (t) { do { t += ~~(1e6 * Math.random()) } while (document.getElementById(t)); return t }, getSelectorFromElement: function (e) { var n, i = e.getAttribute(\""data-target\""); i && \""#\"" !== i || (i = e.getAttribute(\""href\"") || \""\""), \""#\"" === i.charAt(0) && (n = i, i = n = \""function\"" == typeof t.escapeSelector ? t.escapeSelector(n).substr(1) : n.replace(/(:|\\.|\\[|\\]|,|=|@)/g, \""\\\\$1\"")); try { return t(document).find(i).length > 0 ? i : null } catch (t) { return null } }, reflow: function (t) { return t.offsetHeight }, triggerTransitionEnd: function (n) { t(n).trigger(e.end) }, supportsTransitionEnd: function () { return Boolean(e) }, isElement: function (t) { return (t[0] || t).nodeType }, typeCheckConfig: function (t, e, n) { for (var s in n) if (Object.prototype.hasOwnProperty.call(n, s)) { var r = n[s], o = e[s], a = o && i.isElement(o) ? \""element\"" : (l = o, {}.toString.call(l).match(/\\s([a-zA-Z]+)/)[1].toLowerCase()); if (!new RegExp(r).test(a)) throw new Error(t.toUpperCase() + ': Option \""' + s + '\"" provided type \""' + a + '\"" but expected type \""' + r + '\"".') } var l } }; return e = (\""undefined\"" == typeof window || !window.QUnit) && { end: \""transitionend\"" }, t.fn.emulateTransitionEnd = n, i.supportsTransitionEnd() && (t.event.special[i.TRANSITION_END] = { bindType: e.end, delegateType: e.end, handle: function (e) { if (t(e.target).is(this)) return e.handleObj.handler.apply(this, arguments) } }), i }(e), L = (a = \""alert\"", h = \"".\"" + (l = \""bs.alert\""), c = (o = e).fn[a], u = { CLOSE: \""close\"" + h, CLOSED: \""closed\"" + h, CLICK_DATA_API: \""click\"" + h + \"".data-api\"" }, f = \""alert\"", d = \""fade\"", _ = \""show\"", g = function () { function t(t) { this._element = t } var e = t.prototype; return e.close = function (t) { t = t || this._element; var e = this._getRootElement(t); this._triggerCloseEvent(e).isDefaultPrevented() || this._removeElement(e) }, e.dispose = function () { o.removeData(this._element, l), this._element = null }, e._getRootElement = function (t) { var e = P.getSelectorFromElement(t), n = !1; return e && (n = o(e)[0]), n || (n = o(t).closest(\"".\"" + f)[0]), n }, e._triggerCloseEvent = function (t) { var e = o.Event(u.CLOSE); return o(t).trigger(e), e }, e._removeElement = function (t) { var e = this; o(t).removeClass(_), P.supportsTransitionEnd() && o(t).hasClass(d) ? o(t).one(P.TRANSITION_END, function (n) { return e._destroyElement(t, n) }).emulateTransitionEnd(150) : this._destroyElement(t) }, e._destroyElement = function (t) { o(t).detach().trigger(u.CLOSED).remove() }, t._jQueryInterface = function (e) { return this.each(function () { var n = o(this), i = n.data(l); i || (i = new t(this), n.data(l, i)), \""close\"" === e && i[e](this) }) }, t._handleDismiss = function (t) { return function (e) { e && e.preventDefault(), t.close(this) } }, s(t, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }]), t }(), o(document).on(u.CLICK_DATA_API, '[data-dismiss=\""alert\""]', g._handleDismiss(new g)), o.fn[a] = g._jQueryInterface, o.fn[a].Constructor = g, o.fn[a].noConflict = function () { return o.fn[a] = c, g._jQueryInterface }, g), R = (m = \""button\"", E = \"".\"" + (v = \""bs.button\""), T = \"".data-api\"", y = (p = e).fn[m], C = \""active\"", I = \""btn\"", A = \""focus\"", b = '[data-toggle^=\""button\""]', D = '[data-toggle=\""buttons\""]', S = \""input\"", w = \"".active\"", N = \"".btn\"", O = { CLICK_DATA_API: \""click\"" + E + T, FOCUS_BLUR_DATA_API: \""focus\"" + E + T + \"" blur\"" + E + T }, k = function () { function t(t) { this._element = t } var e = t.prototype; return e.toggle = function () { var t = !0, e = !0, n = p(this._element).closest(D)[0]; if (n) { var i = p(this._element).find(S)[0]; if (i) { if (\""radio\"" === i.type) if (i.checked && p(this._element).hasClass(C)) t = !1; else { var s = p(n).find(w)[0]; s && p(s).removeClass(C) } if (t) { if (i.hasAttribute(\""disabled\"") || n.hasAttribute(\""disabled\"") || i.classList.contains(\""disabled\"") || n.classList.contains(\""disabled\"")) return; i.checked = !p(this._element).hasClass(C), p(i).trigger(\""change\"") } i.focus(), e = !1 } } e && this._element.setAttribute(\""aria-pressed\"", !p(this._element).hasClass(C)), t && p(this._element).toggleClass(C) }, e.dispose = function () { p.removeData(this._element, v), this._element = null }, t._jQueryInterface = function (e) { return this.each(function () { var n = p(this).data(v); n || (n = new t(this), p(this).data(v, n)), \""toggle\"" === e && n[e]() }) }, s(t, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }]), t }(), p(document).on(O.CLICK_DATA_API, b, function (t) { t.preventDefault(); var e = t.target; p(e).hasClass(I) || (e = p(e).closest(N)), k._jQueryInterface.call(p(e), \""toggle\"") }).on(O.FOCUS_BLUR_DATA_API, b, function (t) { var e = p(t.target).closest(N)[0]; p(e).toggleClass(A, /^focus(in)?$/.test(t.type)) }), p.fn[m] = k._jQueryInterface, p.fn[m].Constructor = k, p.fn[m].noConflict = function () { return p.fn[m] = y, k._jQueryInterface }, k), j = function (t) { var e = \""carousel\"", n = \""bs.carousel\"", i = \"".\"" + n, o = t.fn[e], a = { interval: 5e3, keyboard: !0, slide: !1, pause: \""hover\"", wrap: !0 }, l = { interval: \""(number|boolean)\"", keyboard: \""boolean\"", slide: \""(boolean|string)\"", pause: \""(string|boolean)\"", wrap: \""boolean\"" }, h = \""next\"", c = \""prev\"", u = \""left\"", f = \""right\"", d = { SLIDE: \""slide\"" + i, SLID: \""slid\"" + i, KEYDOWN: \""keydown\"" + i, MOUSEENTER: \""mouseenter\"" + i, MOUSELEAVE: \""mouseleave\"" + i, TOUCHEND: \""touchend\"" + i, LOAD_DATA_API: \""load\"" + i + \"".data-api\"", CLICK_DATA_API: \""click\"" + i + \"".data-api\"" }, _ = \""carousel\"", g = \""active\"", p = \""slide\"", m = \""carousel-item-right\"", v = \""carousel-item-left\"", E = \""carousel-item-next\"", T = \""carousel-item-prev\"", y = { ACTIVE: \"".active\"", ACTIVE_ITEM: \"".active.carousel-item\"", ITEM: \"".carousel-item\"", NEXT_PREV: \"".carousel-item-next, .carousel-item-prev\"", INDICATORS: \"".carousel-indicators\"", DATA_SLIDE: \""[data-slide], [data-slide-to]\"", DATA_RIDE: '[data-ride=\""carousel\""]' }, C = function () { function o(e, n) { this._items = null, this._interval = null, this._activeElement = null, this._isPaused = !1, this._isSliding = !1, this.touchTimeout = null, this._config = this._getConfig(n), this._element = t(e)[0], this._indicatorsElement = t(this._element).find(y.INDICATORS)[0], this._addEventListeners() } var C = o.prototype; return C.next = function () { this._isSliding || this._slide(h) }, C.nextWhenVisible = function () { !document.hidden && t(this._element).is(\"":visible\"") && \""hidden\"" !== t(this._element).css(\""visibility\"") && this.next() }, C.prev = function () { this._isSliding || this._slide(c) }, C.pause = function (e) { e || (this._isPaused = !0), t(this._element).find(y.NEXT_PREV)[0] && P.supportsTransitionEnd() && (P.triggerTransitionEnd(this._element), this.cycle(!0)), clearInterval(this._interval), this._interval = null }, C.cycle = function (t) { t || (this._isPaused = !1), this._interval && (clearInterval(this._interval), this._interval = null), this._config.interval && !this._isPaused && (this._interval = setInterval((document.visibilityState ? this.nextWhenVisible : this.next).bind(this), this._config.interval)) }, C.to = function (e) { var n = this; this._activeElement = t(this._element).find(y.ACTIVE_ITEM)[0]; var i = this._getItemIndex(this._activeElement); if (!(e > this._items.length - 1 || e < 0)) if (this._isSliding) t(this._element).one(d.SLID, function () { return n.to(e) }); else { if (i === e) return this.pause(), void this.cycle(); var s = e > i ? h : c; this._slide(s, this._items[e]) } }, C.dispose = function () { t(this._element).off(i), t.removeData(this._element, n), this._items = null, this._config = null, this._element = null, this._interval = null, this._isPaused = null, this._isSliding = null, this._activeElement = null, this._indicatorsElement = null }, C._getConfig = function (t) { return t = r({}, a, t), P.typeCheckConfig(e, t, l), t }, C._addEventListeners = function () { var e = this; this._config.keyboard && t(this._element).on(d.KEYDOWN, function (t) { return e._keydown(t) }), \""hover\"" === this._config.pause && (t(this._element).on(d.MOUSEENTER, function (t) { return e.pause(t) }).on(d.MOUSELEAVE, function (t) { return e.cycle(t) }), \""ontouchstart\"" in document.documentElement && t(this._element).on(d.TOUCHEND, function () { e.pause(), e.touchTimeout && clearTimeout(e.touchTimeout), e.touchTimeout = setTimeout(function (t) { return e.cycle(t) }, 500 + e._config.interval) })) }, C._keydown = function (t) { if (!/input|textarea/i.test(t.target.tagName)) switch (t.which) { case 37: t.preventDefault(), this.prev(); break; case 39: t.preventDefault(), this.next() } }, C._getItemIndex = function (e) { return this._items = t.makeArray(t(e).parent().find(y.ITEM)), this._items.indexOf(e) }, C._getItemByDirection = function (t, e) { var n = t === h, i = t === c, s = this._getItemIndex(e), r = this._items.length - 1; if ((i && 0 === s || n && s === r) && !this._config.wrap) return e; var o = (s + (t === c ? -1 : 1)) % this._items.length; return -1 === o ? this._items[this._items.length - 1] : this._items[o] }, C._triggerSlideEvent = function (e, n) { var i = this._getItemIndex(e), s = this._getItemIndex(t(this._element).find(y.ACTIVE_ITEM)[0]), r = t.Event(d.SLIDE, { relatedTarget: e, direction: n, from: s, to: i }); return t(this._element).trigger(r), r }, C._setActiveIndicatorElement = function (e) { if (this._indicatorsElement) { t(this._indicatorsElement).find(y.ACTIVE).removeClass(g); var n = this._indicatorsElement.children[this._getItemIndex(e)]; n && t(n).addClass(g) } }, C._slide = function (e, n) { var i, s, r, o = this, a = t(this._element).find(y.ACTIVE_ITEM)[0], l = this._getItemIndex(a), c = n || a && this._getItemByDirection(e, a), _ = this._getItemIndex(c), C = Boolean(this._interval); if (e === h ? (i = v, s = E, r = u) : (i = m, s = T, r = f), c && t(c).hasClass(g)) this._isSliding = !1; else if (!this._triggerSlideEvent(c, r).isDefaultPrevented() && a && c) { this._isSliding = !0, C && this.pause(), this._setActiveIndicatorElement(c); var I = t.Event(d.SLID, { relatedTarget: c, direction: r, from: l, to: _ }); P.supportsTransitionEnd() && t(this._element).hasClass(p) ? (t(c).addClass(s), P.reflow(c), t(a).addClass(i), t(c).addClass(i), t(a).one(P.TRANSITION_END, function () { t(c).removeClass(i + \"" \"" + s).addClass(g), t(a).removeClass(g + \"" \"" + s + \"" \"" + i), o._isSliding = !1, setTimeout(function () { return t(o._element).trigger(I) }, 0) }).emulateTransitionEnd(600)) : (t(a).removeClass(g), t(c).addClass(g), this._isSliding = !1, t(this._element).trigger(I)), C && this.cycle() } }, o._jQueryInterface = function (e) { return this.each(function () { var i = t(this).data(n), s = r({}, a, t(this).data()); \""object\"" == typeof e && (s = r({}, s, e)); var l = \""string\"" == typeof e ? e : s.slide; if (i || (i = new o(this, s), t(this).data(n, i)), \""number\"" == typeof e) i.to(e); else if (\""string\"" == typeof l) { if (\""undefined\"" == typeof i[l]) throw new TypeError('No method named \""' + l + '\""'); i[l]() } else s.interval && (i.pause(), i.cycle()) }) }, o._dataApiClickHandler = function (e) { var i = P.getSelectorFromElement(this); if (i) { var s = t(i)[0]; if (s && t(s).hasClass(_)) { var a = r({}, t(s).data(), t(this).data()), l = this.getAttribute(\""data-slide-to\""); l && (a.interval = !1), o._jQueryInterface.call(t(s), a), l && t(s).data(n).to(l), e.preventDefault() } } }, s(o, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }, { key: \""Default\"", get: function () { return a } }]), o }(); return t(document).on(d.CLICK_DATA_API, y.DATA_SLIDE, C._dataApiClickHandler), t(window).on(d.LOAD_DATA_API, function () { t(y.DATA_RIDE).each(function () { var e = t(this); C._jQueryInterface.call(e, e.data()) }) }), t.fn[e] = C._jQueryInterface, t.fn[e].Constructor = C, t.fn[e].noConflict = function () { return t.fn[e] = o, C._jQueryInterface }, C }(e), H = function (t) { var e = \""collapse\"", n = \""bs.collapse\"", i = \"".\"" + n, o = t.fn[e], a = { toggle: !0, parent: \""\"" }, l = { toggle: \""boolean\"", parent: \""(string|element)\"" }, h = { SHOW: \""show\"" + i, SHOWN: \""shown\"" + i, HIDE: \""hide\"" + i, HIDDEN: \""hidden\"" + i, CLICK_DATA_API: \""click\"" + i + \"".data-api\"" }, c = \""show\"", u = \""collapse\"", f = \""collapsing\"", d = \""collapsed\"", _ = \""width\"", g = \""height\"", p = { ACTIVES: \"".show, .collapsing\"", DATA_TOGGLE: '[data-toggle=\""collapse\""]' }, m = function () { function i(e, n) { this._isTransitioning = !1, this._element = e, this._config = this._getConfig(n), this._triggerArray = t.makeArray(t('[data-toggle=\""collapse\""][href=\""#' + e.id + '\""],[data-toggle=\""collapse\""][data-target=\""#' + e.id + '\""]')); for (var i = t(p.DATA_TOGGLE), s = 0; s < i.length; s++) { var r = i[s], o = P.getSelectorFromElement(r); null !== o && t(o).filter(e).length > 0 && (this._selector = o, this._triggerArray.push(r)) } this._parent = this._config.parent ? this._getParent() : null, this._config.parent || this._addAriaAndCollapsedClass(this._element, this._triggerArray), this._config.toggle && this.toggle() } var o = i.prototype; return o.toggle = function () { t(this._element).hasClass(c) ? this.hide() : this.show() }, o.show = function () { var e, s, r = this; if (!this._isTransitioning && !t(this._element).hasClass(c) && (this._parent && 0 === (e = t.makeArray(t(this._parent).find(p.ACTIVES).filter('[data-parent=\""' + this._config.parent + '\""]'))).length && (e = null), !(e && (s = t(e).not(this._selector).data(n)) && s._isTransitioning))) { var o = t.Event(h.SHOW); if (t(this._element).trigger(o), !o.isDefaultPrevented()) { e && (i._jQueryInterface.call(t(e).not(this._selector), \""hide\""), s || t(e).data(n, null)); var a = this._getDimension(); t(this._element).removeClass(u).addClass(f), this._element.style[a] = 0, this._triggerArray.length > 0 && t(this._triggerArray).removeClass(d).attr(\""aria-expanded\"", !0), this.setTransitioning(!0); var l = function () { t(r._element).removeClass(f).addClass(u).addClass(c), r._element.style[a] = \""\"", r.setTransitioning(!1), t(r._element).trigger(h.SHOWN) }; if (P.supportsTransitionEnd()) { var _ = \""scroll\"" + (a[0].toUpperCase() + a.slice(1)); t(this._element).one(P.TRANSITION_END, l).emulateTransitionEnd(600), this._element.style[a] = this._element[_] + \""px\"" } else l() } } }, o.hide = function () { var e = this; if (!this._isTransitioning && t(this._element).hasClass(c)) { var n = t.Event(h.HIDE); if (t(this._element).trigger(n), !n.isDefaultPrevented()) { var i = this._getDimension(); if (this._element.style[i] = this._element.getBoundingClientRect()[i] + \""px\"", P.reflow(this._element), t(this._element).addClass(f).removeClass(u).removeClass(c), this._triggerArray.length > 0) for (var s = 0; s < this._triggerArray.length; s++) { var r = this._triggerArray[s], o = P.getSelectorFromElement(r); if (null !== o) t(o).hasClass(c) || t(r).addClass(d).attr(\""aria-expanded\"", !1) } this.setTransitioning(!0); var a = function () { e.setTransitioning(!1), t(e._element).removeClass(f).addClass(u).trigger(h.HIDDEN) }; this._element.style[i] = \""\"", P.supportsTransitionEnd() ? t(this._element).one(P.TRANSITION_END, a).emulateTransitionEnd(600) : a() } } }, o.setTransitioning = function (t) { this._isTransitioning = t }, o.dispose = function () { t.removeData(this._element, n), this._config = null, this._parent = null, this._element = null, this._triggerArray = null, this._isTransitioning = null }, o._getConfig = function (t) { return (t = r({}, a, t)).toggle = Boolean(t.toggle), P.typeCheckConfig(e, t, l), t }, o._getDimension = function () { return t(this._element).hasClass(_) ? _ : g }, o._getParent = function () { var e = this, n = null; P.isElement(this._config.parent) ? (n = this._config.parent, \""undefined\"" != typeof this._config.parent.jquery && (n = this._config.parent[0])) : n = t(this._config.parent)[0]; var s = '[data-toggle=\""collapse\""][data-parent=\""' + this._config.parent + '\""]'; return t(n).find(s).each(function (t, n) { e._addAriaAndCollapsedClass(i._getTargetFromElement(n), [n]) }), n }, o._addAriaAndCollapsedClass = function (e, n) { if (e) { var i = t(e).hasClass(c); n.length > 0 && t(n).toggleClass(d, !i).attr(\""aria-expanded\"", i) } }, i._getTargetFromElement = function (e) { var n = P.getSelectorFromElement(e); return n ? t(n)[0] : null }, i._jQueryInterface = function (e) { return this.each(function () { var s = t(this), o = s.data(n), l = r({}, a, s.data(), \""object\"" == typeof e && e); if (!o && l.toggle && /show|hide/.test(e) && (l.toggle = !1), o || (o = new i(this, l), s.data(n, o)), \""string\"" == typeof e) { if (\""undefined\"" == typeof o[e]) throw new TypeError('No method named \""' + e + '\""'); o[e]() } }) }, s(i, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }, { key: \""Default\"", get: function () { return a } }]), i }(); return t(document).on(h.CLICK_DATA_API, p.DATA_TOGGLE, function (e) { \""A\"" === e.currentTarget.tagName && e.preventDefault(); var i = t(this), s = P.getSelectorFromElement(this); t(s).each(function () { var e = t(this), s = e.data(n) ? \""toggle\"" : i.data(); m._jQueryInterface.call(e, s) }) }), t.fn[e] = m._jQueryInterface, t.fn[e].Constructor = m, t.fn[e].noConflict = function () { return t.fn[e] = o, m._jQueryInterface }, m }(e), W = function (t) { var e = \""dropdown\"", i = \""bs.dropdown\"", o = \"".\"" + i, a = \"".data-api\"", l = t.fn[e], h = new RegExp(\""38|40|27\""), c = { HIDE: \""hide\"" + o, HIDDEN: \""hidden\"" + o, SHOW: \""show\"" + o, SHOWN: \""shown\"" + o, CLICK: \""click\"" + o, CLICK_DATA_API: \""click\"" + o + a, KEYDOWN_DATA_API: \""keydown\"" + o + a, KEYUP_DATA_API: \""keyup\"" + o + a }, u = \""disabled\"", f = \""show\"", d = \""dropup\"", _ = \""dropright\"", g = \""dropleft\"", p = \""dropdown-menu-right\"", m = \""dropdown-menu-left\"", v = \""position-static\"", E = '[data-toggle=\""dropdown\""]', T = \"".dropdown form\"", y = \"".dropdown-menu\"", C = \"".navbar-nav\"", I = \"".dropdown-menu .dropdown-item:not(.disabled)\"", A = \""top-start\"", b = \""top-end\"", D = \""bottom-start\"", S = \""bottom-end\"", w = \""right-start\"", N = \""left-start\"", O = { offset: 0, flip: !0, boundary: \""scrollParent\"" }, k = { offset: \""(number|string|function)\"", flip: \""boolean\"", boundary: \""(string|element)\"" }, L = function () { function a(t, e) { this._element = t, this._popper = null, this._config = this._getConfig(e), this._menu = this._getMenuElement(), this._inNavbar = this._detectNavbar(), this._addEventListeners() } var l = a.prototype; return l.toggle = function () { if (!this._element.disabled && !t(this._element).hasClass(u)) { var e = a._getParentFromElement(this._element), i = t(this._menu).hasClass(f); if (a._clearMenus(), !i) { var s = { relatedTarget: this._element }, r = t.Event(c.SHOW, s); if (t(e).trigger(r), !r.isDefaultPrevented()) { if (!this._inNavbar) { if (\""undefined\"" == typeof n) throw new TypeError(\""Bootstrap dropdown require Popper.js (https://popper.js.org)\""); var o = this._element; t(e).hasClass(d) && (t(this._menu).hasClass(m) || t(this._menu).hasClass(p)) && (o = e), \""scrollParent\"" !== this._config.boundary && t(e).addClass(v), this._popper = new n(o, this._menu, this._getPopperConfig()) } \""ontouchstart\"" in document.documentElement && 0 === t(e).closest(C).length && t(\""body\"").children().on(\""mouseover\"", null, t.noop), this._element.focus(), this._element.setAttribute(\""aria-expanded\"", !0), t(this._menu).toggleClass(f), t(e).toggleClass(f).trigger(t.Event(c.SHOWN, s)) } } } }, l.dispose = function () { t.removeData(this._element, i), t(this._element).off(o), this._element = null, this._menu = null, null !== this._popper && (this._popper.destroy(), this._popper = null) }, l.update = function () { this._inNavbar = this._detectNavbar(), null !== this._popper && this._popper.scheduleUpdate() }, l._addEventListeners = function () { var e = this; t(this._element).on(c.CLICK, function (t) { t.preventDefault(), t.stopPropagation(), e.toggle() }) }, l._getConfig = function (n) { return n = r({}, this.constructor.Default, t(this._element).data(), n), P.typeCheckConfig(e, n, this.constructor.DefaultType), n }, l._getMenuElement = function () { if (!this._menu) { var e = a._getParentFromElement(this._element); this._menu = t(e).find(y)[0] } return this._menu }, l._getPlacement = function () { var e = t(this._element).parent(), n = D; return e.hasClass(d) ? (n = A, t(this._menu).hasClass(p) && (n = b)) : e.hasClass(_) ? n = w : e.hasClass(g) ? n = N : t(this._menu).hasClass(p) && (n = S), n }, l._detectNavbar = function () { return t(this._element).closest(\"".navbar\"").length > 0 }, l._getPopperConfig = function () { var t = this, e = {}; return \""function\"" == typeof this._config.offset ? e.fn = function (e) { return e.offsets = r({}, e.offsets, t._config.offset(e.offsets) || {}), e } : e.offset = this._config.offset, { placement: this._getPlacement(), modifiers: { offset: e, flip: { enabled: this._config.flip }, preventOverflow: { boundariesElement: this._config.boundary } } } }, a._jQueryInterface = function (e) { return this.each(function () { var n = t(this).data(i); if (n || (n = new a(this, \""object\"" == typeof e ? e : null), t(this).data(i, n)), \""string\"" == typeof e) { if (\""undefined\"" == typeof n[e]) throw new TypeError('No method named \""' + e + '\""'); n[e]() } }) }, a._clearMenus = function (e) { if (!e || 3 !== e.which && (\""keyup\"" !== e.type || 9 === e.which)) for (var n = t.makeArray(t(E)), s = 0; s < n.length; s++) { var r = a._getParentFromElement(n[s]), o = t(n[s]).data(i), l = { relatedTarget: n[s] }; if (o) { var h = o._menu; if (t(r).hasClass(f) && !(e && (\""click\"" === e.type && /input|textarea/i.test(e.target.tagName) || \""keyup\"" === e.type && 9 === e.which) && t.contains(r, e.target))) { var u = t.Event(c.HIDE, l); t(r).trigger(u), u.isDefaultPrevented() || (\""ontouchstart\"" in document.documentElement && t(\""body\"").children().off(\""mouseover\"", null, t.noop), n[s].setAttribute(\""aria-expanded\"", \""false\""), t(h).removeClass(f), t(r).removeClass(f).trigger(t.Event(c.HIDDEN, l))) } } } }, a._getParentFromElement = function (e) { var n, i = P.getSelectorFromElement(e); return i && (n = t(i)[0]), n || e.parentNode }, a._dataApiKeydownHandler = function (e) { if ((/input|textarea/i.test(e.target.tagName) ? !(32 === e.which || 27 !== e.which && (40 !== e.which && 38 !== e.which || t(e.target).closest(y).length)) : h.test(e.which)) && (e.preventDefault(), e.stopPropagation(), !this.disabled && !t(this).hasClass(u))) { var n = a._getParentFromElement(this), i = t(n).hasClass(f); if ((i || 27 === e.which && 32 === e.which) && (!i || 27 !== e.which && 32 !== e.which)) { var s = t(n).find(I).get(); if (0 !== s.length) { var r = s.indexOf(e.target); 38 === e.which && r > 0 && r-- , 40 === e.which && r < s.length - 1 && r++ , r < 0 && (r = 0), s[r].focus() } } else { if (27 === e.which) { var o = t(n).find(E)[0]; t(o).trigger(\""focus\"") } t(this).trigger(\""click\"") } } }, s(a, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }, { key: \""Default\"", get: function () { return O } }, { key: \""DefaultType\"", get: function () { return k } }]), a }(); return t(document).on(c.KEYDOWN_DATA_API, E, L._dataApiKeydownHandler).on(c.KEYDOWN_DATA_API, y, L._dataApiKeydownHandler).on(c.CLICK_DATA_API + \"" \"" + c.KEYUP_DATA_API, L._clearMenus).on(c.CLICK_DATA_API, E, function (e) { e.preventDefault(), e.stopPropagation(), L._jQueryInterface.call(t(this), \""toggle\"") }).on(c.CLICK_DATA_API, T, function (t) { t.stopPropagation() }), t.fn[e] = L._jQueryInterface, t.fn[e].Constructor = L, t.fn[e].noConflict = function () { return t.fn[e] = l, L._jQueryInterface }, L }(e), M = function (t) { var e = \""modal\"", n = \""bs.modal\"", i = \"".\"" + n, o = t.fn.modal, a = { backdrop: !0, keyboard: !0, focus: !0, show: !0 }, l = { backdrop: \""(boolean|string)\"", keyboard: \""boolean\"", focus: \""boolean\"", show: \""boolean\"" }, h = { HIDE: \""hide\"" + i, HIDDEN: \""hidden\"" + i, SHOW: \""show\"" + i, SHOWN: \""shown\"" + i, FOCUSIN: \""focusin\"" + i, RESIZE: \""resize\"" + i, CLICK_DISMISS: \""click.dismiss\"" + i, KEYDOWN_DISMISS: \""keydown.dismiss\"" + i, MOUSEUP_DISMISS: \""mouseup.dismiss\"" + i, MOUSEDOWN_DISMISS: \""mousedown.dismiss\"" + i, CLICK_DATA_API: \""click\"" + i + \"".data-api\"" }, c = \""modal-scrollbar-measure\"", u = \""modal-backdrop\"", f = \""modal-open\"", d = \""fade\"", _ = \""show\"", g = { DIALOG: \"".modal-dialog\"", DATA_TOGGLE: '[data-toggle=\""modal\""]', DATA_DISMISS: '[data-dismiss=\""modal\""]', FIXED_CONTENT: \"".fixed-top, .fixed-bottom, .is-fixed, .sticky-top\"", STICKY_CONTENT: \"".sticky-top\"", NAVBAR_TOGGLER: \"".navbar-toggler\"" }, p = function () { function o(e, n) { this._config = this._getConfig(n), this._element = e, this._dialog = t(e).find(g.DIALOG)[0], this._backdrop = null, this._isShown = !1, this._isBodyOverflowing = !1, this._ignoreBackdropClick = !1, this._originalBodyPadding = 0, this._scrollbarWidth = 0 } var p = o.prototype; return p.toggle = function (t) { return this._isShown ? this.hide() : this.show(t) }, p.show = function (e) { var n = this; if (!this._isTransitioning && !this._isShown) { P.supportsTransitionEnd() && t(this._element).hasClass(d) && (this._isTransitioning = !0); var i = t.Event(h.SHOW, { relatedTarget: e }); t(this._element).trigger(i), this._isShown || i.isDefaultPrevented() || (this._isShown = !0, this._checkScrollbar(), this._setScrollbar(), this._adjustDialog(), t(document.body).addClass(f), this._setEscapeEvent(), this._setResizeEvent(), t(this._element).on(h.CLICK_DISMISS, g.DATA_DISMISS, function (t) { return n.hide(t) }), t(this._dialog).on(h.MOUSEDOWN_DISMISS, function () { t(n._element).one(h.MOUSEUP_DISMISS, function (e) { t(e.target).is(n._element) && (n._ignoreBackdropClick = !0) }) }), this._showBackdrop(function () { return n._showElement(e) })) } }, p.hide = function (e) { var n = this; if (e && e.preventDefault(), !this._isTransitioning && this._isShown) { var i = t.Event(h.HIDE); if (t(this._element).trigger(i), this._isShown && !i.isDefaultPrevented()) { this._isShown = !1; var s = P.supportsTransitionEnd() && t(this._element).hasClass(d); s && (this._isTransitioning = !0), this._setEscapeEvent(), this._setResizeEvent(), t(document).off(h.FOCUSIN), t(this._element).removeClass(_), t(this._element).off(h.CLICK_DISMISS), t(this._dialog).off(h.MOUSEDOWN_DISMISS), s ? t(this._element).one(P.TRANSITION_END, function (t) { return n._hideModal(t) }).emulateTransitionEnd(300) : this._hideModal() } } }, p.dispose = function () { t.removeData(this._element, n), t(window, document, this._element, this._backdrop).off(i), this._config = null, this._element = null, this._dialog = null, this._backdrop = null, this._isShown = null, this._isBodyOverflowing = null, this._ignoreBackdropClick = null, this._scrollbarWidth = null }, p.handleUpdate = function () { this._adjustDialog() }, p._getConfig = function (t) { return t = r({}, a, t), P.typeCheckConfig(e, t, l), t }, p._showElement = function (e) { var n = this, i = P.supportsTransitionEnd() && t(this._element).hasClass(d); this._element.parentNode && this._element.parentNode.nodeType === Node.ELEMENT_NODE || document.body.appendChild(this._element), this._element.style.display = \""block\"", this._element.removeAttribute(\""aria-hidden\""), this._element.scrollTop = 0, i && P.reflow(this._element), t(this._element).addClass(_), this._config.focus && this._enforceFocus(); var s = t.Event(h.SHOWN, { relatedTarget: e }), r = function () { n._config.focus && n._element.focus(), n._isTransitioning = !1, t(n._element).trigger(s) }; i ? t(this._dialog).one(P.TRANSITION_END, r).emulateTransitionEnd(300) : r() }, p._enforceFocus = function () { var e = this; t(document).off(h.FOCUSIN).on(h.FOCUSIN, function (n) { document !== n.target && e._element !== n.target && 0 === t(e._element).has(n.target).length && e._element.focus() }) }, p._setEscapeEvent = function () { var e = this; this._isShown && this._config.keyboard ? t(this._element).on(h.KEYDOWN_DISMISS, function (t) { 27 === t.which && (t.preventDefault(), e.hide()) }) : this._isShown || t(this._element).off(h.KEYDOWN_DISMISS) }, p._setResizeEvent = function () { var e = this; this._isShown ? t(window).on(h.RESIZE, function (t) { return e.handleUpdate(t) }) : t(window).off(h.RESIZE) }, p._hideModal = function () { var e = this; this._element.style.display = \""none\"", this._element.setAttribute(\""aria-hidden\"", !0), this._isTransitioning = !1, this._showBackdrop(function () { t(document.body).removeClass(f), e._resetAdjustments(), e._resetScrollbar(), t(e._element).trigger(h.HIDDEN) }) }, p._removeBackdrop = function () { this._backdrop && (t(this._backdrop).remove(), this._backdrop = null) }, p._showBackdrop = function (e) { var n = this, i = t(this._element).hasClass(d) ? d : \""\""; if (this._isShown && this._config.backdrop) { var s = P.supportsTransitionEnd() && i; if (this._backdrop = document.createElement(\""div\""), this._backdrop.className = u, i && t(this._backdrop).addClass(i), t(this._backdrop).appendTo(document.body), t(this._element).on(h.CLICK_DISMISS, function (t) { n._ignoreBackdropClick ? n._ignoreBackdropClick = !1 : t.target === t.currentTarget && (\""static\"" === n._config.backdrop ? n._element.focus() : n.hide()) }), s && P.reflow(this._backdrop), t(this._backdrop).addClass(_), !e) return; if (!s) return void e(); t(this._backdrop).one(P.TRANSITION_END, e).emulateTransitionEnd(150) } else if (!this._isShown && this._backdrop) { t(this._backdrop).removeClass(_); var r = function () { n._removeBackdrop(), e && e() }; P.supportsTransitionEnd() && t(this._element).hasClass(d) ? t(this._backdrop).one(P.TRANSITION_END, r).emulateTransitionEnd(150) : r() } else e && e() }, p._adjustDialog = function () { var t = this._element.scrollHeight > document.documentElement.clientHeight; !this._isBodyOverflowing && t && (this._element.style.paddingLeft = this._scrollbarWidth + \""px\""), this._isBodyOverflowing && !t && (this._element.style.paddingRight = this._scrollbarWidth + \""px\"") }, p._resetAdjustments = function () { this._element.style.paddingLeft = \""\"", this._element.style.paddingRight = \""\"" }, p._checkScrollbar = function () { var t = document.body.getBoundingClientRect(); this._isBodyOverflowing = t.left + t.right < window.innerWidth, this._scrollbarWidth = this._getScrollbarWidth() }, p._setScrollbar = function () { var e = this; if (this._isBodyOverflowing) { t(g.FIXED_CONTENT).each(function (n, i) { var s = t(i)[0].style.paddingRight, r = t(i).css(\""padding-right\""); t(i).data(\""padding-right\"", s).css(\""padding-right\"", parseFloat(r) + e._scrollbarWidth + \""px\"") }), t(g.STICKY_CONTENT).each(function (n, i) { var s = t(i)[0].style.marginRight, r = t(i).css(\""margin-right\""); t(i).data(\""margin-right\"", s).css(\""margin-right\"", parseFloat(r) - e._scrollbarWidth + \""px\"") }), t(g.NAVBAR_TOGGLER).each(function (n, i) { var s = t(i)[0].style.marginRight, r = t(i).css(\""margin-right\""); t(i).data(\""margin-right\"", s).css(\""margin-right\"", parseFloat(r) + e._scrollbarWidth + \""px\"") }); var n = document.body.style.paddingRight, i = t(\""body\"").css(\""padding-right\""); t(\""body\"").data(\""padding-right\"", n).css(\""padding-right\"", parseFloat(i) + this._scrollbarWidth + \""px\"") } }, p._resetScrollbar = function () { t(g.FIXED_CONTENT).each(function (e, n) { var i = t(n).data(\""padding-right\""); \""undefined\"" != typeof i && t(n).css(\""padding-right\"", i).removeData(\""padding-right\"") }), t(g.STICKY_CONTENT + \"", \"" + g.NAVBAR_TOGGLER).each(function (e, n) { var i = t(n).data(\""margin-right\""); \""undefined\"" != typeof i && t(n).css(\""margin-right\"", i).removeData(\""margin-right\"") }); var e = t(\""body\"").data(\""padding-right\""); \""undefined\"" != typeof e && t(\""body\"").css(\""padding-right\"", e).removeData(\""padding-right\"") }, p._getScrollbarWidth = function () { var t = document.createElement(\""div\""); t.className = c, document.body.appendChild(t); var e = t.getBoundingClientRect().width - t.clientWidth; return document.body.removeChild(t), e }, o._jQueryInterface = function (e, i) { return this.each(function () { var s = t(this).data(n), a = r({}, o.Default, t(this).data(), \""object\"" == typeof e && e); if (s || (s = new o(this, a), t(this).data(n, s)), \""string\"" == typeof e) { if (\""undefined\"" == typeof s[e]) throw new TypeError('No method named \""' + e + '\""'); s[e](i) } else a.show && s.show(i) }) }, s(o, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }, { key: \""Default\"", get: function () { return a } }]), o }(); return t(document).on(h.CLICK_DATA_API, g.DATA_TOGGLE, function (e) { var i, s = this, o = P.getSelectorFromElement(this); o && (i = t(o)[0]); var a = t(i).data(n) ? \""toggle\"" : r({}, t(i).data(), t(this).data()); \""A\"" !== this.tagName && \""AREA\"" !== this.tagName || e.preventDefault(); var l = t(i).one(h.SHOW, function (e) { e.isDefaultPrevented() || l.one(h.HIDDEN, function () { t(s).is(\"":visible\"") && s.focus() }) }); p._jQueryInterface.call(t(i), a, this) }), t.fn.modal = p._jQueryInterface, t.fn.modal.Constructor = p, t.fn.modal.noConflict = function () { return t.fn.modal = o, p._jQueryInterface }, p }(e), U = function (t) { var e = \""tooltip\"", i = \""bs.tooltip\"", o = \"".\"" + i, a = t.fn[e], l = new RegExp(\""(^|\\\\s)bs-tooltip\\\\S+\"", \""g\""), h = { animation: \""boolean\"", template: \""string\"", title: \""(string|element|function)\"", trigger: \""string\"", delay: \""(number|object)\"", html: \""boolean\"", selector: \""(string|boolean)\"", placement: \""(string|function)\"", offset: \""(number|string)\"", container: \""(string|element|boolean)\"", fallbackPlacement: \""(string|array)\"", boundary: \""(string|element)\"" }, c = { AUTO: \""auto\"", TOP: \""top\"", RIGHT: \""right\"", BOTTOM: \""bottom\"", LEFT: \""left\"" }, u = { animation: !0, template: '<div class=\""tooltip\"" role=\""tooltip\""><div class=\""arrow\""></div><div class=\""tooltip-inner\""></div></div>', trigger: \""hover focus\"", title: \""\"", delay: 0, html: !1, selector: !1, placement: \""top\"", offset: 0, container: !1, fallbackPlacement: \""flip\"", boundary: \""scrollParent\"" }, f = \""show\"", d = \""out\"", _ = { HIDE: \""hide\"" + o, HIDDEN: \""hidden\"" + o, SHOW: \""show\"" + o, SHOWN: \""shown\"" + o, INSERTED: \""inserted\"" + o, CLICK: \""click\"" + o, FOCUSIN: \""focusin\"" + o, FOCUSOUT: \""focusout\"" + o, MOUSEENTER: \""mouseenter\"" + o, MOUSELEAVE: \""mouseleave\"" + o }, g = \""fade\"", p = \""show\"", m = \"".tooltip-inner\"", v = \"".arrow\"", E = \""hover\"", T = \""focus\"", y = \""click\"", C = \""manual\"", I = function () { function a(t, e) { if (\""undefined\"" == typeof n) throw new TypeError(\""Bootstrap tooltips require Popper.js (https://popper.js.org)\""); this._isEnabled = !0, this._timeout = 0, this._hoverState = \""\"", this._activeTrigger = {}, this._popper = null, this.element = t, this.config = this._getConfig(e), this.tip = null, this._setListeners() } var I = a.prototype; return I.enable = function () { this._isEnabled = !0 }, I.disable = function () { this._isEnabled = !1 }, I.toggleEnabled = function () { this._isEnabled = !this._isEnabled }, I.toggle = function (e) { if (this._isEnabled) if (e) { var n = this.constructor.DATA_KEY, i = t(e.currentTarget).data(n); i || (i = new this.constructor(e.currentTarget, this._getDelegateConfig()), t(e.currentTarget).data(n, i)), i._activeTrigger.click = !i._activeTrigger.click, i._isWithActiveTrigger() ? i._enter(null, i) : i._leave(null, i) } else { if (t(this.getTipElement()).hasClass(p)) return void this._leave(null, this); this._enter(null, this) } }, I.dispose = function () { clearTimeout(this._timeout), t.removeData(this.element, this.constructor.DATA_KEY), t(this.element).off(this.constructor.EVENT_KEY), t(this.element).closest(\"".modal\"").off(\""hide.bs.modal\""), this.tip && t(this.tip).remove(), this._isEnabled = null, this._timeout = null, this._hoverState = null, this._activeTrigger = null, null !== this._popper && this._popper.destroy(), this._popper = null, this.element = null, this.config = null, this.tip = null }, I.show = function () { var e = this; if (\""none\"" === t(this.element).css(\""display\"")) throw new Error(\""Please use show on visible elements\""); var i = t.Event(this.constructor.Event.SHOW); if (this.isWithContent() && this._isEnabled) { t(this.element).trigger(i); var s = t.contains(this.element.ownerDocument.documentElement, this.element); if (i.isDefaultPrevented() || !s) return; var r = this.getTipElement(), o = P.getUID(this.constructor.NAME); r.setAttribute(\""id\"", o), this.element.setAttribute(\""aria-describedby\"", o), this.setContent(), this.config.animation && t(r).addClass(g); var l = \""function\"" == typeof this.config.placement ? this.config.placement.call(this, r, this.element) : this.config.placement, h = this._getAttachment(l); this.addAttachmentClass(h); var c = !1 === this.config.container ? document.body : t(this.config.container); t(r).data(this.constructor.DATA_KEY, this), t.contains(this.element.ownerDocument.documentElement, this.tip) || t(r).appendTo(c), t(this.element).trigger(this.constructor.Event.INSERTED), this._popper = new n(this.element, r, { placement: h, modifiers: { offset: { offset: this.config.offset }, flip: { behavior: this.config.fallbackPlacement }, arrow: { element: v }, preventOverflow: { boundariesElement: this.config.boundary } }, onCreate: function (t) { t.originalPlacement !== t.placement && e._handlePopperPlacementChange(t) }, onUpdate: function (t) { e._handlePopperPlacementChange(t) } }), t(r).addClass(p), \""ontouchstart\"" in document.documentElement && t(\""body\"").children().on(\""mouseover\"", null, t.noop); var u = function () { e.config.animation && e._fixTransition(); var n = e._hoverState; e._hoverState = null, t(e.element).trigger(e.constructor.Event.SHOWN), n === d && e._leave(null, e) }; P.supportsTransitionEnd() && t(this.tip).hasClass(g) ? t(this.tip).one(P.TRANSITION_END, u).emulateTransitionEnd(a._TRANSITION_DURATION) : u() } }, I.hide = function (e) { var n = this, i = this.getTipElement(), s = t.Event(this.constructor.Event.HIDE), r = function () { n._hoverState !== f && i.parentNode && i.parentNode.removeChild(i), n._cleanTipClass(), n.element.removeAttribute(\""aria-describedby\""), t(n.element).trigger(n.constructor.Event.HIDDEN), null !== n._popper && n._popper.destroy(), e && e() }; t(this.element).trigger(s), s.isDefaultPrevented() || (t(i).removeClass(p), \""ontouchstart\"" in document.documentElement && t(\""body\"").children().off(\""mouseover\"", null, t.noop), this._activeTrigger[y] = !1, this._activeTrigger[T] = !1, this._activeTrigger[E] = !1, P.supportsTransitionEnd() && t(this.tip).hasClass(g) ? t(i).one(P.TRANSITION_END, r).emulateTransitionEnd(150) : r(), this._hoverState = \""\"") }, I.update = function () { null !== this._popper && this._popper.scheduleUpdate() }, I.isWithContent = function () { return Boolean(this.getTitle()) }, I.addAttachmentClass = function (e) { t(this.getTipElement()).addClass(\""bs-tooltip-\"" + e) }, I.getTipElement = function () { return this.tip = this.tip || t(this.config.template)[0], this.tip }, I.setContent = function () { var e = t(this.getTipElement()); this.setElementContent(e.find(m), this.getTitle()), e.removeClass(g + \"" \"" + p) }, I.setElementContent = function (e, n) { var i = this.config.html; \""object\"" == typeof n && (n.nodeType || n.jquery) ? i ? t(n).parent().is(e) || e.empty().append(n) : e.text(t(n).text()) : e[i ? \""html\"" : \""text\""](n) }, I.getTitle = function () { var t = this.element.getAttribute(\""data-original-title\""); return t || (t = \""function\"" == typeof this.config.title ? this.config.title.call(this.element) : this.config.title), t }, I._getAttachment = function (t) { return c[t.toUpperCase()] }, I._setListeners = function () { var e = this; this.config.trigger.split(\"" \"").forEach(function (n) { if (\""click\"" === n) t(e.element).on(e.constructor.Event.CLICK, e.config.selector, function (t) { return e.toggle(t) }); else if (n !== C) { var i = n === E ? e.constructor.Event.MOUSEENTER : e.constructor.Event.FOCUSIN, s = n === E ? e.constructor.Event.MOUSELEAVE : e.constructor.Event.FOCUSOUT; t(e.element).on(i, e.config.selector, function (t) { return e._enter(t) }).on(s, e.config.selector, function (t) { return e._leave(t) }) } t(e.element).closest(\"".modal\"").on(\""hide.bs.modal\"", function () { return e.hide() }) }), this.config.selector ? this.config = r({}, this.config, { trigger: \""manual\"", selector: \""\"" }) : this._fixTitle() }, I._fixTitle = function () { var t = typeof this.element.getAttribute(\""data-original-title\""); (this.element.getAttribute(\""title\"") || \""string\"" !== t) && (this.element.setAttribute(\""data-original-title\"", this.element.getAttribute(\""title\"") || \""\""), this.element.setAttribute(\""title\"", \""\"")) }, I._enter = function (e, n) { var i = this.constructor.DATA_KEY; (n = n || t(e.currentTarget).data(i)) || (n = new this.constructor(e.currentTarget, this._getDelegateConfig()), t(e.currentTarget).data(i, n)), e && (n._activeTrigger[\""focusin\"" === e.type ? T : E] = !0), t(n.getTipElement()).hasClass(p) || n._hoverState === f ? n._hoverState = f : (clearTimeout(n._timeout), n._hoverState = f, n.config.delay && n.config.delay.show ? n._timeout = setTimeout(function () { n._hoverState === f && n.show() }, n.config.delay.show) : n.show()) }, I._leave = function (e, n) { var i = this.constructor.DATA_KEY; (n = n || t(e.currentTarget).data(i)) || (n = new this.constructor(e.currentTarget, this._getDelegateConfig()), t(e.currentTarget).data(i, n)), e && (n._activeTrigger[\""focusout\"" === e.type ? T : E] = !1), n._isWithActiveTrigger() || (clearTimeout(n._timeout), n._hoverState = d, n.config.delay && n.config.delay.hide ? n._timeout = setTimeout(function () { n._hoverState === d && n.hide() }, n.config.delay.hide) : n.hide()) }, I._isWithActiveTrigger = function () { for (var t in this._activeTrigger) if (this._activeTrigger[t]) return !0; return !1 }, I._getConfig = function (n) { return \""number\"" == typeof (n = r({}, this.constructor.Default, t(this.element).data(), n)).delay && (n.delay = { show: n.delay, hide: n.delay }), \""number\"" == typeof n.title && (n.title = n.title.toString()), \""number\"" == typeof n.content && (n.content = n.content.toString()), P.typeCheckConfig(e, n, this.constructor.DefaultType), n }, I._getDelegateConfig = function () { var t = {}; if (this.config) for (var e in this.config) this.constructor.Default[e] !== this.config[e] && (t[e] = this.config[e]); return t }, I._cleanTipClass = function () { var e = t(this.getTipElement()), n = e.attr(\""class\"").match(l); null !== n && n.length > 0 && e.removeClass(n.join(\""\"")) }, I._handlePopperPlacementChange = function (t) { this._cleanTipClass(), this.addAttachmentClass(this._getAttachment(t.placement)) }, I._fixTransition = function () { var e = this.getTipElement(), n = this.config.animation; null === e.getAttribute(\""x-placement\"") && (t(e).removeClass(g), this.config.animation = !1, this.hide(), this.show(), this.config.animation = n) }, a._jQueryInterface = function (e) { return this.each(function () { var n = t(this).data(i), s = \""object\"" == typeof e && e; if ((n || !/dispose|hide/.test(e)) && (n || (n = new a(this, s), t(this).data(i, n)), \""string\"" == typeof e)) { if (\""undefined\"" == typeof n[e]) throw new TypeError('No method named \""' + e + '\""'); n[e]() } }) }, s(a, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }, { key: \""Default\"", get: function () { return u } }, { key: \""NAME\"", get: function () { return e } }, { key: \""DATA_KEY\"", get: function () { return i } }, { key: \""Event\"", get: function () { return _ } }, { key: \""EVENT_KEY\"", get: function () { return o } }, { key: \""DefaultType\"", get: function () { return h } }]), a }(); return t.fn[e] = I._jQueryInterface, t.fn[e].Constructor = I, t.fn[e].noConflict = function () { return t.fn[e] = a, I._jQueryInterface }, I }(e), x = function (t) { var e = \""popover\"", n = \""bs.popover\"", i = \"".\"" + n, o = t.fn[e], a = new RegExp(\""(^|\\\\s)bs-popover\\\\S+\"", \""g\""), l = r({}, U.Default, { placement: \""right\"", trigger: \""click\"", content: \""\"", template: '<div class=\""popover\"" role=\""tooltip\""><div class=\""arrow\""></div><h3 class=\""popover-header\""></h3><div class=\""popover-body\""></div></div>' }), h = r({}, U.DefaultType, { content: \""(string|element|function)\"" }), c = \""fade\"", u = \""show\"", f = \"".popover-header\"", d = \"".popover-body\"", _ = { HIDE: \""hide\"" + i, HIDDEN: \""hidden\"" + i, SHOW: \""show\"" + i, SHOWN: \""shown\"" + i, INSERTED: \""inserted\"" + i, CLICK: \""click\"" + i, FOCUSIN: \""focusin\"" + i, FOCUSOUT: \""focusout\"" + i, MOUSEENTER: \""mouseenter\"" + i, MOUSELEAVE: \""mouseleave\"" + i }, g = function (r) { var o, g; function p() { return r.apply(this, arguments) || this } g = r, (o = p).prototype = Object.create(g.prototype), o.prototype.constructor = o, o.__proto__ = g; var m = p.prototype; return m.isWithContent = function () { return this.getTitle() || this._getContent() }, m.addAttachmentClass = function (e) { t(this.getTipElement()).addClass(\""bs-popover-\"" + e) }, m.getTipElement = function () { return this.tip = this.tip || t(this.config.template)[0], this.tip }, m.setContent = function () { var e = t(this.getTipElement()); this.setElementContent(e.find(f), this.getTitle()); var n = this._getContent(); \""function\"" == typeof n && (n = n.call(this.element)), this.setElementContent(e.find(d), n), e.removeClass(c + \"" \"" + u) }, m._getContent = function () { return this.element.getAttribute(\""data-content\"") || this.config.content }, m._cleanTipClass = function () { var e = t(this.getTipElement()), n = e.attr(\""class\"").match(a); null !== n && n.length > 0 && e.removeClass(n.join(\""\"")) }, p._jQueryInterface = function (e) { return this.each(function () { var i = t(this).data(n), s = \""object\"" == typeof e ? e : null; if ((i || !/destroy|hide/.test(e)) && (i || (i = new p(this, s), t(this).data(n, i)), \""string\"" == typeof e)) { if (\""undefined\"" == typeof i[e]) throw new TypeError('No method named \""' + e + '\""'); i[e]() } }) }, s(p, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }, { key: \""Default\"", get: function () { return l } }, { key: \""NAME\"", get: function () { return e } }, { key: \""DATA_KEY\"", get: function () { return n } }, { key: \""Event\"", get: function () { return _ } }, { key: \""EVENT_KEY\"", get: function () { return i } }, { key: \""DefaultType\"", get: function () { return h } }]), p }(U); return t.fn[e] = g._jQueryInterface, t.fn[e].Constructor = g, t.fn[e].noConflict = function () { return t.fn[e] = o, g._jQueryInterface }, g }(e), K = function (t) { var e = \""scrollspy\"", n = \""bs.scrollspy\"", i = \"".\"" + n, o = t.fn[e], a = { offset: 10, method: \""auto\"", target: \""\"" }, l = { offset: \""number\"", method: \""string\"", target: \""(string|element)\"" }, h = { ACTIVATE: \""activate\"" + i, SCROLL: \""scroll\"" + i, LOAD_DATA_API: \""load\"" + i + \"".data-api\"" }, c = \""dropdown-item\"", u = \""active\"", f = { DATA_SPY: '[data-spy=\""scroll\""]', ACTIVE: \"".active\"", NAV_LIST_GROUP: \"".nav, .list-group\"", NAV_LINKS: \"".nav-link\"", NAV_ITEMS: \"".nav-item\"", LIST_ITEMS: \"".list-group-item\"", DROPDOWN: \"".dropdown\"", DROPDOWN_ITEMS: \"".dropdown-item\"", DROPDOWN_TOGGLE: \"".dropdown-toggle\"" }, d = \""offset\"", _ = \""position\"", g = function () { function o(e, n) { var i = this; this._element = e, this._scrollElement = \""BODY\"" === e.tagName ? window : e, this._config = this._getConfig(n), this._selector = this._config.target + \"" \"" + f.NAV_LINKS + \"",\"" + this._config.target + \"" \"" + f.LIST_ITEMS + \"",\"" + this._config.target + \"" \"" + f.DROPDOWN_ITEMS, this._offsets = [], this._targets = [], this._activeTarget = null, this._scrollHeight = 0, t(this._scrollElement).on(h.SCROLL, function (t) { return i._process(t) }), this.refresh(), this._process() } var g = o.prototype; return g.refresh = function () { var e = this, n = this._scrollElement === this._scrollElement.window ? d : _, i = \""auto\"" === this._config.method ? n : this._config.method, s = i === _ ? this._getScrollTop() : 0; this._offsets = [], this._targets = [], this._scrollHeight = this._getScrollHeight(), t.makeArray(t(this._selector)).map(function (e) { var n, r = P.getSelectorFromElement(e); if (r && (n = t(r)[0]), n) { var o = n.getBoundingClientRect(); if (o.width || o.height) return [t(n)[i]().top + s, r] } return null }).filter(function (t) { return t }).sort(function (t, e) { return t[0] - e[0] }).forEach(function (t) { e._offsets.push(t[0]), e._targets.push(t[1]) }) }, g.dispose = function () { t.removeData(this._element, n), t(this._scrollElement).off(i), this._element = null, this._scrollElement = null, this._config = null, this._selector = null, this._offsets = null, this._targets = null, this._activeTarget = null, this._scrollHeight = null }, g._getConfig = function (n) { if (\""string\"" != typeof (n = r({}, a, n)).target) { var i = t(n.target).attr(\""id\""); i || (i = P.getUID(e), t(n.target).attr(\""id\"", i)), n.target = \""#\"" + i } return P.typeCheckConfig(e, n, l), n }, g._getScrollTop = function () { return this._scrollElement === window ? this._scrollElement.pageYOffset : this._scrollElement.scrollTop }, g._getScrollHeight = function () { return this._scrollElement.scrollHeight || Math.max(document.body.scrollHeight, document.documentElement.scrollHeight) }, g._getOffsetHeight = function () { return this._scrollElement === window ? window.innerHeight : this._scrollElement.getBoundingClientRect().height }, g._process = function () { var t = this._getScrollTop() + this._config.offset, e = this._getScrollHeight(), n = this._config.offset + e - this._getOffsetHeight(); if (this._scrollHeight !== e && this.refresh(), t >= n) { var i = this._targets[this._targets.length - 1]; this._activeTarget !== i && this._activate(i) } else { if (this._activeTarget && t < this._offsets[0] && this._offsets[0] > 0) return this._activeTarget = null, void this._clear(); for (var s = this._offsets.length; s--;) { this._activeTarget !== this._targets[s] && t >= this._offsets[s] && (\""undefined\"" == typeof this._offsets[s + 1] || t < this._offsets[s + 1]) && this._activate(this._targets[s]) } } }, g._activate = function (e) { this._activeTarget = e, this._clear(); var n = this._selector.split(\"",\""); n = n.map(function (t) { return t + '[data-target=\""' + e + '\""],' + t + '[href=\""' + e + '\""]' }); var i = t(n.join(\"",\"")); i.hasClass(c) ? (i.closest(f.DROPDOWN).find(f.DROPDOWN_TOGGLE).addClass(u), i.addClass(u)) : (i.addClass(u), i.parents(f.NAV_LIST_GROUP).prev(f.NAV_LINKS + \"", \"" + f.LIST_ITEMS).addClass(u), i.parents(f.NAV_LIST_GROUP).prev(f.NAV_ITEMS).children(f.NAV_LINKS).addClass(u)), t(this._scrollElement).trigger(h.ACTIVATE, { relatedTarget: e }) }, g._clear = function () { t(this._selector).filter(f.ACTIVE).removeClass(u) }, o._jQueryInterface = function (e) { return this.each(function () { var i = t(this).data(n); if (i || (i = new o(this, \""object\"" == typeof e && e), t(this).data(n, i)), \""string\"" == typeof e) { if (\""undefined\"" == typeof i[e]) throw new TypeError('No method named \""' + e + '\""'); i[e]() } }) }, s(o, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }, { key: \""Default\"", get: function () { return a } }]), o }(); return t(window).on(h.LOAD_DATA_API, function () { for (var e = t.makeArray(t(f.DATA_SPY)), n = e.length; n--;) { var i = t(e[n]); g._jQueryInterface.call(i, i.data()) } }), t.fn[e] = g._jQueryInterface, t.fn[e].Constructor = g, t.fn[e].noConflict = function () { return t.fn[e] = o, g._jQueryInterface }, g }(e), V = function (t) { var e = \""bs.tab\"", n = \"".\"" + e, i = t.fn.tab, r = { HIDE: \""hide\"" + n, HIDDEN: \""hidden\"" + n, SHOW: \""show\"" + n, SHOWN: \""shown\"" + n, CLICK_DATA_API: \""click.bs.tab.data-api\"" }, o = \""dropdown-menu\"", a = \""active\"", l = \""disabled\"", h = \""fade\"", c = \""show\"", u = \"".dropdown\"", f = \"".nav, .list-group\"", d = \"".active\"", _ = \""> li > .active\"", g = '[data-toggle=\""tab\""], [data-toggle=\""pill\""], [data-toggle=\""list\""]', p = \"".dropdown-toggle\"", m = \""> .dropdown-menu .active\"", v = function () { function n(t) { this._element = t } var i = n.prototype; return i.show = function () { var e = this; if (!(this._element.parentNode && this._element.parentNode.nodeType === Node.ELEMENT_NODE && t(this._element).hasClass(a) || t(this._element).hasClass(l))) { var n, i, s = t(this._element).closest(f)[0], o = P.getSelectorFromElement(this._element); if (s) { var h = \""UL\"" === s.nodeName ? _ : d; i = (i = t.makeArray(t(s).find(h)))[i.length - 1] } var c = t.Event(r.HIDE, { relatedTarget: this._element }), u = t.Event(r.SHOW, { relatedTarget: i }); if (i && t(i).trigger(c), t(this._element).trigger(u), !u.isDefaultPrevented() && !c.isDefaultPrevented()) { o && (n = t(o)[0]), this._activate(this._element, s); var g = function () { var n = t.Event(r.HIDDEN, { relatedTarget: e._element }), s = t.Event(r.SHOWN, { relatedTarget: i }); t(i).trigger(n), t(e._element).trigger(s) }; n ? this._activate(n, n.parentNode, g) : g() } } }, i.dispose = function () { t.removeData(this._element, e), this._element = null }, i._activate = function (e, n, i) { var s = this, r = (\""UL\"" === n.nodeName ? t(n).find(_) : t(n).children(d))[0], o = i && P.supportsTransitionEnd() && r && t(r).hasClass(h), a = function () { return s._transitionComplete(e, r, i) }; r && o ? t(r).one(P.TRANSITION_END, a).emulateTransitionEnd(150) : a() }, i._transitionComplete = function (e, n, i) { if (n) { t(n).removeClass(c + \"" \"" + a); var s = t(n.parentNode).find(m)[0]; s && t(s).removeClass(a), \""tab\"" === n.getAttribute(\""role\"") && n.setAttribute(\""aria-selected\"", !1) } if (t(e).addClass(a), \""tab\"" === e.getAttribute(\""role\"") && e.setAttribute(\""aria-selected\"", !0), P.reflow(e), t(e).addClass(c), e.parentNode && t(e.parentNode).hasClass(o)) { var r = t(e).closest(u)[0]; r && t(r).find(p).addClass(a), e.setAttribute(\""aria-expanded\"", !0) } i && i() }, n._jQueryInterface = function (i) { return this.each(function () { var s = t(this), r = s.data(e); if (r || (r = new n(this), s.data(e, r)), \""string\"" == typeof i) { if (\""undefined\"" == typeof r[i]) throw new TypeError('No method named \""' + i + '\""'); r[i]() } }) }, s(n, null, [{ key: \""VERSION\"", get: function () { return \""4.0.0\"" } }]), n }(); return t(document).on(r.CLICK_DATA_API, g, function (e) { e.preventDefault(), v._jQueryInterface.call(t(this), \""show\"") }), t.fn.tab = v._jQueryInterface, t.fn.tab.Constructor = v, t.fn.tab.noConflict = function () { return t.fn.tab = i, v._jQueryInterface }, v }(e); !function (t) { if (\""undefined\"" == typeof t) throw new TypeError(\""Bootstrap's JavaScript requires jQuery. jQuery must be included before Bootstrap's JavaScript.\""); var e = t.fn.jquery.split(\"" \"")[0].split(\"".\""); if (e[0] < 2 && e[1] < 9 || 1 === e[0] && 9 === e[1] && e[2] < 1 || e[0] >= 4) throw new Error(\""Bootstrap's JavaScript requires at least jQuery v1.9.1 but less than v4.0.0\"") }(e), t.Util = P, t.Alert = L, t.Button = R, t.Carousel = j, t.Collapse = H, t.Dropdown = W, t.Modal = M, t.Popover = x, t.Scrollspy = K, t.Tab = V, t.Tooltip = U, Object.defineProperty(t, \""__esModule\"", { value: !0 }) });\n//# sourceMappingURL=bootstrap.min.js.map
    </script>
</head>
<body>
  <nav class=\""navbar navbar-dark bg-dark\"">
      <h1 style=\""color:white\"">taskt</h1><small style=\""color:white\"">free and open-source process automation</small>
  </nav>
  <br />
  <div class=\""container\"">
    <h5><b>Directions:</b> This a sample data collection form that can be presented to a user.  You can add and implement as many fields as you need or choose standard form inputs. Note, each field will require a <b>v_applyToVariable</b> attribute specifying which variable should contain the respective value for the input field.</h5>

    <hr />
    <form>
      <div class=\""form-row\"">
        <div class=\""form-group col-md-6\"">
          <label for=\""inputEmail4\"">Email</label>
          <input type=\""email\"" class=\""form-control\"" id=\""inputEmail4\"" v_applyToVariable=\""vInput\"" placeholder=\""Email\"">
        </div>
        <div class=\""form-group col-md-6\"">
          <label for=\""inputPassword4\"">Password</label>
          <input type=\""password\"" class=\""form-control\"" id=\""inputPassword4\"" v_applyToVariable=\""vPass\"" placeholder=\""Password\"">
        </div>
      </div>
      <div class=\""form-group\"">
        <label for=\""inputAddress\"">Address</label>
        <input type=\""text\"" class=\""form-control\"" id=\""inputAddress\"" v_applyToVariable=\""vAddress\"" placeholder=\""1234 Main St\"">
      </div>
      <div class=\""form-group\"">
        <label for=\""inputAddress2\"">Address 2</label>
        <input type=\""text\"" class=\""form-control\"" id=\""inputAddress2\"" v_applyToVariable=\""vAddress2\"" placeholder=\""Apartment, studio, or floor\"">
      </div>
      <div class=\""form-row\"">
        <div class=\""form-group col-md-6\"">
          <label for=\""inputCity\"">City</label>
          <input type=\""text\"" class=\""form-control\"" id=\""inputCity\"" v_applyToVariable=\""vCity\"">
        </div>
        <div class=\""form-group col-md-4\"">
          <label for=\""inputState\"">State</label>
          <input type=\""text\"" class=\""form-control\"" id=\""inputState\"" v_applyToVariable=\""vState\"">
        </div>
        <div class=\""form-group col-md-2\"">
          <label for=\""inputZip\"">Zip</label>
          <input type=\""text\"" class=\""form-control\"" id=\""inputZip\"" v_applyToVariable=\""vZip\"">
        </div>
      </div>
      <div class=\""form-group\"">
        <div class=\""form-check\"">
          <input class=\""form-check-input\"" type=\""checkbox\"" id=\""gridCheck\"" v_applyToVariable=\""vCheck\"">
          <label class=\""form-check-label\"" for=\""gridCheck\"">
              Check me out
          </label>
        </div>
      </div>
      <div class=\""form-group\"">
        <label for=\""exampleFormControlSelect1\"">Example select</label>
        <select class=\""form-control\"" id=\""exampleFormControlSelect1\"" v_applyToVariable=\""vSelected\"">
          <option>1</option>
          <option>2</option>
          <option>3</option>
          <option>4</option>
          <option>5</option>
        </select>
      </div>
      <button class=\""btn btn-primary\"" onclick=\""window.external.Ok();\"">Ok</button>
      <button class=\""btn btn-primary\"" onclick=\""window.external.Cancel();\"">Close</button>
    </form>
  </div>
</body>
</html>")]
        public string v_InputHTML { get; set; }

        [XmlAttribute]
        [PropertyVirtualProperty(nameof(GeneralPropertyControls), nameof(GeneralPropertyControls.v_ComboBox))]
        [PropertyDescription("When an Error should Occur on any Result other than 'OK'")]
        [PropertyUISelectionOption("Error On Close")]
        [PropertyUISelectionOption("Do Not Error On Close")]
        [PropertyIsOptional(true, "Error On Close")]
        public string v_ErrorOnClose { get; set; }

        public ShowHTMLInputDialogCommand()
        {
            //this.CommandName = "HTMLInputCommand";
            //this.SelectionName = "Prompt for HTML Input";
            //this.CommandEnabled = true;
            //this.CustomRendering = true;
            //this.v_InputHTML = "<!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>Please Provide Information</title>\r\n\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" integrity=\"sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm\" crossorigin=\"anonymous\">\r\n    <script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js\" integrity=\"sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl\" crossorigin=\"anonymous\"></script>\r\n\r\n</head>\r\n<body>\r\n\r\n    <nav class=\"navbar navbar-dark bg-dark\">\r\n        <h1 style=\"color:white\">taskt</h1><small style=\"color:white\">free and open-source process automation</small>\r\n    </nav>\r\n    <br />\r\n\r\n\r\n    <div class=\"container\">\r\n\r\n        <h5><b>Directions:</b> This a sample data collection form that can be presented to a user.  You can add and implement as many fields as you need or choose standard form inputs. Note, each field will require a <b>v_applyToVariable</b> attribute specifying which variable should contain the respective value for the input field.</h5>\r\n\r\n        <hr />\r\n        <form>\r\n            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"inputEmail4\">Email</label>\r\n                    <input type=\"email\" class=\"form-control\" id=\"inputEmail4\" v_applyToVariable=\"vInput\" placeholder=\"Email\">\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"inputPassword4\">Password</label>\r\n                    <input type=\"password\" class=\"form-control\" id=\"inputPassword4\" v_applyToVariable=\"vPass\" placeholder=\"Password\">\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"inputAddress\">Address</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"inputAddress\" v_applyToVariable=\"vAddress\" placeholder=\"1234 Main St\">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"inputAddress2\">Address 2</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" v_applyToVariable=\"vAddress2\" placeholder=\"Apartment, studio, or floor\">\r\n            </div>\r\n            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"inputCity\">City</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"inputCity\" v_applyToVariable=\"vCity\">\r\n                </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    <label for=\"inputState\">State</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"inputState\" v_applyToVariable=\"vState\">\r\n                </div>\r\n                <div class=\"form-group col-md-2\">\r\n                    <label for=\"inputZip\">Zip</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"inputZip\" v_applyToVariable=\"vZip\">\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"form-check\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\" id=\"gridCheck\" v_applyToVariable=\"vCheck\">\r\n                    <label class=\"form-check-label\" for=\"gridCheck\">\r\n                        Check me out\r\n                    </label>\r\n                </div>\r\n            </div>\r\n            <button class=\"btn btn-primary\" onclick=\"window.external.Ok();\">Ok</button>\r\n            <button class=\"btn btn-primary\" onclick=\"window.external.Cancel();\">Close</button>\r\n        </form>\r\n    </div>\r\n\r\n</body>\r\n</html>";
            //this.v_InputHTML = "<!DOCTYPE html>\r\n\r\n<html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>Please Provide Information</title>\r\n\r\n    <style type=\"text/css\">\r\n        /*!\n * Bootstrap v4.0.0 (https://getbootstrap.com)\n * Copyright 2011-2018 The Bootstrap Authors\n * Copyright 2011-2018 Twitter, Inc.\n * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)\n */ :root {\r\n            --blue: #007bff;\r\n            --indigo: #6610f2;\r\n            --purple: #6f42c1;\r\n            --pink: #e83e8c;\r\n            --red: #dc3545;\r\n            --orange: #fd7e14;\r\n            --yellow: #ffc107;\r\n            --green: #28a745;\r\n            --teal: #20c997;\r\n            --cyan: #17a2b8;\r\n            --white: #fff;\r\n            --gray: #6c757d;\r\n            --gray-dark: #343a40;\r\n            --primary: #007bff;\r\n            --secondary: #6c757d;\r\n            --success: #28a745;\r\n            --info: #17a2b8;\r\n            --warning: #ffc107;\r\n            --danger: #dc3545;\r\n            --light: #f8f9fa;\r\n            --dark: #343a40;\r\n            --breakpoint-xs: 0;\r\n            --breakpoint-sm: 576px;\r\n            --breakpoint-md: 768px;\r\n            --breakpoint-lg: 992px;\r\n            --breakpoint-xl: 1200px;\r\n            --font-family-sans-serif: -apple-system,BlinkMacSystemFont,\"Segoe UI\",Roboto,\"Helvetica Neue\",Arial,sans-serif,\"Apple Color Emoji\",\"Segoe UI Emoji\",\"Segoe UI Symbol\";\r\n            --font-family-monospace: SFMono-Regular,Menlo,Monaco,Consolas,\"Liberation Mono\",\"Courier New\",monospace\r\n        }\r\n\r\n        *, ::after, ::before {\r\n            box-sizing: border-box\r\n        }\r\n\r\n        html {\r\n            font-family: sans-serif;\r\n            line-height: 1.15;\r\n            -webkit-text-size-adjust: 100%;\r\n            -ms-text-size-adjust: 100%;\r\n            -ms-overflow-style: scrollbar;\r\n            -webkit-tap-highlight-color: transparent\r\n        }\r\n\r\n        @-ms-viewport {\r\n            width: device-width\r\n        }\r\n\r\n        article, aside, dialog, figcaption, figure, footer, header, hgroup, main, nav, section {\r\n            display: block\r\n        }\r\n\r\n        body {\r\n            margin: 0;\r\n            font-family: -apple-system,BlinkMacSystemFont,\"Segoe UI\",Roboto,\"Helvetica Neue\",Arial,sans-serif,\"Apple Color Emoji\",\"Segoe UI Emoji\",\"Segoe UI Symbol\";\r\n            font-size: 1rem;\r\n            font-weight: 400;\r\n            line-height: 1.5;\r\n            color: #212529;\r\n            text-align: left;\r\n            background-color: #fff\r\n        }\r\n\r\n        [tabindex=\"-1\"]:focus {\r\n            outline: 0 !important\r\n        }\r\n\r\n        hr {\r\n            box-sizing: content-box;\r\n            height: 0;\r\n            overflow: visible\r\n        }\r\n\r\n        h1, h2, h3, h4, h5, h6 {\r\n            margin-top: 0;\r\n            margin-bottom: .5rem\r\n        }\r\n\r\n        p {\r\n            margin-top: 0;\r\n            margin-bottom: 1rem\r\n        }\r\n\r\n        abbr[data-original-title], abbr[title] {\r\n            text-decoration: underline;\r\n            -webkit-text-decoration: underline dotted;\r\n            text-decoration: underline dotted;\r\n            cursor: help;\r\n            border-bottom: 0\r\n        }\r\n\r\n        address {\r\n            margin-bottom: 1rem;\r\n            font-style: normal;\r\n            line-height: inherit\r\n        }\r\n\r\n        dl, ol, ul {\r\n            margin-top: 0;\r\n            margin-bottom: 1rem\r\n        }\r\n\r\n            ol ol, ol ul, ul ol, ul ul {\r\n                margin-bottom: 0\r\n            }\r\n\r\n        dt {\r\n            font-weight: 700\r\n        }\r\n\r\n        dd {\r\n            margin-bottom: .5rem;\r\n            margin-left: 0\r\n        }\r\n\r\n        blockquote {\r\n            margin: 0 0 1rem\r\n        }\r\n\r\n        dfn {\r\n            font-style: italic\r\n        }\r\n\r\n        b, strong {\r\n            font-weight: bolder\r\n        }\r\n\r\n        small {\r\n            font-size: 80%\r\n        }\r\n\r\n        sub, sup {\r\n            position: relative;\r\n            font-size: 75%;\r\n            line-height: 0;\r\n            vertical-align: baseline\r\n        }\r\n\r\n        sub {\r\n            bottom: -.25em\r\n        }\r\n\r\n        sup {\r\n            top: -.5em\r\n        }\r\n\r\n        a {\r\n            color: #007bff;\r\n            text-decoration: none;\r\n            background-color: transparent;\r\n            -webkit-text-decoration-skip: objects\r\n        }\r\n\r\n            a:hover {\r\n                color: #0056b3;\r\n                text-decoration: underline\r\n            }\r\n\r\n            a:not([href]):not([tabindex]) {\r\n                color: inherit;\r\n                text-decoration: none\r\n            }\r\n\r\n                a:not([href]):not([tabindex]):focus, a:not([href]):not([tabindex]):hover {\r\n                    color: inherit;\r\n                    text-decoration: none\r\n                }\r\n\r\n                a:not([href]):not([tabindex]):focus {\r\n                    outline: 0\r\n                }\r\n\r\n        code, kbd, pre, samp {\r\n            font-family: monospace,monospace;\r\n            font-size: 1em\r\n        }\r\n\r\n        pre {\r\n            margin-top: 0;\r\n            margin-bottom: 1rem;\r\n            overflow: auto;\r\n            -ms-overflow-style: scrollbar\r\n        }\r\n\r\n        figure {\r\n            margin: 0 0 1rem\r\n        }\r\n\r\n        img {\r\n            vertical-align: middle;\r\n            border-style: none\r\n        }\r\n\r\n        svg:not(:root) {\r\n            overflow: hidden\r\n        }\r\n\r\n        table {\r\n            border-collapse: collapse\r\n        }\r\n\r\n        caption {\r\n            padding-top: .75rem;\r\n            padding-bottom: .75rem;\r\n            color: #6c757d;\r\n            text-align: left;\r\n            caption-side: bottom\r\n        }\r\n\r\n        th {\r\n            text-align: inherit\r\n        }\r\n\r\n        label {\r\n            display: inline-block;\r\n            margin-bottom: .5rem\r\n        }\r\n\r\n        button {\r\n            border-radius: 0\r\n        }\r\n\r\n            button:focus {\r\n                outline: 1px dotted;\r\n                outline: 5px auto -webkit-focus-ring-color\r\n            }\r\n\r\n        button, input, optgroup, select, textarea {\r\n            margin: 0;\r\n            font-family: inherit;\r\n            font-size: inherit;\r\n            line-height: inherit\r\n        }\r\n\r\n        button, input {\r\n            overflow: visible\r\n        }\r\n\r\n        button, select {\r\n            text-transform: none\r\n        }\r\n\r\n        [type=reset], [type=submit], button, html [type=button] {\r\n            -webkit-appearance: button\r\n        }\r\n\r\n            [type=button]::-moz-focus-inner, [type=reset]::-moz-focus-inner, [type=submit]::-moz-focus-inner, button::-moz-focus-inner {\r\n                padding: 0;\r\n                border-style: none\r\n            }\r\n\r\n        input[type=checkbox], input[type=radio] {\r\n            box-sizing: border-box;\r\n            padding: 0\r\n        }\r\n\r\n        input[type=date], input[type=datetime-local], input[type=month], input[type=time] {\r\n            -webkit-appearance: listbox\r\n        }\r\n\r\n        textarea {\r\n            overflow: auto;\r\n            resize: vertical\r\n        }\r\n\r\n        fieldset {\r\n            min-width: 0;\r\n            padding: 0;\r\n            margin: 0;\r\n            border: 0\r\n        }\r\n\r\n        legend {\r\n            display: block;\r\n            width: 100%;\r\n            max-width: 100%;\r\n            padding: 0;\r\n            margin-bottom: .5rem;\r\n            font-size: 1.5rem;\r\n            line-height: inherit;\r\n            color: inherit;\r\n            white-space: normal\r\n        }\r\n\r\n        progress {\r\n            vertical-align: baseline\r\n        }\r\n\r\n        [type=number]::-webkit-inner-spin-button, [type=number]::-webkit-outer-spin-button {\r\n            height: auto\r\n        }\r\n\r\n        [type=search] {\r\n            outline-offset: -2px;\r\n            -webkit-appearance: none\r\n        }\r\n\r\n            [type=search]::-webkit-search-cancel-button, [type=search]::-webkit-search-decoration {\r\n                -webkit-appearance: none\r\n            }\r\n\r\n        ::-webkit-file-upload-button {\r\n            font: inherit;\r\n            -webkit-appearance: button\r\n        }\r\n\r\n        output {\r\n            display: inline-block\r\n        }\r\n\r\n        summary {\r\n            display: list-item;\r\n            cursor: pointer\r\n        }\r\n\r\n        template {\r\n            display: none\r\n        }\r\n\r\n        [hidden] {\r\n            display: none !important\r\n        }\r\n\r\n        .h1, .h2, .h3, .h4, .h5, .h6, h1, h2, h3, h4, h5, h6 {\r\n            margin-bottom: .5rem;\r\n            font-family: inherit;\r\n            font-weight: 500;\r\n            line-height: 1.2;\r\n            color: inherit\r\n        }\r\n\r\n        .h1, h1 {\r\n            font-size: 2.5rem\r\n        }\r\n\r\n        .h2, h2 {\r\n            font-size: 2rem\r\n        }\r\n\r\n        .h3, h3 {\r\n            font-size: 1.75rem\r\n        }\r\n\r\n        .h4, h4 {\r\n            font-size: 1.5rem\r\n        }\r\n\r\n        .h5, h5 {\r\n            font-size: 1.25rem\r\n        }\r\n\r\n        .h6, h6 {\r\n            font-size: 1rem\r\n        }\r\n\r\n        .lead {\r\n            font-size: 1.25rem;\r\n            font-weight: 300\r\n        }\r\n\r\n        .display-1 {\r\n            font-size: 6rem;\r\n            font-weight: 300;\r\n            line-height: 1.2\r\n        }\r\n\r\n        .display-2 {\r\n            font-size: 5.5rem;\r\n            font-weight: 300;\r\n            line-height: 1.2\r\n        }\r\n\r\n        .display-3 {\r\n            font-size: 4.5rem;\r\n            font-weight: 300;\r\n            line-height: 1.2\r\n        }\r\n\r\n        .display-4 {\r\n            font-size: 3.5rem;\r\n            font-weight: 300;\r\n            line-height: 1.2\r\n        }\r\n\r\n        hr {\r\n            margin-top: 1rem;\r\n            margin-bottom: 1rem;\r\n            border: 0;\r\n            border-top: 1px solid rgba(0,0,0,.1)\r\n        }\r\n\r\n        .small, small {\r\n            font-size: 80%;\r\n            font-weight: 400\r\n        }\r\n\r\n        .mark, mark {\r\n            padding: .2em;\r\n            background-color: #fcf8e3\r\n        }\r\n\r\n        .list-unstyled {\r\n            padding-left: 0;\r\n            list-style: none\r\n        }\r\n\r\n        .list-inline {\r\n            padding-left: 0;\r\n            list-style: none\r\n        }\r\n\r\n        .list-inline-item {\r\n            display: inline-block\r\n        }\r\n\r\n            .list-inline-item:not(:last-child) {\r\n                margin-right: .5rem\r\n            }\r\n\r\n        .initialism {\r\n            font-size: 90%;\r\n            text-transform: uppercase\r\n        }\r\n\r\n        .blockquote {\r\n            margin-bottom: 1rem;\r\n            font-size: 1.25rem\r\n        }\r\n\r\n        .blockquote-footer {\r\n            display: block;\r\n            font-size: 80%;\r\n            color: #6c757d\r\n        }\r\n\r\n            .blockquote-footer::before {\r\n                content: \"\\2014 \\00A0\"\r\n            }\r\n\r\n        .img-fluid {\r\n            max-width: 100%;\r\n            height: auto\r\n        }\r\n\r\n        .img-thumbnail {\r\n            padding: .25rem;\r\n            background-color: #fff;\r\n            border: 1px solid #dee2e6;\r\n            border-radius: .25rem;\r\n            max-width: 100%;\r\n            height: auto\r\n        }\r\n\r\n        .figure {\r\n            display: inline-block\r\n        }\r\n\r\n        .figure-img {\r\n            margin-bottom: .5rem;\r\n            line-height: 1\r\n        }\r\n\r\n        .figure-caption {\r\n            font-size: 90%;\r\n            color: #6c757d\r\n        }\r\n\r\n        code, kbd, pre, samp {\r\n            font-family: SFMono-Regular,Menlo,Monaco,Consolas,\"Liberation Mono\",\"Courier New\",monospace\r\n        }\r\n\r\n        code {\r\n            font-size: 87.5%;\r\n            color: #e83e8c;\r\n            word-break: break-word\r\n        }\r\n\r\n        a > code {\r\n            color: inherit\r\n        }\r\n\r\n        kbd {\r\n            padding: .2rem .4rem;\r\n            font-size: 87.5%;\r\n            color: #fff;\r\n            background-color: #212529;\r\n            border-radius: .2rem\r\n        }\r\n\r\n            kbd kbd {\r\n                padding: 0;\r\n                font-size: 100%;\r\n                font-weight: 700\r\n            }\r\n\r\n        pre {\r\n            display: block;\r\n            font-size: 87.5%;\r\n            color: #212529\r\n        }\r\n\r\n            pre code {\r\n                font-size: inherit;\r\n                color: inherit;\r\n                word-break: normal\r\n            }\r\n\r\n        .pre-scrollable {\r\n            max-height: 340px;\r\n            overflow-y: scroll\r\n        }\r\n\r\n        .container {\r\n            width: 100%;\r\n            padding-right: 15px;\r\n            padding-left: 15px;\r\n            margin-right: auto;\r\n            margin-left: auto\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .container {\r\n                max-width: 540px\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .container {\r\n                max-width: 720px\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .container {\r\n                max-width: 960px\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .container {\r\n                max-width: 1140px\r\n            }\r\n        }\r\n\r\n        .container-fluid {\r\n            width: 100%;\r\n            padding-right: 15px;\r\n            padding-left: 15px;\r\n            margin-right: auto;\r\n            margin-left: auto\r\n        }\r\n\r\n        .row {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -ms-flex-wrap: wrap;\r\n            flex-wrap: wrap;\r\n            margin-right: -15px;\r\n            margin-left: -15px\r\n        }\r\n\r\n        .no-gutters {\r\n            margin-right: 0;\r\n            margin-left: 0\r\n        }\r\n\r\n            .no-gutters > .col, .no-gutters > [class*=col-] {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n\r\n        .col, .col-1, .col-10, .col-11, .col-12, .col-2, .col-3, .col-4, .col-5, .col-6, .col-7, .col-8, .col-9, .col-auto, .col-lg, .col-lg-1, .col-lg-10, .col-lg-11, .col-lg-12, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-auto, .col-md, .col-md-1, .col-md-10, .col-md-11, .col-md-12, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-auto, .col-sm, .col-sm-1, .col-sm-10, .col-sm-11, .col-sm-12, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-auto, .col-xl, .col-xl-1, .col-xl-10, .col-xl-11, .col-xl-12, .col-xl-2, .col-xl-3, .col-xl-4, .col-xl-5, .col-xl-6, .col-xl-7, .col-xl-8, .col-xl-9, .col-xl-auto {\r\n            position: relative;\r\n            width: 100%;\r\n            min-height: 1px;\r\n            padding-right: 15px;\r\n            padding-left: 15px\r\n        }\r\n\r\n        .col {\r\n            -ms-flex-preferred-size: 0;\r\n            flex-basis: 0;\r\n            -webkit-box-flex: 1;\r\n            -ms-flex-positive: 1;\r\n            flex-grow: 1;\r\n            max-width: 100%\r\n        }\r\n\r\n        .col-auto {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 auto;\r\n            flex: 0 0 auto;\r\n            width: auto;\r\n            max-width: none\r\n        }\r\n\r\n        .col-1 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 8.333333%;\r\n            flex: 0 0 8.333333%;\r\n            max-width: 8.333333%\r\n        }\r\n\r\n        .col-2 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 16.666667%;\r\n            flex: 0 0 16.666667%;\r\n            max-width: 16.666667%\r\n        }\r\n\r\n        .col-3 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 25%;\r\n            flex: 0 0 25%;\r\n            max-width: 25%\r\n        }\r\n\r\n        .col-4 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 33.333333%;\r\n            flex: 0 0 33.333333%;\r\n            max-width: 33.333333%\r\n        }\r\n\r\n        .col-5 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 41.666667%;\r\n            flex: 0 0 41.666667%;\r\n            max-width: 41.666667%\r\n        }\r\n\r\n        .col-6 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 50%;\r\n            flex: 0 0 50%;\r\n            max-width: 50%\r\n        }\r\n\r\n        .col-7 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 58.333333%;\r\n            flex: 0 0 58.333333%;\r\n            max-width: 58.333333%\r\n        }\r\n\r\n        .col-8 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 66.666667%;\r\n            flex: 0 0 66.666667%;\r\n            max-width: 66.666667%\r\n        }\r\n\r\n        .col-9 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 75%;\r\n            flex: 0 0 75%;\r\n            max-width: 75%\r\n        }\r\n\r\n        .col-10 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 83.333333%;\r\n            flex: 0 0 83.333333%;\r\n            max-width: 83.333333%\r\n        }\r\n\r\n        .col-11 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 91.666667%;\r\n            flex: 0 0 91.666667%;\r\n            max-width: 91.666667%\r\n        }\r\n\r\n        .col-12 {\r\n            -webkit-box-flex: 0;\r\n            -ms-flex: 0 0 100%;\r\n            flex: 0 0 100%;\r\n            max-width: 100%\r\n        }\r\n\r\n        .order-first {\r\n            -webkit-box-ordinal-group: 0;\r\n            -ms-flex-order: -1;\r\n            order: -1\r\n        }\r\n\r\n        .order-last {\r\n            -webkit-box-ordinal-group: 14;\r\n            -ms-flex-order: 13;\r\n            order: 13\r\n        }\r\n\r\n        .order-0 {\r\n            -webkit-box-ordinal-group: 1;\r\n            -ms-flex-order: 0;\r\n            order: 0\r\n        }\r\n\r\n        .order-1 {\r\n            -webkit-box-ordinal-group: 2;\r\n            -ms-flex-order: 1;\r\n            order: 1\r\n        }\r\n\r\n        .order-2 {\r\n            -webkit-box-ordinal-group: 3;\r\n            -ms-flex-order: 2;\r\n            order: 2\r\n        }\r\n\r\n        .order-3 {\r\n            -webkit-box-ordinal-group: 4;\r\n            -ms-flex-order: 3;\r\n            order: 3\r\n        }\r\n\r\n        .order-4 {\r\n            -webkit-box-ordinal-group: 5;\r\n            -ms-flex-order: 4;\r\n            order: 4\r\n        }\r\n\r\n        .order-5 {\r\n            -webkit-box-ordinal-group: 6;\r\n            -ms-flex-order: 5;\r\n            order: 5\r\n        }\r\n\r\n        .order-6 {\r\n            -webkit-box-ordinal-group: 7;\r\n            -ms-flex-order: 6;\r\n            order: 6\r\n        }\r\n\r\n        .order-7 {\r\n            -webkit-box-ordinal-group: 8;\r\n            -ms-flex-order: 7;\r\n            order: 7\r\n        }\r\n\r\n        .order-8 {\r\n            -webkit-box-ordinal-group: 9;\r\n            -ms-flex-order: 8;\r\n            order: 8\r\n        }\r\n\r\n        .order-9 {\r\n            -webkit-box-ordinal-group: 10;\r\n            -ms-flex-order: 9;\r\n            order: 9\r\n        }\r\n\r\n        .order-10 {\r\n            -webkit-box-ordinal-group: 11;\r\n            -ms-flex-order: 10;\r\n            order: 10\r\n        }\r\n\r\n        .order-11 {\r\n            -webkit-box-ordinal-group: 12;\r\n            -ms-flex-order: 11;\r\n            order: 11\r\n        }\r\n\r\n        .order-12 {\r\n            -webkit-box-ordinal-group: 13;\r\n            -ms-flex-order: 12;\r\n            order: 12\r\n        }\r\n\r\n        .offset-1 {\r\n            margin-left: 8.333333%\r\n        }\r\n\r\n        .offset-2 {\r\n            margin-left: 16.666667%\r\n        }\r\n\r\n        .offset-3 {\r\n            margin-left: 25%\r\n        }\r\n\r\n        .offset-4 {\r\n            margin-left: 33.333333%\r\n        }\r\n\r\n        .offset-5 {\r\n            margin-left: 41.666667%\r\n        }\r\n\r\n        .offset-6 {\r\n            margin-left: 50%\r\n        }\r\n\r\n        .offset-7 {\r\n            margin-left: 58.333333%\r\n        }\r\n\r\n        .offset-8 {\r\n            margin-left: 66.666667%\r\n        }\r\n\r\n        .offset-9 {\r\n            margin-left: 75%\r\n        }\r\n\r\n        .offset-10 {\r\n            margin-left: 83.333333%\r\n        }\r\n\r\n        .offset-11 {\r\n            margin-left: 91.666667%\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .col-sm {\r\n                -ms-flex-preferred-size: 0;\r\n                flex-basis: 0;\r\n                -webkit-box-flex: 1;\r\n                -ms-flex-positive: 1;\r\n                flex-grow: 1;\r\n                max-width: 100%\r\n            }\r\n\r\n            .col-sm-auto {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 auto;\r\n                flex: 0 0 auto;\r\n                width: auto;\r\n                max-width: none\r\n            }\r\n\r\n            .col-sm-1 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 8.333333%;\r\n                flex: 0 0 8.333333%;\r\n                max-width: 8.333333%\r\n            }\r\n\r\n            .col-sm-2 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 16.666667%;\r\n                flex: 0 0 16.666667%;\r\n                max-width: 16.666667%\r\n            }\r\n\r\n            .col-sm-3 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 25%;\r\n                flex: 0 0 25%;\r\n                max-width: 25%\r\n            }\r\n\r\n            .col-sm-4 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 33.333333%;\r\n                flex: 0 0 33.333333%;\r\n                max-width: 33.333333%\r\n            }\r\n\r\n            .col-sm-5 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 41.666667%;\r\n                flex: 0 0 41.666667%;\r\n                max-width: 41.666667%\r\n            }\r\n\r\n            .col-sm-6 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 50%;\r\n                flex: 0 0 50%;\r\n                max-width: 50%\r\n            }\r\n\r\n            .col-sm-7 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 58.333333%;\r\n                flex: 0 0 58.333333%;\r\n                max-width: 58.333333%\r\n            }\r\n\r\n            .col-sm-8 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 66.666667%;\r\n                flex: 0 0 66.666667%;\r\n                max-width: 66.666667%\r\n            }\r\n\r\n            .col-sm-9 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 75%;\r\n                flex: 0 0 75%;\r\n                max-width: 75%\r\n            }\r\n\r\n            .col-sm-10 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 83.333333%;\r\n                flex: 0 0 83.333333%;\r\n                max-width: 83.333333%\r\n            }\r\n\r\n            .col-sm-11 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 91.666667%;\r\n                flex: 0 0 91.666667%;\r\n                max-width: 91.666667%\r\n            }\r\n\r\n            .col-sm-12 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 100%;\r\n                flex: 0 0 100%;\r\n                max-width: 100%\r\n            }\r\n\r\n            .order-sm-first {\r\n                -webkit-box-ordinal-group: 0;\r\n                -ms-flex-order: -1;\r\n                order: -1\r\n            }\r\n\r\n            .order-sm-last {\r\n                -webkit-box-ordinal-group: 14;\r\n                -ms-flex-order: 13;\r\n                order: 13\r\n            }\r\n\r\n            .order-sm-0 {\r\n                -webkit-box-ordinal-group: 1;\r\n                -ms-flex-order: 0;\r\n                order: 0\r\n            }\r\n\r\n            .order-sm-1 {\r\n                -webkit-box-ordinal-group: 2;\r\n                -ms-flex-order: 1;\r\n                order: 1\r\n            }\r\n\r\n            .order-sm-2 {\r\n                -webkit-box-ordinal-group: 3;\r\n                -ms-flex-order: 2;\r\n                order: 2\r\n            }\r\n\r\n            .order-sm-3 {\r\n                -webkit-box-ordinal-group: 4;\r\n                -ms-flex-order: 3;\r\n                order: 3\r\n            }\r\n\r\n            .order-sm-4 {\r\n                -webkit-box-ordinal-group: 5;\r\n                -ms-flex-order: 4;\r\n                order: 4\r\n            }\r\n\r\n            .order-sm-5 {\r\n                -webkit-box-ordinal-group: 6;\r\n                -ms-flex-order: 5;\r\n                order: 5\r\n            }\r\n\r\n            .order-sm-6 {\r\n                -webkit-box-ordinal-group: 7;\r\n                -ms-flex-order: 6;\r\n                order: 6\r\n            }\r\n\r\n            .order-sm-7 {\r\n                -webkit-box-ordinal-group: 8;\r\n                -ms-flex-order: 7;\r\n                order: 7\r\n            }\r\n\r\n            .order-sm-8 {\r\n                -webkit-box-ordinal-group: 9;\r\n                -ms-flex-order: 8;\r\n                order: 8\r\n            }\r\n\r\n            .order-sm-9 {\r\n                -webkit-box-ordinal-group: 10;\r\n                -ms-flex-order: 9;\r\n                order: 9\r\n            }\r\n\r\n            .order-sm-10 {\r\n                -webkit-box-ordinal-group: 11;\r\n                -ms-flex-order: 10;\r\n                order: 10\r\n            }\r\n\r\n            .order-sm-11 {\r\n                -webkit-box-ordinal-group: 12;\r\n                -ms-flex-order: 11;\r\n                order: 11\r\n            }\r\n\r\n            .order-sm-12 {\r\n                -webkit-box-ordinal-group: 13;\r\n                -ms-flex-order: 12;\r\n                order: 12\r\n            }\r\n\r\n            .offset-sm-0 {\r\n                margin-left: 0\r\n            }\r\n\r\n            .offset-sm-1 {\r\n                margin-left: 8.333333%\r\n            }\r\n\r\n            .offset-sm-2 {\r\n                margin-left: 16.666667%\r\n            }\r\n\r\n            .offset-sm-3 {\r\n                margin-left: 25%\r\n            }\r\n\r\n            .offset-sm-4 {\r\n                margin-left: 33.333333%\r\n            }\r\n\r\n            .offset-sm-5 {\r\n                margin-left: 41.666667%\r\n            }\r\n\r\n            .offset-sm-6 {\r\n                margin-left: 50%\r\n            }\r\n\r\n            .offset-sm-7 {\r\n                margin-left: 58.333333%\r\n            }\r\n\r\n            .offset-sm-8 {\r\n                margin-left: 66.666667%\r\n            }\r\n\r\n            .offset-sm-9 {\r\n                margin-left: 75%\r\n            }\r\n\r\n            .offset-sm-10 {\r\n                margin-left: 83.333333%\r\n            }\r\n\r\n            .offset-sm-11 {\r\n                margin-left: 91.666667%\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .col-md {\r\n                -ms-flex-preferred-size: 0;\r\n                flex-basis: 0;\r\n                -webkit-box-flex: 1;\r\n                -ms-flex-positive: 1;\r\n                flex-grow: 1;\r\n                max-width: 100%\r\n            }\r\n\r\n            .col-md-auto {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 auto;\r\n                flex: 0 0 auto;\r\n                width: auto;\r\n                max-width: none\r\n            }\r\n\r\n            .col-md-1 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 8.333333%;\r\n                flex: 0 0 8.333333%;\r\n                max-width: 8.333333%\r\n            }\r\n\r\n            .col-md-2 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 16.666667%;\r\n                flex: 0 0 16.666667%;\r\n                max-width: 16.666667%\r\n            }\r\n\r\n            .col-md-3 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 25%;\r\n                flex: 0 0 25%;\r\n                max-width: 25%\r\n            }\r\n\r\n            .col-md-4 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 33.333333%;\r\n                flex: 0 0 33.333333%;\r\n                max-width: 33.333333%\r\n            }\r\n\r\n            .col-md-5 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 41.666667%;\r\n                flex: 0 0 41.666667%;\r\n                max-width: 41.666667%\r\n            }\r\n\r\n            .col-md-6 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 50%;\r\n                flex: 0 0 50%;\r\n                max-width: 50%\r\n            }\r\n\r\n            .col-md-7 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 58.333333%;\r\n                flex: 0 0 58.333333%;\r\n                max-width: 58.333333%\r\n            }\r\n\r\n            .col-md-8 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 66.666667%;\r\n                flex: 0 0 66.666667%;\r\n                max-width: 66.666667%\r\n            }\r\n\r\n            .col-md-9 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 75%;\r\n                flex: 0 0 75%;\r\n                max-width: 75%\r\n            }\r\n\r\n            .col-md-10 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 83.333333%;\r\n                flex: 0 0 83.333333%;\r\n                max-width: 83.333333%\r\n            }\r\n\r\n            .col-md-11 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 91.666667%;\r\n                flex: 0 0 91.666667%;\r\n                max-width: 91.666667%\r\n            }\r\n\r\n            .col-md-12 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 100%;\r\n                flex: 0 0 100%;\r\n                max-width: 100%\r\n            }\r\n\r\n            .order-md-first {\r\n                -webkit-box-ordinal-group: 0;\r\n                -ms-flex-order: -1;\r\n                order: -1\r\n            }\r\n\r\n            .order-md-last {\r\n                -webkit-box-ordinal-group: 14;\r\n                -ms-flex-order: 13;\r\n                order: 13\r\n            }\r\n\r\n            .order-md-0 {\r\n                -webkit-box-ordinal-group: 1;\r\n                -ms-flex-order: 0;\r\n                order: 0\r\n            }\r\n\r\n            .order-md-1 {\r\n                -webkit-box-ordinal-group: 2;\r\n                -ms-flex-order: 1;\r\n                order: 1\r\n            }\r\n\r\n            .order-md-2 {\r\n                -webkit-box-ordinal-group: 3;\r\n                -ms-flex-order: 2;\r\n                order: 2\r\n            }\r\n\r\n            .order-md-3 {\r\n                -webkit-box-ordinal-group: 4;\r\n                -ms-flex-order: 3;\r\n                order: 3\r\n            }\r\n\r\n            .order-md-4 {\r\n                -webkit-box-ordinal-group: 5;\r\n                -ms-flex-order: 4;\r\n                order: 4\r\n            }\r\n\r\n            .order-md-5 {\r\n                -webkit-box-ordinal-group: 6;\r\n                -ms-flex-order: 5;\r\n                order: 5\r\n            }\r\n\r\n            .order-md-6 {\r\n                -webkit-box-ordinal-group: 7;\r\n                -ms-flex-order: 6;\r\n                order: 6\r\n            }\r\n\r\n            .order-md-7 {\r\n                -webkit-box-ordinal-group: 8;\r\n                -ms-flex-order: 7;\r\n                order: 7\r\n            }\r\n\r\n            .order-md-8 {\r\n                -webkit-box-ordinal-group: 9;\r\n                -ms-flex-order: 8;\r\n                order: 8\r\n            }\r\n\r\n            .order-md-9 {\r\n                -webkit-box-ordinal-group: 10;\r\n                -ms-flex-order: 9;\r\n                order: 9\r\n            }\r\n\r\n            .order-md-10 {\r\n                -webkit-box-ordinal-group: 11;\r\n                -ms-flex-order: 10;\r\n                order: 10\r\n            }\r\n\r\n            .order-md-11 {\r\n                -webkit-box-ordinal-group: 12;\r\n                -ms-flex-order: 11;\r\n                order: 11\r\n            }\r\n\r\n            .order-md-12 {\r\n                -webkit-box-ordinal-group: 13;\r\n                -ms-flex-order: 12;\r\n                order: 12\r\n            }\r\n\r\n            .offset-md-0 {\r\n                margin-left: 0\r\n            }\r\n\r\n            .offset-md-1 {\r\n                margin-left: 8.333333%\r\n            }\r\n\r\n            .offset-md-2 {\r\n                margin-left: 16.666667%\r\n            }\r\n\r\n            .offset-md-3 {\r\n                margin-left: 25%\r\n            }\r\n\r\n            .offset-md-4 {\r\n                margin-left: 33.333333%\r\n            }\r\n\r\n            .offset-md-5 {\r\n                margin-left: 41.666667%\r\n            }\r\n\r\n            .offset-md-6 {\r\n                margin-left: 50%\r\n            }\r\n\r\n            .offset-md-7 {\r\n                margin-left: 58.333333%\r\n            }\r\n\r\n            .offset-md-8 {\r\n                margin-left: 66.666667%\r\n            }\r\n\r\n            .offset-md-9 {\r\n                margin-left: 75%\r\n            }\r\n\r\n            .offset-md-10 {\r\n                margin-left: 83.333333%\r\n            }\r\n\r\n            .offset-md-11 {\r\n                margin-left: 91.666667%\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .col-lg {\r\n                -ms-flex-preferred-size: 0;\r\n                flex-basis: 0;\r\n                -webkit-box-flex: 1;\r\n                -ms-flex-positive: 1;\r\n                flex-grow: 1;\r\n                max-width: 100%\r\n            }\r\n\r\n            .col-lg-auto {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 auto;\r\n                flex: 0 0 auto;\r\n                width: auto;\r\n                max-width: none\r\n            }\r\n\r\n            .col-lg-1 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 8.333333%;\r\n                flex: 0 0 8.333333%;\r\n                max-width: 8.333333%\r\n            }\r\n\r\n            .col-lg-2 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 16.666667%;\r\n                flex: 0 0 16.666667%;\r\n                max-width: 16.666667%\r\n            }\r\n\r\n            .col-lg-3 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 25%;\r\n                flex: 0 0 25%;\r\n                max-width: 25%\r\n            }\r\n\r\n            .col-lg-4 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 33.333333%;\r\n                flex: 0 0 33.333333%;\r\n                max-width: 33.333333%\r\n            }\r\n\r\n            .col-lg-5 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 41.666667%;\r\n                flex: 0 0 41.666667%;\r\n                max-width: 41.666667%\r\n            }\r\n\r\n            .col-lg-6 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 50%;\r\n                flex: 0 0 50%;\r\n                max-width: 50%\r\n            }\r\n\r\n            .col-lg-7 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 58.333333%;\r\n                flex: 0 0 58.333333%;\r\n                max-width: 58.333333%\r\n            }\r\n\r\n            .col-lg-8 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 66.666667%;\r\n                flex: 0 0 66.666667%;\r\n                max-width: 66.666667%\r\n            }\r\n\r\n            .col-lg-9 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 75%;\r\n                flex: 0 0 75%;\r\n                max-width: 75%\r\n            }\r\n\r\n            .col-lg-10 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 83.333333%;\r\n                flex: 0 0 83.333333%;\r\n                max-width: 83.333333%\r\n            }\r\n\r\n            .col-lg-11 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 91.666667%;\r\n                flex: 0 0 91.666667%;\r\n                max-width: 91.666667%\r\n            }\r\n\r\n            .col-lg-12 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 100%;\r\n                flex: 0 0 100%;\r\n                max-width: 100%\r\n            }\r\n\r\n            .order-lg-first {\r\n                -webkit-box-ordinal-group: 0;\r\n                -ms-flex-order: -1;\r\n                order: -1\r\n            }\r\n\r\n            .order-lg-last {\r\n                -webkit-box-ordinal-group: 14;\r\n                -ms-flex-order: 13;\r\n                order: 13\r\n            }\r\n\r\n            .order-lg-0 {\r\n                -webkit-box-ordinal-group: 1;\r\n                -ms-flex-order: 0;\r\n                order: 0\r\n            }\r\n\r\n            .order-lg-1 {\r\n                -webkit-box-ordinal-group: 2;\r\n                -ms-flex-order: 1;\r\n                order: 1\r\n            }\r\n\r\n            .order-lg-2 {\r\n                -webkit-box-ordinal-group: 3;\r\n                -ms-flex-order: 2;\r\n                order: 2\r\n            }\r\n\r\n            .order-lg-3 {\r\n                -webkit-box-ordinal-group: 4;\r\n                -ms-flex-order: 3;\r\n                order: 3\r\n            }\r\n\r\n            .order-lg-4 {\r\n                -webkit-box-ordinal-group: 5;\r\n                -ms-flex-order: 4;\r\n                order: 4\r\n            }\r\n\r\n            .order-lg-5 {\r\n                -webkit-box-ordinal-group: 6;\r\n                -ms-flex-order: 5;\r\n                order: 5\r\n            }\r\n\r\n            .order-lg-6 {\r\n                -webkit-box-ordinal-group: 7;\r\n                -ms-flex-order: 6;\r\n                order: 6\r\n            }\r\n\r\n            .order-lg-7 {\r\n                -webkit-box-ordinal-group: 8;\r\n                -ms-flex-order: 7;\r\n                order: 7\r\n            }\r\n\r\n            .order-lg-8 {\r\n                -webkit-box-ordinal-group: 9;\r\n                -ms-flex-order: 8;\r\n                order: 8\r\n            }\r\n\r\n            .order-lg-9 {\r\n                -webkit-box-ordinal-group: 10;\r\n                -ms-flex-order: 9;\r\n                order: 9\r\n            }\r\n\r\n            .order-lg-10 {\r\n                -webkit-box-ordinal-group: 11;\r\n                -ms-flex-order: 10;\r\n                order: 10\r\n            }\r\n\r\n            .order-lg-11 {\r\n                -webkit-box-ordinal-group: 12;\r\n                -ms-flex-order: 11;\r\n                order: 11\r\n            }\r\n\r\n            .order-lg-12 {\r\n                -webkit-box-ordinal-group: 13;\r\n                -ms-flex-order: 12;\r\n                order: 12\r\n            }\r\n\r\n            .offset-lg-0 {\r\n                margin-left: 0\r\n            }\r\n\r\n            .offset-lg-1 {\r\n                margin-left: 8.333333%\r\n            }\r\n\r\n            .offset-lg-2 {\r\n                margin-left: 16.666667%\r\n            }\r\n\r\n            .offset-lg-3 {\r\n                margin-left: 25%\r\n            }\r\n\r\n            .offset-lg-4 {\r\n                margin-left: 33.333333%\r\n            }\r\n\r\n            .offset-lg-5 {\r\n                margin-left: 41.666667%\r\n            }\r\n\r\n            .offset-lg-6 {\r\n                margin-left: 50%\r\n            }\r\n\r\n            .offset-lg-7 {\r\n                margin-left: 58.333333%\r\n            }\r\n\r\n            .offset-lg-8 {\r\n                margin-left: 66.666667%\r\n            }\r\n\r\n            .offset-lg-9 {\r\n                margin-left: 75%\r\n            }\r\n\r\n            .offset-lg-10 {\r\n                margin-left: 83.333333%\r\n            }\r\n\r\n            .offset-lg-11 {\r\n                margin-left: 91.666667%\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .col-xl {\r\n                -ms-flex-preferred-size: 0;\r\n                flex-basis: 0;\r\n                -webkit-box-flex: 1;\r\n                -ms-flex-positive: 1;\r\n                flex-grow: 1;\r\n                max-width: 100%\r\n            }\r\n\r\n            .col-xl-auto {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 auto;\r\n                flex: 0 0 auto;\r\n                width: auto;\r\n                max-width: none\r\n            }\r\n\r\n            .col-xl-1 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 8.333333%;\r\n                flex: 0 0 8.333333%;\r\n                max-width: 8.333333%\r\n            }\r\n\r\n            .col-xl-2 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 16.666667%;\r\n                flex: 0 0 16.666667%;\r\n                max-width: 16.666667%\r\n            }\r\n\r\n            .col-xl-3 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 25%;\r\n                flex: 0 0 25%;\r\n                max-width: 25%\r\n            }\r\n\r\n            .col-xl-4 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 33.333333%;\r\n                flex: 0 0 33.333333%;\r\n                max-width: 33.333333%\r\n            }\r\n\r\n            .col-xl-5 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 41.666667%;\r\n                flex: 0 0 41.666667%;\r\n                max-width: 41.666667%\r\n            }\r\n\r\n            .col-xl-6 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 50%;\r\n                flex: 0 0 50%;\r\n                max-width: 50%\r\n            }\r\n\r\n            .col-xl-7 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 58.333333%;\r\n                flex: 0 0 58.333333%;\r\n                max-width: 58.333333%\r\n            }\r\n\r\n            .col-xl-8 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 66.666667%;\r\n                flex: 0 0 66.666667%;\r\n                max-width: 66.666667%\r\n            }\r\n\r\n            .col-xl-9 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 75%;\r\n                flex: 0 0 75%;\r\n                max-width: 75%\r\n            }\r\n\r\n            .col-xl-10 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 83.333333%;\r\n                flex: 0 0 83.333333%;\r\n                max-width: 83.333333%\r\n            }\r\n\r\n            .col-xl-11 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 91.666667%;\r\n                flex: 0 0 91.666667%;\r\n                max-width: 91.666667%\r\n            }\r\n\r\n            .col-xl-12 {\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 100%;\r\n                flex: 0 0 100%;\r\n                max-width: 100%\r\n            }\r\n\r\n            .order-xl-first {\r\n                -webkit-box-ordinal-group: 0;\r\n                -ms-flex-order: -1;\r\n                order: -1\r\n            }\r\n\r\n            .order-xl-last {\r\n                -webkit-box-ordinal-group: 14;\r\n                -ms-flex-order: 13;\r\n                order: 13\r\n            }\r\n\r\n            .order-xl-0 {\r\n                -webkit-box-ordinal-group: 1;\r\n                -ms-flex-order: 0;\r\n                order: 0\r\n            }\r\n\r\n            .order-xl-1 {\r\n                -webkit-box-ordinal-group: 2;\r\n                -ms-flex-order: 1;\r\n                order: 1\r\n            }\r\n\r\n            .order-xl-2 {\r\n                -webkit-box-ordinal-group: 3;\r\n                -ms-flex-order: 2;\r\n                order: 2\r\n            }\r\n\r\n            .order-xl-3 {\r\n                -webkit-box-ordinal-group: 4;\r\n                -ms-flex-order: 3;\r\n                order: 3\r\n            }\r\n\r\n            .order-xl-4 {\r\n                -webkit-box-ordinal-group: 5;\r\n                -ms-flex-order: 4;\r\n                order: 4\r\n            }\r\n\r\n            .order-xl-5 {\r\n                -webkit-box-ordinal-group: 6;\r\n                -ms-flex-order: 5;\r\n                order: 5\r\n            }\r\n\r\n            .order-xl-6 {\r\n                -webkit-box-ordinal-group: 7;\r\n                -ms-flex-order: 6;\r\n                order: 6\r\n            }\r\n\r\n            .order-xl-7 {\r\n                -webkit-box-ordinal-group: 8;\r\n                -ms-flex-order: 7;\r\n                order: 7\r\n            }\r\n\r\n            .order-xl-8 {\r\n                -webkit-box-ordinal-group: 9;\r\n                -ms-flex-order: 8;\r\n                order: 8\r\n            }\r\n\r\n            .order-xl-9 {\r\n                -webkit-box-ordinal-group: 10;\r\n                -ms-flex-order: 9;\r\n                order: 9\r\n            }\r\n\r\n            .order-xl-10 {\r\n                -webkit-box-ordinal-group: 11;\r\n                -ms-flex-order: 10;\r\n                order: 10\r\n            }\r\n\r\n            .order-xl-11 {\r\n                -webkit-box-ordinal-group: 12;\r\n                -ms-flex-order: 11;\r\n                order: 11\r\n            }\r\n\r\n            .order-xl-12 {\r\n                -webkit-box-ordinal-group: 13;\r\n                -ms-flex-order: 12;\r\n                order: 12\r\n            }\r\n\r\n            .offset-xl-0 {\r\n                margin-left: 0\r\n            }\r\n\r\n            .offset-xl-1 {\r\n                margin-left: 8.333333%\r\n            }\r\n\r\n            .offset-xl-2 {\r\n                margin-left: 16.666667%\r\n            }\r\n\r\n            .offset-xl-3 {\r\n                margin-left: 25%\r\n            }\r\n\r\n            .offset-xl-4 {\r\n                margin-left: 33.333333%\r\n            }\r\n\r\n            .offset-xl-5 {\r\n                margin-left: 41.666667%\r\n            }\r\n\r\n            .offset-xl-6 {\r\n                margin-left: 50%\r\n            }\r\n\r\n            .offset-xl-7 {\r\n                margin-left: 58.333333%\r\n            }\r\n\r\n            .offset-xl-8 {\r\n                margin-left: 66.666667%\r\n            }\r\n\r\n            .offset-xl-9 {\r\n                margin-left: 75%\r\n            }\r\n\r\n            .offset-xl-10 {\r\n                margin-left: 83.333333%\r\n            }\r\n\r\n            .offset-xl-11 {\r\n                margin-left: 91.666667%\r\n            }\r\n        }\r\n\r\n        .table {\r\n            width: 100%;\r\n            max-width: 100%;\r\n            margin-bottom: 1rem;\r\n            background-color: transparent\r\n        }\r\n\r\n            .table td, .table th {\r\n                padding: .75rem;\r\n                vertical-align: top;\r\n                border-top: 1px solid #dee2e6\r\n            }\r\n\r\n            .table thead th {\r\n                vertical-align: bottom;\r\n                border-bottom: 2px solid #dee2e6\r\n            }\r\n\r\n            .table tbody + tbody {\r\n                border-top: 2px solid #dee2e6\r\n            }\r\n\r\n            .table .table {\r\n                background-color: #fff\r\n            }\r\n\r\n        .table-sm td, .table-sm th {\r\n            padding: .3rem\r\n        }\r\n\r\n        .table-bordered {\r\n            border: 1px solid #dee2e6\r\n        }\r\n\r\n            .table-bordered td, .table-bordered th {\r\n                border: 1px solid #dee2e6\r\n            }\r\n\r\n            .table-bordered thead td, .table-bordered thead th {\r\n                border-bottom-width: 2px\r\n            }\r\n\r\n        .table-striped tbody tr:nth-of-type(odd) {\r\n            background-color: rgba(0,0,0,.05)\r\n        }\r\n\r\n        .table-hover tbody tr:hover {\r\n            background-color: rgba(0,0,0,.075)\r\n        }\r\n\r\n        .table-primary, .table-primary > td, .table-primary > th {\r\n            background-color: #b8daff\r\n        }\r\n\r\n        .table-hover .table-primary:hover {\r\n            background-color: #9fcdff\r\n        }\r\n\r\n            .table-hover .table-primary:hover > td, .table-hover .table-primary:hover > th {\r\n                background-color: #9fcdff\r\n            }\r\n\r\n        .table-secondary, .table-secondary > td, .table-secondary > th {\r\n            background-color: #d6d8db\r\n        }\r\n\r\n        .table-hover .table-secondary:hover {\r\n            background-color: #c8cbcf\r\n        }\r\n\r\n            .table-hover .table-secondary:hover > td, .table-hover .table-secondary:hover > th {\r\n                background-color: #c8cbcf\r\n            }\r\n\r\n        .table-success, .table-success > td, .table-success > th {\r\n            background-color: #c3e6cb\r\n        }\r\n\r\n        .table-hover .table-success:hover {\r\n            background-color: #b1dfbb\r\n        }\r\n\r\n            .table-hover .table-success:hover > td, .table-hover .table-success:hover > th {\r\n                background-color: #b1dfbb\r\n            }\r\n\r\n        .table-info, .table-info > td, .table-info > th {\r\n            background-color: #bee5eb\r\n        }\r\n\r\n        .table-hover .table-info:hover {\r\n            background-color: #abdde5\r\n        }\r\n\r\n            .table-hover .table-info:hover > td, .table-hover .table-info:hover > th {\r\n                background-color: #abdde5\r\n            }\r\n\r\n        .table-warning, .table-warning > td, .table-warning > th {\r\n            background-color: #ffeeba\r\n        }\r\n\r\n        .table-hover .table-warning:hover {\r\n            background-color: #ffe8a1\r\n        }\r\n\r\n            .table-hover .table-warning:hover > td, .table-hover .table-warning:hover > th {\r\n                background-color: #ffe8a1\r\n            }\r\n\r\n        .table-danger, .table-danger > td, .table-danger > th {\r\n            background-color: #f5c6cb\r\n        }\r\n\r\n        .table-hover .table-danger:hover {\r\n            background-color: #f1b0b7\r\n        }\r\n\r\n            .table-hover .table-danger:hover > td, .table-hover .table-danger:hover > th {\r\n                background-color: #f1b0b7\r\n            }\r\n\r\n        .table-light, .table-light > td, .table-light > th {\r\n            background-color: #fdfdfe\r\n        }\r\n\r\n        .table-hover .table-light:hover {\r\n            background-color: #ececf6\r\n        }\r\n\r\n            .table-hover .table-light:hover > td, .table-hover .table-light:hover > th {\r\n                background-color: #ececf6\r\n            }\r\n\r\n        .table-dark, .table-dark > td, .table-dark > th {\r\n            background-color: #c6c8ca\r\n        }\r\n\r\n        .table-hover .table-dark:hover {\r\n            background-color: #b9bbbe\r\n        }\r\n\r\n            .table-hover .table-dark:hover > td, .table-hover .table-dark:hover > th {\r\n                background-color: #b9bbbe\r\n            }\r\n\r\n        .table-active, .table-active > td, .table-active > th {\r\n            background-color: rgba(0,0,0,.075)\r\n        }\r\n\r\n        .table-hover .table-active:hover {\r\n            background-color: rgba(0,0,0,.075)\r\n        }\r\n\r\n            .table-hover .table-active:hover > td, .table-hover .table-active:hover > th {\r\n                background-color: rgba(0,0,0,.075)\r\n            }\r\n\r\n        .table .thead-dark th {\r\n            color: #fff;\r\n            background-color: #212529;\r\n            border-color: #32383e\r\n        }\r\n\r\n        .table .thead-light th {\r\n            color: #495057;\r\n            background-color: #e9ecef;\r\n            border-color: #dee2e6\r\n        }\r\n\r\n        .table-dark {\r\n            color: #fff;\r\n            background-color: #212529\r\n        }\r\n\r\n            .table-dark td, .table-dark th, .table-dark thead th {\r\n                border-color: #32383e\r\n            }\r\n\r\n            .table-dark.table-bordered {\r\n                border: 0\r\n            }\r\n\r\n            .table-dark.table-striped tbody tr:nth-of-type(odd) {\r\n                background-color: rgba(255,255,255,.05)\r\n            }\r\n\r\n            .table-dark.table-hover tbody tr:hover {\r\n                background-color: rgba(255,255,255,.075)\r\n            }\r\n\r\n        @media (max-width:575.98px) {\r\n            .table-responsive-sm {\r\n                display: block;\r\n                width: 100%;\r\n                overflow-x: auto;\r\n                -webkit-overflow-scrolling: touch;\r\n                -ms-overflow-style: -ms-autohiding-scrollbar\r\n            }\r\n\r\n                .table-responsive-sm > .table-bordered {\r\n                    border: 0\r\n                }\r\n        }\r\n\r\n        @media (max-width:767.98px) {\r\n            .table-responsive-md {\r\n                display: block;\r\n                width: 100%;\r\n                overflow-x: auto;\r\n                -webkit-overflow-scrolling: touch;\r\n                -ms-overflow-style: -ms-autohiding-scrollbar\r\n            }\r\n\r\n                .table-responsive-md > .table-bordered {\r\n                    border: 0\r\n                }\r\n        }\r\n\r\n        @media (max-width:991.98px) {\r\n            .table-responsive-lg {\r\n                display: block;\r\n                width: 100%;\r\n                overflow-x: auto;\r\n                -webkit-overflow-scrolling: touch;\r\n                -ms-overflow-style: -ms-autohiding-scrollbar\r\n            }\r\n\r\n                .table-responsive-lg > .table-bordered {\r\n                    border: 0\r\n                }\r\n        }\r\n\r\n        @media (max-width:1199.98px) {\r\n            .table-responsive-xl {\r\n                display: block;\r\n                width: 100%;\r\n                overflow-x: auto;\r\n                -webkit-overflow-scrolling: touch;\r\n                -ms-overflow-style: -ms-autohiding-scrollbar\r\n            }\r\n\r\n                .table-responsive-xl > .table-bordered {\r\n                    border: 0\r\n                }\r\n        }\r\n\r\n        .table-responsive {\r\n            display: block;\r\n            width: 100%;\r\n            overflow-x: auto;\r\n            -webkit-overflow-scrolling: touch;\r\n            -ms-overflow-style: -ms-autohiding-scrollbar\r\n        }\r\n\r\n            .table-responsive > .table-bordered {\r\n                border: 0\r\n            }\r\n\r\n        .form-control {\r\n            display: block;\r\n            width: 100%;\r\n            padding: .375rem .75rem;\r\n            font-size: 1rem;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            background-color: #fff;\r\n            background-clip: padding-box;\r\n            border: 1px solid #ced4da;\r\n            border-radius: .25rem;\r\n            transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out\r\n        }\r\n\r\n            .form-control::-ms-expand {\r\n                background-color: transparent;\r\n                border: 0\r\n            }\r\n\r\n            .form-control:focus {\r\n                color: #495057;\r\n                background-color: #fff;\r\n                border-color: #80bdff;\r\n                outline: 0;\r\n                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)\r\n            }\r\n\r\n            .form-control::-webkit-input-placeholder {\r\n                color: #6c757d;\r\n                opacity: 1\r\n            }\r\n\r\n            .form-control::-moz-placeholder {\r\n                color: #6c757d;\r\n                opacity: 1\r\n            }\r\n\r\n            .form-control:-ms-input-placeholder {\r\n                color: #6c757d;\r\n                opacity: 1\r\n            }\r\n\r\n            .form-control::-ms-input-placeholder {\r\n                color: #6c757d;\r\n                opacity: 1\r\n            }\r\n\r\n            .form-control::placeholder {\r\n                color: #6c757d;\r\n                opacity: 1\r\n            }\r\n\r\n            .form-control:disabled, .form-control[readonly] {\r\n                background-color: #e9ecef;\r\n                opacity: 1\r\n            }\r\n\r\n        select.form-control:not([size]):not([multiple]) {\r\n            height: calc(2.25rem + 2px)\r\n        }\r\n\r\n        select.form-control:focus::-ms-value {\r\n            color: #495057;\r\n            background-color: #fff\r\n        }\r\n\r\n        .form-control-file, .form-control-range {\r\n            display: block;\r\n            width: 100%\r\n        }\r\n\r\n        .col-form-label {\r\n            padding-top: calc(.375rem + 1px);\r\n            padding-bottom: calc(.375rem + 1px);\r\n            margin-bottom: 0;\r\n            font-size: inherit;\r\n            line-height: 1.5\r\n        }\r\n\r\n        .col-form-label-lg {\r\n            padding-top: calc(.5rem + 1px);\r\n            padding-bottom: calc(.5rem + 1px);\r\n            font-size: 1.25rem;\r\n            line-height: 1.5\r\n        }\r\n\r\n        .col-form-label-sm {\r\n            padding-top: calc(.25rem + 1px);\r\n            padding-bottom: calc(.25rem + 1px);\r\n            font-size: .875rem;\r\n            line-height: 1.5\r\n        }\r\n\r\n        .form-control-plaintext {\r\n            display: block;\r\n            width: 100%;\r\n            padding-top: .375rem;\r\n            padding-bottom: .375rem;\r\n            margin-bottom: 0;\r\n            line-height: 1.5;\r\n            background-color: transparent;\r\n            border: solid transparent;\r\n            border-width: 1px 0\r\n        }\r\n\r\n            .form-control-plaintext.form-control-lg, .form-control-plaintext.form-control-sm, .input-group-lg > .form-control-plaintext.form-control, .input-group-lg > .input-group-append > .form-control-plaintext.btn, .input-group-lg > .input-group-append > .form-control-plaintext.input-group-text, .input-group-lg > .input-group-prepend > .form-control-plaintext.btn, .input-group-lg > .input-group-prepend > .form-control-plaintext.input-group-text, .input-group-sm > .form-control-plaintext.form-control, .input-group-sm > .input-group-append > .form-control-plaintext.btn, .input-group-sm > .input-group-append > .form-control-plaintext.input-group-text, .input-group-sm > .input-group-prepend > .form-control-plaintext.btn, .input-group-sm > .input-group-prepend > .form-control-plaintext.input-group-text {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n\r\n        .form-control-sm, .input-group-sm > .form-control, .input-group-sm > .input-group-append > .btn, .input-group-sm > .input-group-append > .input-group-text, .input-group-sm > .input-group-prepend > .btn, .input-group-sm > .input-group-prepend > .input-group-text {\r\n            padding: .25rem .5rem;\r\n            font-size: .875rem;\r\n            line-height: 1.5;\r\n            border-radius: .2rem\r\n        }\r\n\r\n        .input-group-sm > .input-group-append > select.btn:not([size]):not([multiple]), .input-group-sm > .input-group-append > select.input-group-text:not([size]):not([multiple]), .input-group-sm > .input-group-prepend > select.btn:not([size]):not([multiple]), .input-group-sm > .input-group-prepend > select.input-group-text:not([size]):not([multiple]), .input-group-sm > select.form-control:not([size]):not([multiple]), select.form-control-sm:not([size]):not([multiple]) {\r\n            height: calc(1.8125rem + 2px)\r\n        }\r\n\r\n        .form-control-lg, .input-group-lg > .form-control, .input-group-lg > .input-group-append > .btn, .input-group-lg > .input-group-append > .input-group-text, .input-group-lg > .input-group-prepend > .btn, .input-group-lg > .input-group-prepend > .input-group-text {\r\n            padding: .5rem 1rem;\r\n            font-size: 1.25rem;\r\n            line-height: 1.5;\r\n            border-radius: .3rem\r\n        }\r\n\r\n        .input-group-lg > .input-group-append > select.btn:not([size]):not([multiple]), .input-group-lg > .input-group-append > select.input-group-text:not([size]):not([multiple]), .input-group-lg > .input-group-prepend > select.btn:not([size]):not([multiple]), .input-group-lg > .input-group-prepend > select.input-group-text:not([size]):not([multiple]), .input-group-lg > select.form-control:not([size]):not([multiple]), select.form-control-lg:not([size]):not([multiple]) {\r\n            height: calc(2.875rem + 2px)\r\n        }\r\n\r\n        .form-group {\r\n            margin-bottom: 1rem\r\n        }\r\n\r\n        .form-text {\r\n            display: block;\r\n            margin-top: .25rem\r\n        }\r\n\r\n        .form-row {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -ms-flex-wrap: wrap;\r\n            flex-wrap: wrap;\r\n            margin-right: -5px;\r\n            margin-left: -5px\r\n        }\r\n\r\n            .form-row > .col, .form-row > [class*=col-] {\r\n                padding-right: 5px;\r\n                padding-left: 5px\r\n            }\r\n\r\n        .form-check {\r\n            position: relative;\r\n            display: block;\r\n            padding-left: 1.25rem\r\n        }\r\n\r\n        .form-check-input {\r\n            position: absolute;\r\n            margin-top: .3rem;\r\n            margin-left: -1.25rem\r\n        }\r\n\r\n            .form-check-input:disabled ~ .form-check-label {\r\n                color: #6c757d\r\n            }\r\n\r\n        .form-check-label {\r\n            margin-bottom: 0\r\n        }\r\n\r\n        .form-check-inline {\r\n            display: -webkit-inline-box;\r\n            display: -ms-inline-flexbox;\r\n            display: inline-flex;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center;\r\n            padding-left: 0;\r\n            margin-right: .75rem\r\n        }\r\n\r\n            .form-check-inline .form-check-input {\r\n                position: static;\r\n                margin-top: 0;\r\n                margin-right: .3125rem;\r\n                margin-left: 0\r\n            }\r\n\r\n        .valid-feedback {\r\n            display: none;\r\n            width: 100%;\r\n            margin-top: .25rem;\r\n            font-size: 80%;\r\n            color: #28a745\r\n        }\r\n\r\n        .valid-tooltip {\r\n            position: absolute;\r\n            top: 100%;\r\n            z-index: 5;\r\n            display: none;\r\n            max-width: 100%;\r\n            padding: .5rem;\r\n            margin-top: .1rem;\r\n            font-size: .875rem;\r\n            line-height: 1;\r\n            color: #fff;\r\n            background-color: rgba(40,167,69,.8);\r\n            border-radius: .2rem\r\n        }\r\n\r\n        .custom-select.is-valid, .form-control.is-valid, .was-validated .custom-select:valid, .was-validated .form-control:valid {\r\n            border-color: #28a745\r\n        }\r\n\r\n            .custom-select.is-valid:focus, .form-control.is-valid:focus, .was-validated .custom-select:valid:focus, .was-validated .form-control:valid:focus {\r\n                border-color: #28a745;\r\n                box-shadow: 0 0 0 .2rem rgba(40,167,69,.25)\r\n            }\r\n\r\n            .custom-select.is-valid ~ .valid-feedback, .custom-select.is-valid ~ .valid-tooltip, .form-control.is-valid ~ .valid-feedback, .form-control.is-valid ~ .valid-tooltip, .was-validated .custom-select:valid ~ .valid-feedback, .was-validated .custom-select:valid ~ .valid-tooltip, .was-validated .form-control:valid ~ .valid-feedback, .was-validated .form-control:valid ~ .valid-tooltip {\r\n                display: block\r\n            }\r\n\r\n        .form-check-input.is-valid ~ .form-check-label, .was-validated .form-check-input:valid ~ .form-check-label {\r\n            color: #28a745\r\n        }\r\n\r\n        .form-check-input.is-valid ~ .valid-feedback, .form-check-input.is-valid ~ .valid-tooltip, .was-validated .form-check-input:valid ~ .valid-feedback, .was-validated .form-check-input:valid ~ .valid-tooltip {\r\n            display: block\r\n        }\r\n\r\n        .custom-control-input.is-valid ~ .custom-control-label, .was-validated .custom-control-input:valid ~ .custom-control-label {\r\n            color: #28a745\r\n        }\r\n\r\n            .custom-control-input.is-valid ~ .custom-control-label::before, .was-validated .custom-control-input:valid ~ .custom-control-label::before {\r\n                background-color: #71dd8a\r\n            }\r\n\r\n        .custom-control-input.is-valid ~ .valid-feedback, .custom-control-input.is-valid ~ .valid-tooltip, .was-validated .custom-control-input:valid ~ .valid-feedback, .was-validated .custom-control-input:valid ~ .valid-tooltip {\r\n            display: block\r\n        }\r\n\r\n        .custom-control-input.is-valid:checked ~ .custom-control-label::before, .was-validated .custom-control-input:valid:checked ~ .custom-control-label::before {\r\n            background-color: #34ce57\r\n        }\r\n\r\n        .custom-control-input.is-valid:focus ~ .custom-control-label::before, .was-validated .custom-control-input:valid:focus ~ .custom-control-label::before {\r\n            box-shadow: 0 0 0 1px #fff,0 0 0 .2rem rgba(40,167,69,.25)\r\n        }\r\n\r\n        .custom-file-input.is-valid ~ .custom-file-label, .was-validated .custom-file-input:valid ~ .custom-file-label {\r\n            border-color: #28a745\r\n        }\r\n\r\n            .custom-file-input.is-valid ~ .custom-file-label::before, .was-validated .custom-file-input:valid ~ .custom-file-label::before {\r\n                border-color: inherit\r\n            }\r\n\r\n        .custom-file-input.is-valid ~ .valid-feedback, .custom-file-input.is-valid ~ .valid-tooltip, .was-validated .custom-file-input:valid ~ .valid-feedback, .was-validated .custom-file-input:valid ~ .valid-tooltip {\r\n            display: block\r\n        }\r\n\r\n        .custom-file-input.is-valid:focus ~ .custom-file-label, .was-validated .custom-file-input:valid:focus ~ .custom-file-label {\r\n            box-shadow: 0 0 0 .2rem rgba(40,167,69,.25)\r\n        }\r\n\r\n        .invalid-feedback {\r\n            display: none;\r\n            width: 100%;\r\n            margin-top: .25rem;\r\n            font-size: 80%;\r\n            color: #dc3545\r\n        }\r\n\r\n        .invalid-tooltip {\r\n            position: absolute;\r\n            top: 100%;\r\n            z-index: 5;\r\n            display: none;\r\n            max-width: 100%;\r\n            padding: .5rem;\r\n            margin-top: .1rem;\r\n            font-size: .875rem;\r\n            line-height: 1;\r\n            color: #fff;\r\n            background-color: rgba(220,53,69,.8);\r\n            border-radius: .2rem\r\n        }\r\n\r\n        .custom-select.is-invalid, .form-control.is-invalid, .was-validated .custom-select:invalid, .was-validated .form-control:invalid {\r\n            border-color: #dc3545\r\n        }\r\n\r\n            .custom-select.is-invalid:focus, .form-control.is-invalid:focus, .was-validated .custom-select:invalid:focus, .was-validated .form-control:invalid:focus {\r\n                border-color: #dc3545;\r\n                box-shadow: 0 0 0 .2rem rgba(220,53,69,.25)\r\n            }\r\n\r\n            .custom-select.is-invalid ~ .invalid-feedback, .custom-select.is-invalid ~ .invalid-tooltip, .form-control.is-invalid ~ .invalid-feedback, .form-control.is-invalid ~ .invalid-tooltip, .was-validated .custom-select:invalid ~ .invalid-feedback, .was-validated .custom-select:invalid ~ .invalid-tooltip, .was-validated .form-control:invalid ~ .invalid-feedback, .was-validated .form-control:invalid ~ .invalid-tooltip {\r\n                display: block\r\n            }\r\n\r\n        .form-check-input.is-invalid ~ .form-check-label, .was-validated .form-check-input:invalid ~ .form-check-label {\r\n            color: #dc3545\r\n        }\r\n\r\n        .form-check-input.is-invalid ~ .invalid-feedback, .form-check-input.is-invalid ~ .invalid-tooltip, .was-validated .form-check-input:invalid ~ .invalid-feedback, .was-validated .form-check-input:invalid ~ .invalid-tooltip {\r\n            display: block\r\n        }\r\n\r\n        .custom-control-input.is-invalid ~ .custom-control-label, .was-validated .custom-control-input:invalid ~ .custom-control-label {\r\n            color: #dc3545\r\n        }\r\n\r\n            .custom-control-input.is-invalid ~ .custom-control-label::before, .was-validated .custom-control-input:invalid ~ .custom-control-label::before {\r\n                background-color: #efa2a9\r\n            }\r\n\r\n        .custom-control-input.is-invalid ~ .invalid-feedback, .custom-control-input.is-invalid ~ .invalid-tooltip, .was-validated .custom-control-input:invalid ~ .invalid-feedback, .was-validated .custom-control-input:invalid ~ .invalid-tooltip {\r\n            display: block\r\n        }\r\n\r\n        .custom-control-input.is-invalid:checked ~ .custom-control-label::before, .was-validated .custom-control-input:invalid:checked ~ .custom-control-label::before {\r\n            background-color: #e4606d\r\n        }\r\n\r\n        .custom-control-input.is-invalid:focus ~ .custom-control-label::before, .was-validated .custom-control-input:invalid:focus ~ .custom-control-label::before {\r\n            box-shadow: 0 0 0 1px #fff,0 0 0 .2rem rgba(220,53,69,.25)\r\n        }\r\n\r\n        .custom-file-input.is-invalid ~ .custom-file-label, .was-validated .custom-file-input:invalid ~ .custom-file-label {\r\n            border-color: #dc3545\r\n        }\r\n\r\n            .custom-file-input.is-invalid ~ .custom-file-label::before, .was-validated .custom-file-input:invalid ~ .custom-file-label::before {\r\n                border-color: inherit\r\n            }\r\n\r\n        .custom-file-input.is-invalid ~ .invalid-feedback, .custom-file-input.is-invalid ~ .invalid-tooltip, .was-validated .custom-file-input:invalid ~ .invalid-feedback, .was-validated .custom-file-input:invalid ~ .invalid-tooltip {\r\n            display: block\r\n        }\r\n\r\n        .custom-file-input.is-invalid:focus ~ .custom-file-label, .was-validated .custom-file-input:invalid:focus ~ .custom-file-label {\r\n            box-shadow: 0 0 0 .2rem rgba(220,53,69,.25)\r\n        }\r\n\r\n        .form-inline {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: horizontal;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-flow: row wrap;\r\n            flex-flow: row wrap;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center\r\n        }\r\n\r\n            .form-inline .form-check {\r\n                width: 100%\r\n            }\r\n\r\n        @media (min-width:576px) {\r\n            .form-inline label {\r\n                display: -webkit-box;\r\n                display: -ms-flexbox;\r\n                display: flex;\r\n                -webkit-box-align: center;\r\n                -ms-flex-align: center;\r\n                align-items: center;\r\n                -webkit-box-pack: center;\r\n                -ms-flex-pack: center;\r\n                justify-content: center;\r\n                margin-bottom: 0\r\n            }\r\n\r\n            .form-inline .form-group {\r\n                display: -webkit-box;\r\n                display: -ms-flexbox;\r\n                display: flex;\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 0 auto;\r\n                flex: 0 0 auto;\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-flow: row wrap;\r\n                flex-flow: row wrap;\r\n                -webkit-box-align: center;\r\n                -ms-flex-align: center;\r\n                align-items: center;\r\n                margin-bottom: 0\r\n            }\r\n\r\n            .form-inline .form-control {\r\n                display: inline-block;\r\n                width: auto;\r\n                vertical-align: middle\r\n            }\r\n\r\n            .form-inline .form-control-plaintext {\r\n                display: inline-block\r\n            }\r\n\r\n            .form-inline .input-group {\r\n                width: auto\r\n            }\r\n\r\n            .form-inline .form-check {\r\n                display: -webkit-box;\r\n                display: -ms-flexbox;\r\n                display: flex;\r\n                -webkit-box-align: center;\r\n                -ms-flex-align: center;\r\n                align-items: center;\r\n                -webkit-box-pack: center;\r\n                -ms-flex-pack: center;\r\n                justify-content: center;\r\n                width: auto;\r\n                padding-left: 0\r\n            }\r\n\r\n            .form-inline .form-check-input {\r\n                position: relative;\r\n                margin-top: 0;\r\n                margin-right: .25rem;\r\n                margin-left: 0\r\n            }\r\n\r\n            .form-inline .custom-control {\r\n                -webkit-box-align: center;\r\n                -ms-flex-align: center;\r\n                align-items: center;\r\n                -webkit-box-pack: center;\r\n                -ms-flex-pack: center;\r\n                justify-content: center\r\n            }\r\n\r\n            .form-inline .custom-control-label {\r\n                margin-bottom: 0\r\n            }\r\n        }\r\n\r\n        .btn {\r\n            display: inline-block;\r\n            font-weight: 400;\r\n            text-align: center;\r\n            white-space: nowrap;\r\n            vertical-align: middle;\r\n            -webkit-user-select: none;\r\n            -moz-user-select: none;\r\n            -ms-user-select: none;\r\n            user-select: none;\r\n            border: 1px solid transparent;\r\n            padding: .375rem .75rem;\r\n            font-size: 1rem;\r\n            line-height: 1.5;\r\n            border-radius: .25rem;\r\n            transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out\r\n        }\r\n\r\n            .btn:focus, .btn:hover {\r\n                text-decoration: none\r\n            }\r\n\r\n            .btn.focus, .btn:focus {\r\n                outline: 0;\r\n                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)\r\n            }\r\n\r\n            .btn.disabled, .btn:disabled {\r\n                opacity: .65\r\n            }\r\n\r\n            .btn:not(:disabled):not(.disabled) {\r\n                cursor: pointer\r\n            }\r\n\r\n                .btn:not(:disabled):not(.disabled).active, .btn:not(:disabled):not(.disabled):active {\r\n                    background-image: none\r\n                }\r\n\r\n        a.btn.disabled, fieldset:disabled a.btn {\r\n            pointer-events: none\r\n        }\r\n\r\n        .btn-primary {\r\n            color: #fff;\r\n            background-color: #007bff;\r\n            border-color: #007bff\r\n        }\r\n\r\n            .btn-primary:hover {\r\n                color: #fff;\r\n                background-color: #0069d9;\r\n                border-color: #0062cc\r\n            }\r\n\r\n            .btn-primary.focus, .btn-primary:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)\r\n            }\r\n\r\n            .btn-primary.disabled, .btn-primary:disabled {\r\n                color: #fff;\r\n                background-color: #007bff;\r\n                border-color: #007bff\r\n            }\r\n\r\n            .btn-primary:not(:disabled):not(.disabled).active, .btn-primary:not(:disabled):not(.disabled):active, .show > .btn-primary.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #0062cc;\r\n                border-color: #005cbf\r\n            }\r\n\r\n                .btn-primary:not(:disabled):not(.disabled).active:focus, .btn-primary:not(:disabled):not(.disabled):active:focus, .show > .btn-primary.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)\r\n                }\r\n\r\n        .btn-secondary {\r\n            color: #fff;\r\n            background-color: #6c757d;\r\n            border-color: #6c757d\r\n        }\r\n\r\n            .btn-secondary:hover {\r\n                color: #fff;\r\n                background-color: #5a6268;\r\n                border-color: #545b62\r\n            }\r\n\r\n            .btn-secondary.focus, .btn-secondary:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)\r\n            }\r\n\r\n            .btn-secondary.disabled, .btn-secondary:disabled {\r\n                color: #fff;\r\n                background-color: #6c757d;\r\n                border-color: #6c757d\r\n            }\r\n\r\n            .btn-secondary:not(:disabled):not(.disabled).active, .btn-secondary:not(:disabled):not(.disabled):active, .show > .btn-secondary.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #545b62;\r\n                border-color: #4e555b\r\n            }\r\n\r\n                .btn-secondary:not(:disabled):not(.disabled).active:focus, .btn-secondary:not(:disabled):not(.disabled):active:focus, .show > .btn-secondary.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)\r\n                }\r\n\r\n        .btn-success {\r\n            color: #fff;\r\n            background-color: #28a745;\r\n            border-color: #28a745\r\n        }\r\n\r\n            .btn-success:hover {\r\n                color: #fff;\r\n                background-color: #218838;\r\n                border-color: #1e7e34\r\n            }\r\n\r\n            .btn-success.focus, .btn-success:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)\r\n            }\r\n\r\n            .btn-success.disabled, .btn-success:disabled {\r\n                color: #fff;\r\n                background-color: #28a745;\r\n                border-color: #28a745\r\n            }\r\n\r\n            .btn-success:not(:disabled):not(.disabled).active, .btn-success:not(:disabled):not(.disabled):active, .show > .btn-success.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #1e7e34;\r\n                border-color: #1c7430\r\n            }\r\n\r\n                .btn-success:not(:disabled):not(.disabled).active:focus, .btn-success:not(:disabled):not(.disabled):active:focus, .show > .btn-success.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)\r\n                }\r\n\r\n        .btn-info {\r\n            color: #fff;\r\n            background-color: #17a2b8;\r\n            border-color: #17a2b8\r\n        }\r\n\r\n            .btn-info:hover {\r\n                color: #fff;\r\n                background-color: #138496;\r\n                border-color: #117a8b\r\n            }\r\n\r\n            .btn-info.focus, .btn-info:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)\r\n            }\r\n\r\n            .btn-info.disabled, .btn-info:disabled {\r\n                color: #fff;\r\n                background-color: #17a2b8;\r\n                border-color: #17a2b8\r\n            }\r\n\r\n            .btn-info:not(:disabled):not(.disabled).active, .btn-info:not(:disabled):not(.disabled):active, .show > .btn-info.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #117a8b;\r\n                border-color: #10707f\r\n            }\r\n\r\n                .btn-info:not(:disabled):not(.disabled).active:focus, .btn-info:not(:disabled):not(.disabled):active:focus, .show > .btn-info.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)\r\n                }\r\n\r\n        .btn-warning {\r\n            color: #212529;\r\n            background-color: #ffc107;\r\n            border-color: #ffc107\r\n        }\r\n\r\n            .btn-warning:hover {\r\n                color: #212529;\r\n                background-color: #e0a800;\r\n                border-color: #d39e00\r\n            }\r\n\r\n            .btn-warning.focus, .btn-warning:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)\r\n            }\r\n\r\n            .btn-warning.disabled, .btn-warning:disabled {\r\n                color: #212529;\r\n                background-color: #ffc107;\r\n                border-color: #ffc107\r\n            }\r\n\r\n            .btn-warning:not(:disabled):not(.disabled).active, .btn-warning:not(:disabled):not(.disabled):active, .show > .btn-warning.dropdown-toggle {\r\n                color: #212529;\r\n                background-color: #d39e00;\r\n                border-color: #c69500\r\n            }\r\n\r\n                .btn-warning:not(:disabled):not(.disabled).active:focus, .btn-warning:not(:disabled):not(.disabled):active:focus, .show > .btn-warning.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)\r\n                }\r\n\r\n        .btn-danger {\r\n            color: #fff;\r\n            background-color: #dc3545;\r\n            border-color: #dc3545\r\n        }\r\n\r\n            .btn-danger:hover {\r\n                color: #fff;\r\n                background-color: #c82333;\r\n                border-color: #bd2130\r\n            }\r\n\r\n            .btn-danger.focus, .btn-danger:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)\r\n            }\r\n\r\n            .btn-danger.disabled, .btn-danger:disabled {\r\n                color: #fff;\r\n                background-color: #dc3545;\r\n                border-color: #dc3545\r\n            }\r\n\r\n            .btn-danger:not(:disabled):not(.disabled).active, .btn-danger:not(:disabled):not(.disabled):active, .show > .btn-danger.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #bd2130;\r\n                border-color: #b21f2d\r\n            }\r\n\r\n                .btn-danger:not(:disabled):not(.disabled).active:focus, .btn-danger:not(:disabled):not(.disabled):active:focus, .show > .btn-danger.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)\r\n                }\r\n\r\n        .btn-light {\r\n            color: #212529;\r\n            background-color: #f8f9fa;\r\n            border-color: #f8f9fa\r\n        }\r\n\r\n            .btn-light:hover {\r\n                color: #212529;\r\n                background-color: #e2e6ea;\r\n                border-color: #dae0e5\r\n            }\r\n\r\n            .btn-light.focus, .btn-light:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)\r\n            }\r\n\r\n            .btn-light.disabled, .btn-light:disabled {\r\n                color: #212529;\r\n                background-color: #f8f9fa;\r\n                border-color: #f8f9fa\r\n            }\r\n\r\n            .btn-light:not(:disabled):not(.disabled).active, .btn-light:not(:disabled):not(.disabled):active, .show > .btn-light.dropdown-toggle {\r\n                color: #212529;\r\n                background-color: #dae0e5;\r\n                border-color: #d3d9df\r\n            }\r\n\r\n                .btn-light:not(:disabled):not(.disabled).active:focus, .btn-light:not(:disabled):not(.disabled):active:focus, .show > .btn-light.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)\r\n                }\r\n\r\n        .btn-dark {\r\n            color: #fff;\r\n            background-color: #343a40;\r\n            border-color: #343a40\r\n        }\r\n\r\n            .btn-dark:hover {\r\n                color: #fff;\r\n                background-color: #23272b;\r\n                border-color: #1d2124\r\n            }\r\n\r\n            .btn-dark.focus, .btn-dark:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)\r\n            }\r\n\r\n            .btn-dark.disabled, .btn-dark:disabled {\r\n                color: #fff;\r\n                background-color: #343a40;\r\n                border-color: #343a40\r\n            }\r\n\r\n            .btn-dark:not(:disabled):not(.disabled).active, .btn-dark:not(:disabled):not(.disabled):active, .show > .btn-dark.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #1d2124;\r\n                border-color: #171a1d\r\n            }\r\n\r\n                .btn-dark:not(:disabled):not(.disabled).active:focus, .btn-dark:not(:disabled):not(.disabled):active:focus, .show > .btn-dark.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)\r\n                }\r\n\r\n        .btn-outline-primary {\r\n            color: #007bff;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #007bff\r\n        }\r\n\r\n            .btn-outline-primary:hover {\r\n                color: #fff;\r\n                background-color: #007bff;\r\n                border-color: #007bff\r\n            }\r\n\r\n            .btn-outline-primary.focus, .btn-outline-primary:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)\r\n            }\r\n\r\n            .btn-outline-primary.disabled, .btn-outline-primary:disabled {\r\n                color: #007bff;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-primary:not(:disabled):not(.disabled).active, .btn-outline-primary:not(:disabled):not(.disabled):active, .show > .btn-outline-primary.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #007bff;\r\n                border-color: #007bff\r\n            }\r\n\r\n                .btn-outline-primary:not(:disabled):not(.disabled).active:focus, .btn-outline-primary:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-primary.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(0,123,255,.5)\r\n                }\r\n\r\n        .btn-outline-secondary {\r\n            color: #6c757d;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #6c757d\r\n        }\r\n\r\n            .btn-outline-secondary:hover {\r\n                color: #fff;\r\n                background-color: #6c757d;\r\n                border-color: #6c757d\r\n            }\r\n\r\n            .btn-outline-secondary.focus, .btn-outline-secondary:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)\r\n            }\r\n\r\n            .btn-outline-secondary.disabled, .btn-outline-secondary:disabled {\r\n                color: #6c757d;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-secondary:not(:disabled):not(.disabled).active, .btn-outline-secondary:not(:disabled):not(.disabled):active, .show > .btn-outline-secondary.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #6c757d;\r\n                border-color: #6c757d\r\n            }\r\n\r\n                .btn-outline-secondary:not(:disabled):not(.disabled).active:focus, .btn-outline-secondary:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-secondary.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(108,117,125,.5)\r\n                }\r\n\r\n        .btn-outline-success {\r\n            color: #28a745;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #28a745\r\n        }\r\n\r\n            .btn-outline-success:hover {\r\n                color: #fff;\r\n                background-color: #28a745;\r\n                border-color: #28a745\r\n            }\r\n\r\n            .btn-outline-success.focus, .btn-outline-success:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)\r\n            }\r\n\r\n            .btn-outline-success.disabled, .btn-outline-success:disabled {\r\n                color: #28a745;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-success:not(:disabled):not(.disabled).active, .btn-outline-success:not(:disabled):not(.disabled):active, .show > .btn-outline-success.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #28a745;\r\n                border-color: #28a745\r\n            }\r\n\r\n                .btn-outline-success:not(:disabled):not(.disabled).active:focus, .btn-outline-success:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-success.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(40,167,69,.5)\r\n                }\r\n\r\n        .btn-outline-info {\r\n            color: #17a2b8;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #17a2b8\r\n        }\r\n\r\n            .btn-outline-info:hover {\r\n                color: #fff;\r\n                background-color: #17a2b8;\r\n                border-color: #17a2b8\r\n            }\r\n\r\n            .btn-outline-info.focus, .btn-outline-info:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)\r\n            }\r\n\r\n            .btn-outline-info.disabled, .btn-outline-info:disabled {\r\n                color: #17a2b8;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-info:not(:disabled):not(.disabled).active, .btn-outline-info:not(:disabled):not(.disabled):active, .show > .btn-outline-info.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #17a2b8;\r\n                border-color: #17a2b8\r\n            }\r\n\r\n                .btn-outline-info:not(:disabled):not(.disabled).active:focus, .btn-outline-info:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-info.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(23,162,184,.5)\r\n                }\r\n\r\n        .btn-outline-warning {\r\n            color: #ffc107;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #ffc107\r\n        }\r\n\r\n            .btn-outline-warning:hover {\r\n                color: #212529;\r\n                background-color: #ffc107;\r\n                border-color: #ffc107\r\n            }\r\n\r\n            .btn-outline-warning.focus, .btn-outline-warning:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)\r\n            }\r\n\r\n            .btn-outline-warning.disabled, .btn-outline-warning:disabled {\r\n                color: #ffc107;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-warning:not(:disabled):not(.disabled).active, .btn-outline-warning:not(:disabled):not(.disabled):active, .show > .btn-outline-warning.dropdown-toggle {\r\n                color: #212529;\r\n                background-color: #ffc107;\r\n                border-color: #ffc107\r\n            }\r\n\r\n                .btn-outline-warning:not(:disabled):not(.disabled).active:focus, .btn-outline-warning:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-warning.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(255,193,7,.5)\r\n                }\r\n\r\n        .btn-outline-danger {\r\n            color: #dc3545;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #dc3545\r\n        }\r\n\r\n            .btn-outline-danger:hover {\r\n                color: #fff;\r\n                background-color: #dc3545;\r\n                border-color: #dc3545\r\n            }\r\n\r\n            .btn-outline-danger.focus, .btn-outline-danger:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)\r\n            }\r\n\r\n            .btn-outline-danger.disabled, .btn-outline-danger:disabled {\r\n                color: #dc3545;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-danger:not(:disabled):not(.disabled).active, .btn-outline-danger:not(:disabled):not(.disabled):active, .show > .btn-outline-danger.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #dc3545;\r\n                border-color: #dc3545\r\n            }\r\n\r\n                .btn-outline-danger:not(:disabled):not(.disabled).active:focus, .btn-outline-danger:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-danger.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(220,53,69,.5)\r\n                }\r\n\r\n        .btn-outline-light {\r\n            color: #f8f9fa;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #f8f9fa\r\n        }\r\n\r\n            .btn-outline-light:hover {\r\n                color: #212529;\r\n                background-color: #f8f9fa;\r\n                border-color: #f8f9fa\r\n            }\r\n\r\n            .btn-outline-light.focus, .btn-outline-light:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)\r\n            }\r\n\r\n            .btn-outline-light.disabled, .btn-outline-light:disabled {\r\n                color: #f8f9fa;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-light:not(:disabled):not(.disabled).active, .btn-outline-light:not(:disabled):not(.disabled):active, .show > .btn-outline-light.dropdown-toggle {\r\n                color: #212529;\r\n                background-color: #f8f9fa;\r\n                border-color: #f8f9fa\r\n            }\r\n\r\n                .btn-outline-light:not(:disabled):not(.disabled).active:focus, .btn-outline-light:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-light.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(248,249,250,.5)\r\n                }\r\n\r\n        .btn-outline-dark {\r\n            color: #343a40;\r\n            background-color: transparent;\r\n            background-image: none;\r\n            border-color: #343a40\r\n        }\r\n\r\n            .btn-outline-dark:hover {\r\n                color: #fff;\r\n                background-color: #343a40;\r\n                border-color: #343a40\r\n            }\r\n\r\n            .btn-outline-dark.focus, .btn-outline-dark:focus {\r\n                box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)\r\n            }\r\n\r\n            .btn-outline-dark.disabled, .btn-outline-dark:disabled {\r\n                color: #343a40;\r\n                background-color: transparent\r\n            }\r\n\r\n            .btn-outline-dark:not(:disabled):not(.disabled).active, .btn-outline-dark:not(:disabled):not(.disabled):active, .show > .btn-outline-dark.dropdown-toggle {\r\n                color: #fff;\r\n                background-color: #343a40;\r\n                border-color: #343a40\r\n            }\r\n\r\n                .btn-outline-dark:not(:disabled):not(.disabled).active:focus, .btn-outline-dark:not(:disabled):not(.disabled):active:focus, .show > .btn-outline-dark.dropdown-toggle:focus {\r\n                    box-shadow: 0 0 0 .2rem rgba(52,58,64,.5)\r\n                }\r\n\r\n        .btn-link {\r\n            font-weight: 400;\r\n            color: #007bff;\r\n            background-color: transparent\r\n        }\r\n\r\n            .btn-link:hover {\r\n                color: #0056b3;\r\n                text-decoration: underline;\r\n                background-color: transparent;\r\n                border-color: transparent\r\n            }\r\n\r\n            .btn-link.focus, .btn-link:focus {\r\n                text-decoration: underline;\r\n                border-color: transparent;\r\n                box-shadow: none\r\n            }\r\n\r\n            .btn-link.disabled, .btn-link:disabled {\r\n                color: #6c757d\r\n            }\r\n\r\n        .btn-group-lg > .btn, .btn-lg {\r\n            padding: .5rem 1rem;\r\n            font-size: 1.25rem;\r\n            line-height: 1.5;\r\n            border-radius: .3rem\r\n        }\r\n\r\n        .btn-group-sm > .btn, .btn-sm {\r\n            padding: .25rem .5rem;\r\n            font-size: .875rem;\r\n            line-height: 1.5;\r\n            border-radius: .2rem\r\n        }\r\n\r\n        .btn-block {\r\n            display: block;\r\n            width: 100%\r\n        }\r\n\r\n            .btn-block + .btn-block {\r\n                margin-top: .5rem\r\n            }\r\n\r\n        input[type=button].btn-block, input[type=reset].btn-block, input[type=submit].btn-block {\r\n            width: 100%\r\n        }\r\n\r\n        .fade {\r\n            opacity: 0;\r\n            transition: opacity .15s linear\r\n        }\r\n\r\n            .fade.show {\r\n                opacity: 1\r\n            }\r\n\r\n        .collapse {\r\n            display: none\r\n        }\r\n\r\n            .collapse.show {\r\n                display: block\r\n            }\r\n\r\n        tr.collapse.show {\r\n            display: table-row\r\n        }\r\n\r\n        tbody.collapse.show {\r\n            display: table-row-group\r\n        }\r\n\r\n        .collapsing {\r\n            position: relative;\r\n            height: 0;\r\n            overflow: hidden;\r\n            transition: height .35s ease\r\n        }\r\n\r\n        .dropdown, .dropup {\r\n            position: relative\r\n        }\r\n\r\n        .dropdown-toggle::after {\r\n            display: inline-block;\r\n            width: 0;\r\n            height: 0;\r\n            margin-left: .255em;\r\n            vertical-align: .255em;\r\n            content: \"\";\r\n            border-top: .3em solid;\r\n            border-right: .3em solid transparent;\r\n            border-bottom: 0;\r\n            border-left: .3em solid transparent\r\n        }\r\n\r\n        .dropdown-toggle:empty::after {\r\n            margin-left: 0\r\n        }\r\n\r\n        .dropdown-menu {\r\n            position: absolute;\r\n            top: 100%;\r\n            left: 0;\r\n            z-index: 1000;\r\n            display: none;\r\n            float: left;\r\n            min-width: 10rem;\r\n            padding: .5rem 0;\r\n            margin: .125rem 0 0;\r\n            font-size: 1rem;\r\n            color: #212529;\r\n            text-align: left;\r\n            list-style: none;\r\n            background-color: #fff;\r\n            background-clip: padding-box;\r\n            border: 1px solid rgba(0,0,0,.15);\r\n            border-radius: .25rem\r\n        }\r\n\r\n        .dropup .dropdown-menu {\r\n            margin-top: 0;\r\n            margin-bottom: .125rem\r\n        }\r\n\r\n        .dropup .dropdown-toggle::after {\r\n            display: inline-block;\r\n            width: 0;\r\n            height: 0;\r\n            margin-left: .255em;\r\n            vertical-align: .255em;\r\n            content: \"\";\r\n            border-top: 0;\r\n            border-right: .3em solid transparent;\r\n            border-bottom: .3em solid;\r\n            border-left: .3em solid transparent\r\n        }\r\n\r\n        .dropup .dropdown-toggle:empty::after {\r\n            margin-left: 0\r\n        }\r\n\r\n        .dropright .dropdown-menu {\r\n            margin-top: 0;\r\n            margin-left: .125rem\r\n        }\r\n\r\n        .dropright .dropdown-toggle::after {\r\n            display: inline-block;\r\n            width: 0;\r\n            height: 0;\r\n            margin-left: .255em;\r\n            vertical-align: .255em;\r\n            content: \"\";\r\n            border-top: .3em solid transparent;\r\n            border-bottom: .3em solid transparent;\r\n            border-left: .3em solid\r\n        }\r\n\r\n        .dropright .dropdown-toggle:empty::after {\r\n            margin-left: 0\r\n        }\r\n\r\n        .dropright .dropdown-toggle::after {\r\n            vertical-align: 0\r\n        }\r\n\r\n        .dropleft .dropdown-menu {\r\n            margin-top: 0;\r\n            margin-right: .125rem\r\n        }\r\n\r\n        .dropleft .dropdown-toggle::after {\r\n            display: inline-block;\r\n            width: 0;\r\n            height: 0;\r\n            margin-left: .255em;\r\n            vertical-align: .255em;\r\n            content: \"\"\r\n        }\r\n\r\n        .dropleft .dropdown-toggle::after {\r\n            display: none\r\n        }\r\n\r\n        .dropleft .dropdown-toggle::before {\r\n            display: inline-block;\r\n            width: 0;\r\n            height: 0;\r\n            margin-right: .255em;\r\n            vertical-align: .255em;\r\n            content: \"\";\r\n            border-top: .3em solid transparent;\r\n            border-right: .3em solid;\r\n            border-bottom: .3em solid transparent\r\n        }\r\n\r\n        .dropleft .dropdown-toggle:empty::after {\r\n            margin-left: 0\r\n        }\r\n\r\n        .dropleft .dropdown-toggle::before {\r\n            vertical-align: 0\r\n        }\r\n\r\n        .dropdown-divider {\r\n            height: 0;\r\n            margin: .5rem 0;\r\n            overflow: hidden;\r\n            border-top: 1px solid #e9ecef\r\n        }\r\n\r\n        .dropdown-item {\r\n            display: block;\r\n            width: 100%;\r\n            padding: .25rem 1.5rem;\r\n            clear: both;\r\n            font-weight: 400;\r\n            color: #212529;\r\n            text-align: inherit;\r\n            white-space: nowrap;\r\n            background-color: transparent;\r\n            border: 0\r\n        }\r\n\r\n            .dropdown-item:focus, .dropdown-item:hover {\r\n                color: #16181b;\r\n                text-decoration: none;\r\n                background-color: #f8f9fa\r\n            }\r\n\r\n            .dropdown-item.active, .dropdown-item:active {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                background-color: #007bff\r\n            }\r\n\r\n            .dropdown-item.disabled, .dropdown-item:disabled {\r\n                color: #6c757d;\r\n                background-color: transparent\r\n            }\r\n\r\n        .dropdown-menu.show {\r\n            display: block\r\n        }\r\n\r\n        .dropdown-header {\r\n            display: block;\r\n            padding: .5rem 1.5rem;\r\n            margin-bottom: 0;\r\n            font-size: .875rem;\r\n            color: #6c757d;\r\n            white-space: nowrap\r\n        }\r\n\r\n        .btn-group, .btn-group-vertical {\r\n            position: relative;\r\n            display: -webkit-inline-box;\r\n            display: -ms-inline-flexbox;\r\n            display: inline-flex;\r\n            vertical-align: middle\r\n        }\r\n\r\n            .btn-group-vertical > .btn, .btn-group > .btn {\r\n                position: relative;\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 1 auto;\r\n                flex: 0 1 auto\r\n            }\r\n\r\n                .btn-group-vertical > .btn:hover, .btn-group > .btn:hover {\r\n                    z-index: 1\r\n                }\r\n\r\n                .btn-group-vertical > .btn.active, .btn-group-vertical > .btn:active, .btn-group-vertical > .btn:focus, .btn-group > .btn.active, .btn-group > .btn:active, .btn-group > .btn:focus {\r\n                    z-index: 1\r\n                }\r\n\r\n            .btn-group .btn + .btn, .btn-group .btn + .btn-group, .btn-group .btn-group + .btn, .btn-group .btn-group + .btn-group, .btn-group-vertical .btn + .btn, .btn-group-vertical .btn + .btn-group, .btn-group-vertical .btn-group + .btn, .btn-group-vertical .btn-group + .btn-group {\r\n                margin-left: -1px\r\n            }\r\n\r\n        .btn-toolbar {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -ms-flex-wrap: wrap;\r\n            flex-wrap: wrap;\r\n            -webkit-box-pack: start;\r\n            -ms-flex-pack: start;\r\n            justify-content: flex-start\r\n        }\r\n\r\n            .btn-toolbar .input-group {\r\n                width: auto\r\n            }\r\n\r\n        .btn-group > .btn:first-child {\r\n            margin-left: 0\r\n        }\r\n\r\n        .btn-group > .btn-group:not(:last-child) > .btn, .btn-group > .btn:not(:last-child):not(.dropdown-toggle) {\r\n            border-top-right-radius: 0;\r\n            border-bottom-right-radius: 0\r\n        }\r\n\r\n        .btn-group > .btn-group:not(:first-child) > .btn, .btn-group > .btn:not(:first-child) {\r\n            border-top-left-radius: 0;\r\n            border-bottom-left-radius: 0\r\n        }\r\n\r\n        .dropdown-toggle-split {\r\n            padding-right: .5625rem;\r\n            padding-left: .5625rem\r\n        }\r\n\r\n            .dropdown-toggle-split::after {\r\n                margin-left: 0\r\n            }\r\n\r\n        .btn-group-sm > .btn + .dropdown-toggle-split, .btn-sm + .dropdown-toggle-split {\r\n            padding-right: .375rem;\r\n            padding-left: .375rem\r\n        }\r\n\r\n        .btn-group-lg > .btn + .dropdown-toggle-split, .btn-lg + .dropdown-toggle-split {\r\n            padding-right: .75rem;\r\n            padding-left: .75rem\r\n        }\r\n\r\n        .btn-group-vertical {\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column;\r\n            -webkit-box-align: start;\r\n            -ms-flex-align: start;\r\n            align-items: flex-start;\r\n            -webkit-box-pack: center;\r\n            -ms-flex-pack: center;\r\n            justify-content: center\r\n        }\r\n\r\n            .btn-group-vertical .btn, .btn-group-vertical .btn-group {\r\n                width: 100%\r\n            }\r\n\r\n            .btn-group-vertical > .btn + .btn, .btn-group-vertical > .btn + .btn-group, .btn-group-vertical > .btn-group + .btn, .btn-group-vertical > .btn-group + .btn-group {\r\n                margin-top: -1px;\r\n                margin-left: 0\r\n            }\r\n\r\n            .btn-group-vertical > .btn-group:not(:last-child) > .btn, .btn-group-vertical > .btn:not(:last-child):not(.dropdown-toggle) {\r\n                border-bottom-right-radius: 0;\r\n                border-bottom-left-radius: 0\r\n            }\r\n\r\n            .btn-group-vertical > .btn-group:not(:first-child) > .btn, .btn-group-vertical > .btn:not(:first-child) {\r\n                border-top-left-radius: 0;\r\n                border-top-right-radius: 0\r\n            }\r\n\r\n        .btn-group-toggle > .btn, .btn-group-toggle > .btn-group > .btn {\r\n            margin-bottom: 0\r\n        }\r\n\r\n            .btn-group-toggle > .btn input[type=checkbox], .btn-group-toggle > .btn input[type=radio], .btn-group-toggle > .btn-group > .btn input[type=checkbox], .btn-group-toggle > .btn-group > .btn input[type=radio] {\r\n                position: absolute;\r\n                clip: rect(0,0,0,0);\r\n                pointer-events: none\r\n            }\r\n\r\n        .input-group {\r\n            position: relative;\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -ms-flex-wrap: wrap;\r\n            flex-wrap: wrap;\r\n            -webkit-box-align: stretch;\r\n            -ms-flex-align: stretch;\r\n            align-items: stretch;\r\n            width: 100%\r\n        }\r\n\r\n            .input-group > .custom-file, .input-group > .custom-select, .input-group > .form-control {\r\n                position: relative;\r\n                -webkit-box-flex: 1;\r\n                -ms-flex: 1 1 auto;\r\n                flex: 1 1 auto;\r\n                width: 1%;\r\n                margin-bottom: 0\r\n            }\r\n\r\n                .input-group > .custom-file:focus, .input-group > .custom-select:focus, .input-group > .form-control:focus {\r\n                    z-index: 3\r\n                }\r\n\r\n                .input-group > .custom-file + .custom-file, .input-group > .custom-file + .custom-select, .input-group > .custom-file + .form-control, .input-group > .custom-select + .custom-file, .input-group > .custom-select + .custom-select, .input-group > .custom-select + .form-control, .input-group > .form-control + .custom-file, .input-group > .form-control + .custom-select, .input-group > .form-control + .form-control {\r\n                    margin-left: -1px\r\n                }\r\n\r\n                .input-group > .custom-select:not(:last-child), .input-group > .form-control:not(:last-child) {\r\n                    border-top-right-radius: 0;\r\n                    border-bottom-right-radius: 0\r\n                }\r\n\r\n                .input-group > .custom-select:not(:first-child), .input-group > .form-control:not(:first-child) {\r\n                    border-top-left-radius: 0;\r\n                    border-bottom-left-radius: 0\r\n                }\r\n\r\n            .input-group > .custom-file {\r\n                display: -webkit-box;\r\n                display: -ms-flexbox;\r\n                display: flex;\r\n                -webkit-box-align: center;\r\n                -ms-flex-align: center;\r\n                align-items: center\r\n            }\r\n\r\n                .input-group > .custom-file:not(:last-child) .custom-file-label, .input-group > .custom-file:not(:last-child) .custom-file-label::before {\r\n                    border-top-right-radius: 0;\r\n                    border-bottom-right-radius: 0\r\n                }\r\n\r\n                .input-group > .custom-file:not(:first-child) .custom-file-label, .input-group > .custom-file:not(:first-child) .custom-file-label::before {\r\n                    border-top-left-radius: 0;\r\n                    border-bottom-left-radius: 0\r\n                }\r\n\r\n        .input-group-append, .input-group-prepend {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex\r\n        }\r\n\r\n            .input-group-append .btn, .input-group-prepend .btn {\r\n                position: relative;\r\n                z-index: 2\r\n            }\r\n\r\n                .input-group-append .btn + .btn, .input-group-append .btn + .input-group-text, .input-group-append .input-group-text + .btn, .input-group-append .input-group-text + .input-group-text, .input-group-prepend .btn + .btn, .input-group-prepend .btn + .input-group-text, .input-group-prepend .input-group-text + .btn, .input-group-prepend .input-group-text + .input-group-text {\r\n                    margin-left: -1px\r\n                }\r\n\r\n        .input-group-prepend {\r\n            margin-right: -1px\r\n        }\r\n\r\n        .input-group-append {\r\n            margin-left: -1px\r\n        }\r\n\r\n        .input-group-text {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center;\r\n            padding: .375rem .75rem;\r\n            margin-bottom: 0;\r\n            font-size: 1rem;\r\n            font-weight: 400;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            text-align: center;\r\n            white-space: nowrap;\r\n            background-color: #e9ecef;\r\n            border: 1px solid #ced4da;\r\n            border-radius: .25rem\r\n        }\r\n\r\n            .input-group-text input[type=checkbox], .input-group-text input[type=radio] {\r\n                margin-top: 0\r\n            }\r\n\r\n        .input-group > .input-group-append:last-child > .btn:not(:last-child):not(.dropdown-toggle), .input-group > .input-group-append:last-child > .input-group-text:not(:last-child), .input-group > .input-group-append:not(:last-child) > .btn, .input-group > .input-group-append:not(:last-child) > .input-group-text, .input-group > .input-group-prepend > .btn, .input-group > .input-group-prepend > .input-group-text {\r\n            border-top-right-radius: 0;\r\n            border-bottom-right-radius: 0\r\n        }\r\n\r\n        .input-group > .input-group-append > .btn, .input-group > .input-group-append > .input-group-text, .input-group > .input-group-prepend:first-child > .btn:not(:first-child), .input-group > .input-group-prepend:first-child > .input-group-text:not(:first-child), .input-group > .input-group-prepend:not(:first-child) > .btn, .input-group > .input-group-prepend:not(:first-child) > .input-group-text {\r\n            border-top-left-radius: 0;\r\n            border-bottom-left-radius: 0\r\n        }\r\n\r\n        .custom-control {\r\n            position: relative;\r\n            display: block;\r\n            min-height: 1.5rem;\r\n            padding-left: 1.5rem\r\n        }\r\n\r\n        .custom-control-inline {\r\n            display: -webkit-inline-box;\r\n            display: -ms-inline-flexbox;\r\n            display: inline-flex;\r\n            margin-right: 1rem\r\n        }\r\n\r\n        .custom-control-input {\r\n            position: absolute;\r\n            z-index: -1;\r\n            opacity: 0\r\n        }\r\n\r\n            .custom-control-input:checked ~ .custom-control-label::before {\r\n                color: #fff;\r\n                background-color: #007bff\r\n            }\r\n\r\n            .custom-control-input:focus ~ .custom-control-label::before {\r\n                box-shadow: 0 0 0 1px #fff,0 0 0 .2rem rgba(0,123,255,.25)\r\n            }\r\n\r\n            .custom-control-input:active ~ .custom-control-label::before {\r\n                color: #fff;\r\n                background-color: #b3d7ff\r\n            }\r\n\r\n            .custom-control-input:disabled ~ .custom-control-label {\r\n                color: #6c757d\r\n            }\r\n\r\n                .custom-control-input:disabled ~ .custom-control-label::before {\r\n                    background-color: #e9ecef\r\n                }\r\n\r\n        .custom-control-label {\r\n            margin-bottom: 0\r\n        }\r\n\r\n            .custom-control-label::before {\r\n                position: absolute;\r\n                top: .25rem;\r\n                left: 0;\r\n                display: block;\r\n                width: 1rem;\r\n                height: 1rem;\r\n                pointer-events: none;\r\n                content: \"\";\r\n                -webkit-user-select: none;\r\n                -moz-user-select: none;\r\n                -ms-user-select: none;\r\n                user-select: none;\r\n                background-color: #dee2e6\r\n            }\r\n\r\n            .custom-control-label::after {\r\n                position: absolute;\r\n                top: .25rem;\r\n                left: 0;\r\n                display: block;\r\n                width: 1rem;\r\n                height: 1rem;\r\n                content: \"\";\r\n                background-repeat: no-repeat;\r\n                background-position: center center;\r\n                background-size: 50% 50%\r\n            }\r\n\r\n        .custom-checkbox .custom-control-label::before {\r\n            border-radius: .25rem\r\n        }\r\n\r\n        .custom-checkbox .custom-control-input:checked ~ .custom-control-label::before {\r\n            background-color: #007bff\r\n        }\r\n\r\n        .custom-checkbox .custom-control-input:checked ~ .custom-control-label::after {\r\n            background-image: url(\"data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 8 8'%3E%3Cpath fill='%23fff' d='M6.564.75l-3.59 3.612-1.538-1.55L0 4.26 2.974 7.25 8 2.193z'/%3E%3C/svg%3E\")\r\n        }\r\n\r\n        .custom-checkbox .custom-control-input:indeterminate ~ .custom-control-label::before {\r\n            background-color: #007bff\r\n        }\r\n\r\n        .custom-checkbox .custom-control-input:indeterminate ~ .custom-control-label::after {\r\n            background-image: url(\"data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 4 4'%3E%3Cpath stroke='%23fff' d='M0 2h4'/%3E%3C/svg%3E\")\r\n        }\r\n\r\n        .custom-checkbox .custom-control-input:disabled:checked ~ .custom-control-label::before {\r\n            background-color: rgba(0,123,255,.5)\r\n        }\r\n\r\n        .custom-checkbox .custom-control-input:disabled:indeterminate ~ .custom-control-label::before {\r\n            background-color: rgba(0,123,255,.5)\r\n        }\r\n\r\n        .custom-radio .custom-control-label::before {\r\n            border-radius: 50%\r\n        }\r\n\r\n        .custom-radio .custom-control-input:checked ~ .custom-control-label::before {\r\n            background-color: #007bff\r\n        }\r\n\r\n        .custom-radio .custom-control-input:checked ~ .custom-control-label::after {\r\n            background-image: url(\"data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='-4 -4 8 8'%3E%3Ccircle r='3' fill='%23fff'/%3E%3C/svg%3E\")\r\n        }\r\n\r\n        .custom-radio .custom-control-input:disabled:checked ~ .custom-control-label::before {\r\n            background-color: rgba(0,123,255,.5)\r\n        }\r\n\r\n        .custom-select {\r\n            display: inline-block;\r\n            width: 100%;\r\n            height: calc(2.25rem + 2px);\r\n            padding: .375rem 1.75rem .375rem .75rem;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            vertical-align: middle;\r\n            background: #fff url(\"data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 4 5'%3E%3Cpath fill='%23343a40' d='M2 0L0 2h4zm0 5L0 3h4z'/%3E%3C/svg%3E\") no-repeat right .75rem center;\r\n            background-size: 8px 10px;\r\n            border: 1px solid #ced4da;\r\n            border-radius: .25rem;\r\n            -webkit-appearance: none;\r\n            -moz-appearance: none;\r\n            appearance: none\r\n        }\r\n\r\n            .custom-select:focus {\r\n                border-color: #80bdff;\r\n                outline: 0;\r\n                box-shadow: inset 0 1px 2px rgba(0,0,0,.075),0 0 5px rgba(128,189,255,.5)\r\n            }\r\n\r\n                .custom-select:focus::-ms-value {\r\n                    color: #495057;\r\n                    background-color: #fff\r\n                }\r\n\r\n            .custom-select[multiple], .custom-select[size]:not([size=\"1\"]) {\r\n                height: auto;\r\n                padding-right: .75rem;\r\n                background-image: none\r\n            }\r\n\r\n            .custom-select:disabled {\r\n                color: #6c757d;\r\n                background-color: #e9ecef\r\n            }\r\n\r\n            .custom-select::-ms-expand {\r\n                opacity: 0\r\n            }\r\n\r\n        .custom-select-sm {\r\n            height: calc(1.8125rem + 2px);\r\n            padding-top: .375rem;\r\n            padding-bottom: .375rem;\r\n            font-size: 75%\r\n        }\r\n\r\n        .custom-select-lg {\r\n            height: calc(2.875rem + 2px);\r\n            padding-top: .375rem;\r\n            padding-bottom: .375rem;\r\n            font-size: 125%\r\n        }\r\n\r\n        .custom-file {\r\n            position: relative;\r\n            display: inline-block;\r\n            width: 100%;\r\n            height: calc(2.25rem + 2px);\r\n            margin-bottom: 0\r\n        }\r\n\r\n        .custom-file-input {\r\n            position: relative;\r\n            z-index: 2;\r\n            width: 100%;\r\n            height: calc(2.25rem + 2px);\r\n            margin: 0;\r\n            opacity: 0\r\n        }\r\n\r\n            .custom-file-input:focus ~ .custom-file-control {\r\n                border-color: #80bdff;\r\n                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)\r\n            }\r\n\r\n                .custom-file-input:focus ~ .custom-file-control::before {\r\n                    border-color: #80bdff\r\n                }\r\n\r\n            .custom-file-input:lang(en) ~ .custom-file-label::after {\r\n                content: \"Browse\"\r\n            }\r\n\r\n        .custom-file-label {\r\n            position: absolute;\r\n            top: 0;\r\n            right: 0;\r\n            left: 0;\r\n            z-index: 1;\r\n            height: calc(2.25rem + 2px);\r\n            padding: .375rem .75rem;\r\n            line-height: 1.5;\r\n            color: #495057;\r\n            background-color: #fff;\r\n            border: 1px solid #ced4da;\r\n            border-radius: .25rem\r\n        }\r\n\r\n            .custom-file-label::after {\r\n                position: absolute;\r\n                top: 0;\r\n                right: 0;\r\n                bottom: 0;\r\n                z-index: 3;\r\n                display: block;\r\n                height: calc(calc(2.25rem + 2px) - 1px * 2);\r\n                padding: .375rem .75rem;\r\n                line-height: 1.5;\r\n                color: #495057;\r\n                content: \"Browse\";\r\n                background-color: #e9ecef;\r\n                border-left: 1px solid #ced4da;\r\n                border-radius: 0 .25rem .25rem 0\r\n            }\r\n\r\n        .nav {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -ms-flex-wrap: wrap;\r\n            flex-wrap: wrap;\r\n            padding-left: 0;\r\n            margin-bottom: 0;\r\n            list-style: none\r\n        }\r\n\r\n        .nav-link {\r\n            display: block;\r\n            padding: .5rem 1rem\r\n        }\r\n\r\n            .nav-link:focus, .nav-link:hover {\r\n                text-decoration: none\r\n            }\r\n\r\n            .nav-link.disabled {\r\n                color: #6c757d\r\n            }\r\n\r\n        .nav-tabs {\r\n            border-bottom: 1px solid #dee2e6\r\n        }\r\n\r\n            .nav-tabs .nav-item {\r\n                margin-bottom: -1px\r\n            }\r\n\r\n            .nav-tabs .nav-link {\r\n                border: 1px solid transparent;\r\n                border-top-left-radius: .25rem;\r\n                border-top-right-radius: .25rem\r\n            }\r\n\r\n                .nav-tabs .nav-link:focus, .nav-tabs .nav-link:hover {\r\n                    border-color: #e9ecef #e9ecef #dee2e6\r\n                }\r\n\r\n                .nav-tabs .nav-link.disabled {\r\n                    color: #6c757d;\r\n                    background-color: transparent;\r\n                    border-color: transparent\r\n                }\r\n\r\n                .nav-tabs .nav-item.show .nav-link, .nav-tabs .nav-link.active {\r\n                    color: #495057;\r\n                    background-color: #fff;\r\n                    border-color: #dee2e6 #dee2e6 #fff\r\n                }\r\n\r\n            .nav-tabs .dropdown-menu {\r\n                margin-top: -1px;\r\n                border-top-left-radius: 0;\r\n                border-top-right-radius: 0\r\n            }\r\n\r\n        .nav-pills .nav-link {\r\n            border-radius: .25rem\r\n        }\r\n\r\n            .nav-pills .nav-link.active, .nav-pills .show > .nav-link {\r\n                color: #fff;\r\n                background-color: #007bff\r\n            }\r\n\r\n        .nav-fill .nav-item {\r\n            -webkit-box-flex: 1;\r\n            -ms-flex: 1 1 auto;\r\n            flex: 1 1 auto;\r\n            text-align: center\r\n        }\r\n\r\n        .nav-justified .nav-item {\r\n            -ms-flex-preferred-size: 0;\r\n            flex-basis: 0;\r\n            -webkit-box-flex: 1;\r\n            -ms-flex-positive: 1;\r\n            flex-grow: 1;\r\n            text-align: center\r\n        }\r\n\r\n        .tab-content > .tab-pane {\r\n            display: none\r\n        }\r\n\r\n        .tab-content > .active {\r\n            display: block\r\n        }\r\n\r\n        .navbar {\r\n            position: relative;\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -ms-flex-wrap: wrap;\r\n            flex-wrap: wrap;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center;\r\n            -webkit-box-pack: justify;\r\n            -ms-flex-pack: justify;\r\n            justify-content: space-between;\r\n            padding: .5rem 1rem\r\n        }\r\n\r\n            .navbar > .container, .navbar > .container-fluid {\r\n                display: -webkit-box;\r\n                display: -ms-flexbox;\r\n                display: flex;\r\n                -ms-flex-wrap: wrap;\r\n                flex-wrap: wrap;\r\n                -webkit-box-align: center;\r\n                -ms-flex-align: center;\r\n                align-items: center;\r\n                -webkit-box-pack: justify;\r\n                -ms-flex-pack: justify;\r\n                justify-content: space-between\r\n            }\r\n\r\n        .navbar-brand {\r\n            display: inline-block;\r\n            padding-top: .3125rem;\r\n            padding-bottom: .3125rem;\r\n            margin-right: 1rem;\r\n            font-size: 1.25rem;\r\n            line-height: inherit;\r\n            white-space: nowrap\r\n        }\r\n\r\n            .navbar-brand:focus, .navbar-brand:hover {\r\n                text-decoration: none\r\n            }\r\n\r\n        .navbar-nav {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column;\r\n            padding-left: 0;\r\n            margin-bottom: 0;\r\n            list-style: none\r\n        }\r\n\r\n            .navbar-nav .nav-link {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n\r\n            .navbar-nav .dropdown-menu {\r\n                position: static;\r\n                float: none\r\n            }\r\n\r\n        .navbar-text {\r\n            display: inline-block;\r\n            padding-top: .5rem;\r\n            padding-bottom: .5rem\r\n        }\r\n\r\n        .navbar-collapse {\r\n            -ms-flex-preferred-size: 100%;\r\n            flex-basis: 100%;\r\n            -webkit-box-flex: 1;\r\n            -ms-flex-positive: 1;\r\n            flex-grow: 1;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center\r\n        }\r\n\r\n        .navbar-toggler {\r\n            padding: .25rem .75rem;\r\n            font-size: 1.25rem;\r\n            line-height: 1;\r\n            background-color: transparent;\r\n            border: 1px solid transparent;\r\n            border-radius: .25rem\r\n        }\r\n\r\n            .navbar-toggler:focus, .navbar-toggler:hover {\r\n                text-decoration: none\r\n            }\r\n\r\n            .navbar-toggler:not(:disabled):not(.disabled) {\r\n                cursor: pointer\r\n            }\r\n\r\n        .navbar-toggler-icon {\r\n            display: inline-block;\r\n            width: 1.5em;\r\n            height: 1.5em;\r\n            vertical-align: middle;\r\n            content: \"\";\r\n            background: no-repeat center center;\r\n            background-size: 100% 100%\r\n        }\r\n\r\n        @media (max-width:575.98px) {\r\n            .navbar-expand-sm > .container, .navbar-expand-sm > .container-fluid {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .navbar-expand-sm {\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-flow: row nowrap;\r\n                flex-flow: row nowrap;\r\n                -webkit-box-pack: start;\r\n                -ms-flex-pack: start;\r\n                justify-content: flex-start\r\n            }\r\n\r\n                .navbar-expand-sm .navbar-nav {\r\n                    -webkit-box-orient: horizontal;\r\n                    -webkit-box-direction: normal;\r\n                    -ms-flex-direction: row;\r\n                    flex-direction: row\r\n                }\r\n\r\n                    .navbar-expand-sm .navbar-nav .dropdown-menu {\r\n                        position: absolute\r\n                    }\r\n\r\n                    .navbar-expand-sm .navbar-nav .dropdown-menu-right {\r\n                        right: 0;\r\n                        left: auto\r\n                    }\r\n\r\n                    .navbar-expand-sm .navbar-nav .nav-link {\r\n                        padding-right: .5rem;\r\n                        padding-left: .5rem\r\n                    }\r\n\r\n                .navbar-expand-sm > .container, .navbar-expand-sm > .container-fluid {\r\n                    -ms-flex-wrap: nowrap;\r\n                    flex-wrap: nowrap\r\n                }\r\n\r\n                .navbar-expand-sm .navbar-collapse {\r\n                    display: -webkit-box !important;\r\n                    display: -ms-flexbox !important;\r\n                    display: flex !important;\r\n                    -ms-flex-preferred-size: auto;\r\n                    flex-basis: auto\r\n                }\r\n\r\n                .navbar-expand-sm .navbar-toggler {\r\n                    display: none\r\n                }\r\n\r\n                .navbar-expand-sm .dropup .dropdown-menu {\r\n                    top: auto;\r\n                    bottom: 100%\r\n                }\r\n        }\r\n\r\n        @media (max-width:767.98px) {\r\n            .navbar-expand-md > .container, .navbar-expand-md > .container-fluid {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .navbar-expand-md {\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-flow: row nowrap;\r\n                flex-flow: row nowrap;\r\n                -webkit-box-pack: start;\r\n                -ms-flex-pack: start;\r\n                justify-content: flex-start\r\n            }\r\n\r\n                .navbar-expand-md .navbar-nav {\r\n                    -webkit-box-orient: horizontal;\r\n                    -webkit-box-direction: normal;\r\n                    -ms-flex-direction: row;\r\n                    flex-direction: row\r\n                }\r\n\r\n                    .navbar-expand-md .navbar-nav .dropdown-menu {\r\n                        position: absolute\r\n                    }\r\n\r\n                    .navbar-expand-md .navbar-nav .dropdown-menu-right {\r\n                        right: 0;\r\n                        left: auto\r\n                    }\r\n\r\n                    .navbar-expand-md .navbar-nav .nav-link {\r\n                        padding-right: .5rem;\r\n                        padding-left: .5rem\r\n                    }\r\n\r\n                .navbar-expand-md > .container, .navbar-expand-md > .container-fluid {\r\n                    -ms-flex-wrap: nowrap;\r\n                    flex-wrap: nowrap\r\n                }\r\n\r\n                .navbar-expand-md .navbar-collapse {\r\n                    display: -webkit-box !important;\r\n                    display: -ms-flexbox !important;\r\n                    display: flex !important;\r\n                    -ms-flex-preferred-size: auto;\r\n                    flex-basis: auto\r\n                }\r\n\r\n                .navbar-expand-md .navbar-toggler {\r\n                    display: none\r\n                }\r\n\r\n                .navbar-expand-md .dropup .dropdown-menu {\r\n                    top: auto;\r\n                    bottom: 100%\r\n                }\r\n        }\r\n\r\n        @media (max-width:991.98px) {\r\n            .navbar-expand-lg > .container, .navbar-expand-lg > .container-fluid {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .navbar-expand-lg {\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-flow: row nowrap;\r\n                flex-flow: row nowrap;\r\n                -webkit-box-pack: start;\r\n                -ms-flex-pack: start;\r\n                justify-content: flex-start\r\n            }\r\n\r\n                .navbar-expand-lg .navbar-nav {\r\n                    -webkit-box-orient: horizontal;\r\n                    -webkit-box-direction: normal;\r\n                    -ms-flex-direction: row;\r\n                    flex-direction: row\r\n                }\r\n\r\n                    .navbar-expand-lg .navbar-nav .dropdown-menu {\r\n                        position: absolute\r\n                    }\r\n\r\n                    .navbar-expand-lg .navbar-nav .dropdown-menu-right {\r\n                        right: 0;\r\n                        left: auto\r\n                    }\r\n\r\n                    .navbar-expand-lg .navbar-nav .nav-link {\r\n                        padding-right: .5rem;\r\n                        padding-left: .5rem\r\n                    }\r\n\r\n                .navbar-expand-lg > .container, .navbar-expand-lg > .container-fluid {\r\n                    -ms-flex-wrap: nowrap;\r\n                    flex-wrap: nowrap\r\n                }\r\n\r\n                .navbar-expand-lg .navbar-collapse {\r\n                    display: -webkit-box !important;\r\n                    display: -ms-flexbox !important;\r\n                    display: flex !important;\r\n                    -ms-flex-preferred-size: auto;\r\n                    flex-basis: auto\r\n                }\r\n\r\n                .navbar-expand-lg .navbar-toggler {\r\n                    display: none\r\n                }\r\n\r\n                .navbar-expand-lg .dropup .dropdown-menu {\r\n                    top: auto;\r\n                    bottom: 100%\r\n                }\r\n        }\r\n\r\n        @media (max-width:1199.98px) {\r\n            .navbar-expand-xl > .container, .navbar-expand-xl > .container-fluid {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .navbar-expand-xl {\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-flow: row nowrap;\r\n                flex-flow: row nowrap;\r\n                -webkit-box-pack: start;\r\n                -ms-flex-pack: start;\r\n                justify-content: flex-start\r\n            }\r\n\r\n                .navbar-expand-xl .navbar-nav {\r\n                    -webkit-box-orient: horizontal;\r\n                    -webkit-box-direction: normal;\r\n                    -ms-flex-direction: row;\r\n                    flex-direction: row\r\n                }\r\n\r\n                    .navbar-expand-xl .navbar-nav .dropdown-menu {\r\n                        position: absolute\r\n                    }\r\n\r\n                    .navbar-expand-xl .navbar-nav .dropdown-menu-right {\r\n                        right: 0;\r\n                        left: auto\r\n                    }\r\n\r\n                    .navbar-expand-xl .navbar-nav .nav-link {\r\n                        padding-right: .5rem;\r\n                        padding-left: .5rem\r\n                    }\r\n\r\n                .navbar-expand-xl > .container, .navbar-expand-xl > .container-fluid {\r\n                    -ms-flex-wrap: nowrap;\r\n                    flex-wrap: nowrap\r\n                }\r\n\r\n                .navbar-expand-xl .navbar-collapse {\r\n                    display: -webkit-box !important;\r\n                    display: -ms-flexbox !important;\r\n                    display: flex !important;\r\n                    -ms-flex-preferred-size: auto;\r\n                    flex-basis: auto\r\n                }\r\n\r\n                .navbar-expand-xl .navbar-toggler {\r\n                    display: none\r\n                }\r\n\r\n                .navbar-expand-xl .dropup .dropdown-menu {\r\n                    top: auto;\r\n                    bottom: 100%\r\n                }\r\n        }\r\n\r\n        .navbar-expand {\r\n            -webkit-box-orient: horizontal;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-flow: row nowrap;\r\n            flex-flow: row nowrap;\r\n            -webkit-box-pack: start;\r\n            -ms-flex-pack: start;\r\n            justify-content: flex-start\r\n        }\r\n\r\n            .navbar-expand > .container, .navbar-expand > .container-fluid {\r\n                padding-right: 0;\r\n                padding-left: 0\r\n            }\r\n\r\n            .navbar-expand .navbar-nav {\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-direction: row;\r\n                flex-direction: row\r\n            }\r\n\r\n                .navbar-expand .navbar-nav .dropdown-menu {\r\n                    position: absolute\r\n                }\r\n\r\n                .navbar-expand .navbar-nav .dropdown-menu-right {\r\n                    right: 0;\r\n                    left: auto\r\n                }\r\n\r\n                .navbar-expand .navbar-nav .nav-link {\r\n                    padding-right: .5rem;\r\n                    padding-left: .5rem\r\n                }\r\n\r\n            .navbar-expand > .container, .navbar-expand > .container-fluid {\r\n                -ms-flex-wrap: nowrap;\r\n                flex-wrap: nowrap\r\n            }\r\n\r\n            .navbar-expand .navbar-collapse {\r\n                display: -webkit-box !important;\r\n                display: -ms-flexbox !important;\r\n                display: flex !important;\r\n                -ms-flex-preferred-size: auto;\r\n                flex-basis: auto\r\n            }\r\n\r\n            .navbar-expand .navbar-toggler {\r\n                display: none\r\n            }\r\n\r\n            .navbar-expand .dropup .dropdown-menu {\r\n                top: auto;\r\n                bottom: 100%\r\n            }\r\n\r\n        .navbar-light .navbar-brand {\r\n            color: rgba(0,0,0,.9)\r\n        }\r\n\r\n            .navbar-light .navbar-brand:focus, .navbar-light .navbar-brand:hover {\r\n                color: rgba(0,0,0,.9)\r\n            }\r\n\r\n        .navbar-light .navbar-nav .nav-link {\r\n            color: rgba(0,0,0,.5)\r\n        }\r\n\r\n            .navbar-light .navbar-nav .nav-link:focus, .navbar-light .navbar-nav .nav-link:hover {\r\n                color: rgba(0,0,0,.7)\r\n            }\r\n\r\n            .navbar-light .navbar-nav .nav-link.disabled {\r\n                color: rgba(0,0,0,.3)\r\n            }\r\n\r\n            .navbar-light .navbar-nav .active > .nav-link, .navbar-light .navbar-nav .nav-link.active, .navbar-light .navbar-nav .nav-link.show, .navbar-light .navbar-nav .show > .nav-link {\r\n                color: rgba(0,0,0,.9)\r\n            }\r\n\r\n        .navbar-light .navbar-toggler {\r\n            color: rgba(0,0,0,.5);\r\n            border-color: rgba(0,0,0,.1)\r\n        }\r\n\r\n        .navbar-light .navbar-toggler-icon {\r\n            background-image: url(\"data:image/svg+xml;charset=utf8,%3Csvg viewBox='0 0 30 30' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath stroke='rgba(0, 0, 0, 0.5)' stroke-width='2' stroke-linecap='round' stroke-miterlimit='10' d='M4 7h22M4 15h22M4 23h22'/%3E%3C/svg%3E\")\r\n        }\r\n\r\n        .navbar-light .navbar-text {\r\n            color: rgba(0,0,0,.5)\r\n        }\r\n\r\n            .navbar-light .navbar-text a {\r\n                color: rgba(0,0,0,.9)\r\n            }\r\n\r\n                .navbar-light .navbar-text a:focus, .navbar-light .navbar-text a:hover {\r\n                    color: rgba(0,0,0,.9)\r\n                }\r\n\r\n        .navbar-dark .navbar-brand {\r\n            color: #fff\r\n        }\r\n\r\n            .navbar-dark .navbar-brand:focus, .navbar-dark .navbar-brand:hover {\r\n                color: #fff\r\n            }\r\n\r\n        .navbar-dark .navbar-nav .nav-link {\r\n            color: rgba(255,255,255,.5)\r\n        }\r\n\r\n            .navbar-dark .navbar-nav .nav-link:focus, .navbar-dark .navbar-nav .nav-link:hover {\r\n                color: rgba(255,255,255,.75)\r\n            }\r\n\r\n            .navbar-dark .navbar-nav .nav-link.disabled {\r\n                color: rgba(255,255,255,.25)\r\n            }\r\n\r\n            .navbar-dark .navbar-nav .active > .nav-link, .navbar-dark .navbar-nav .nav-link.active, .navbar-dark .navbar-nav .nav-link.show, .navbar-dark .navbar-nav .show > .nav-link {\r\n                color: #fff\r\n            }\r\n\r\n        .navbar-dark .navbar-toggler {\r\n            color: rgba(255,255,255,.5);\r\n            border-color: rgba(255,255,255,.1)\r\n        }\r\n\r\n        .navbar-dark .navbar-toggler-icon {\r\n            background-image: url(\"data:image/svg+xml;charset=utf8,%3Csvg viewBox='0 0 30 30' xmlns='http://www.w3.org/2000/svg'%3E%3Cpath stroke='rgba(255, 255, 255, 0.5)' stroke-width='2' stroke-linecap='round' stroke-miterlimit='10' d='M4 7h22M4 15h22M4 23h22'/%3E%3C/svg%3E\")\r\n        }\r\n\r\n        .navbar-dark .navbar-text {\r\n            color: rgba(255,255,255,.5)\r\n        }\r\n\r\n            .navbar-dark .navbar-text a {\r\n                color: #fff\r\n            }\r\n\r\n                .navbar-dark .navbar-text a:focus, .navbar-dark .navbar-text a:hover {\r\n                    color: #fff\r\n                }\r\n\r\n        .card {\r\n            position: relative;\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column;\r\n            min-width: 0;\r\n            word-wrap: break-word;\r\n            background-color: #fff;\r\n            background-clip: border-box;\r\n            border: 1px solid rgba(0,0,0,.125);\r\n            border-radius: .25rem\r\n        }\r\n\r\n            .card > hr {\r\n                margin-right: 0;\r\n                margin-left: 0\r\n            }\r\n\r\n            .card > .list-group:first-child .list-group-item:first-child {\r\n                border-top-left-radius: .25rem;\r\n                border-top-right-radius: .25rem\r\n            }\r\n\r\n            .card > .list-group:last-child .list-group-item:last-child {\r\n                border-bottom-right-radius: .25rem;\r\n                border-bottom-left-radius: .25rem\r\n            }\r\n\r\n        .card-body {\r\n            -webkit-box-flex: 1;\r\n            -ms-flex: 1 1 auto;\r\n            flex: 1 1 auto;\r\n            padding: 1.25rem\r\n        }\r\n\r\n        .card-title {\r\n            margin-bottom: .75rem\r\n        }\r\n\r\n        .card-subtitle {\r\n            margin-top: -.375rem;\r\n            margin-bottom: 0\r\n        }\r\n\r\n        .card-text:last-child {\r\n            margin-bottom: 0\r\n        }\r\n\r\n        .card-link:hover {\r\n            text-decoration: none\r\n        }\r\n\r\n        .card-link + .card-link {\r\n            margin-left: 1.25rem\r\n        }\r\n\r\n        .card-header {\r\n            padding: .75rem 1.25rem;\r\n            margin-bottom: 0;\r\n            background-color: rgba(0,0,0,.03);\r\n            border-bottom: 1px solid rgba(0,0,0,.125)\r\n        }\r\n\r\n            .card-header:first-child {\r\n                border-radius: calc(.25rem - 1px) calc(.25rem - 1px) 0 0\r\n            }\r\n\r\n            .card-header + .list-group .list-group-item:first-child {\r\n                border-top: 0\r\n            }\r\n\r\n        .card-footer {\r\n            padding: .75rem 1.25rem;\r\n            background-color: rgba(0,0,0,.03);\r\n            border-top: 1px solid rgba(0,0,0,.125)\r\n        }\r\n\r\n            .card-footer:last-child {\r\n                border-radius: 0 0 calc(.25rem - 1px) calc(.25rem - 1px)\r\n            }\r\n\r\n        .card-header-tabs {\r\n            margin-right: -.625rem;\r\n            margin-bottom: -.75rem;\r\n            margin-left: -.625rem;\r\n            border-bottom: 0\r\n        }\r\n\r\n        .card-header-pills {\r\n            margin-right: -.625rem;\r\n            margin-left: -.625rem\r\n        }\r\n\r\n        .card-img-overlay {\r\n            position: absolute;\r\n            top: 0;\r\n            right: 0;\r\n            bottom: 0;\r\n            left: 0;\r\n            padding: 1.25rem\r\n        }\r\n\r\n        .card-img {\r\n            width: 100%;\r\n            border-radius: calc(.25rem - 1px)\r\n        }\r\n\r\n        .card-img-top {\r\n            width: 100%;\r\n            border-top-left-radius: calc(.25rem - 1px);\r\n            border-top-right-radius: calc(.25rem - 1px)\r\n        }\r\n\r\n        .card-img-bottom {\r\n            width: 100%;\r\n            border-bottom-right-radius: calc(.25rem - 1px);\r\n            border-bottom-left-radius: calc(.25rem - 1px)\r\n        }\r\n\r\n        .card-deck {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column\r\n        }\r\n\r\n            .card-deck .card {\r\n                margin-bottom: 15px\r\n            }\r\n\r\n        @media (min-width:576px) {\r\n            .card-deck {\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-flow: row wrap;\r\n                flex-flow: row wrap;\r\n                margin-right: -15px;\r\n                margin-left: -15px\r\n            }\r\n\r\n                .card-deck .card {\r\n                    display: -webkit-box;\r\n                    display: -ms-flexbox;\r\n                    display: flex;\r\n                    -webkit-box-flex: 1;\r\n                    -ms-flex: 1 0 0%;\r\n                    flex: 1 0 0%;\r\n                    -webkit-box-orient: vertical;\r\n                    -webkit-box-direction: normal;\r\n                    -ms-flex-direction: column;\r\n                    flex-direction: column;\r\n                    margin-right: 15px;\r\n                    margin-bottom: 0;\r\n                    margin-left: 15px\r\n                }\r\n        }\r\n\r\n        .card-group {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column\r\n        }\r\n\r\n            .card-group > .card {\r\n                margin-bottom: 15px\r\n            }\r\n\r\n        @media (min-width:576px) {\r\n            .card-group {\r\n                -webkit-box-orient: horizontal;\r\n                -webkit-box-direction: normal;\r\n                -ms-flex-flow: row wrap;\r\n                flex-flow: row wrap\r\n            }\r\n\r\n                .card-group > .card {\r\n                    -webkit-box-flex: 1;\r\n                    -ms-flex: 1 0 0%;\r\n                    flex: 1 0 0%;\r\n                    margin-bottom: 0\r\n                }\r\n\r\n                    .card-group > .card + .card {\r\n                        margin-left: 0;\r\n                        border-left: 0\r\n                    }\r\n\r\n                    .card-group > .card:first-child {\r\n                        border-top-right-radius: 0;\r\n                        border-bottom-right-radius: 0\r\n                    }\r\n\r\n                        .card-group > .card:first-child .card-header, .card-group > .card:first-child .card-img-top {\r\n                            border-top-right-radius: 0\r\n                        }\r\n\r\n                        .card-group > .card:first-child .card-footer, .card-group > .card:first-child .card-img-bottom {\r\n                            border-bottom-right-radius: 0\r\n                        }\r\n\r\n                    .card-group > .card:last-child {\r\n                        border-top-left-radius: 0;\r\n                        border-bottom-left-radius: 0\r\n                    }\r\n\r\n                        .card-group > .card:last-child .card-header, .card-group > .card:last-child .card-img-top {\r\n                            border-top-left-radius: 0\r\n                        }\r\n\r\n                        .card-group > .card:last-child .card-footer, .card-group > .card:last-child .card-img-bottom {\r\n                            border-bottom-left-radius: 0\r\n                        }\r\n\r\n                    .card-group > .card:only-child {\r\n                        border-radius: .25rem\r\n                    }\r\n\r\n                        .card-group > .card:only-child .card-header, .card-group > .card:only-child .card-img-top {\r\n                            border-top-left-radius: .25rem;\r\n                            border-top-right-radius: .25rem\r\n                        }\r\n\r\n                        .card-group > .card:only-child .card-footer, .card-group > .card:only-child .card-img-bottom {\r\n                            border-bottom-right-radius: .25rem;\r\n                            border-bottom-left-radius: .25rem\r\n                        }\r\n\r\n                    .card-group > .card:not(:first-child):not(:last-child):not(:only-child) {\r\n                        border-radius: 0\r\n                    }\r\n\r\n                        .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-footer, .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-header, .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-img-bottom, .card-group > .card:not(:first-child):not(:last-child):not(:only-child) .card-img-top {\r\n                            border-radius: 0\r\n                        }\r\n        }\r\n\r\n        .card-columns .card {\r\n            margin-bottom: .75rem\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .card-columns {\r\n                -webkit-column-count: 3;\r\n                -moz-column-count: 3;\r\n                column-count: 3;\r\n                -webkit-column-gap: 1.25rem;\r\n                -moz-column-gap: 1.25rem;\r\n                column-gap: 1.25rem\r\n            }\r\n\r\n                .card-columns .card {\r\n                    display: inline-block;\r\n                    width: 100%\r\n                }\r\n        }\r\n\r\n        .breadcrumb {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -ms-flex-wrap: wrap;\r\n            flex-wrap: wrap;\r\n            padding: .75rem 1rem;\r\n            margin-bottom: 1rem;\r\n            list-style: none;\r\n            background-color: #e9ecef;\r\n            border-radius: .25rem\r\n        }\r\n\r\n        .breadcrumb-item + .breadcrumb-item::before {\r\n            display: inline-block;\r\n            padding-right: .5rem;\r\n            padding-left: .5rem;\r\n            color: #6c757d;\r\n            content: \"/\"\r\n        }\r\n\r\n        .breadcrumb-item + .breadcrumb-item:hover::before {\r\n            text-decoration: underline\r\n        }\r\n\r\n        .breadcrumb-item + .breadcrumb-item:hover::before {\r\n            text-decoration: none\r\n        }\r\n\r\n        .breadcrumb-item.active {\r\n            color: #6c757d\r\n        }\r\n\r\n        .pagination {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            padding-left: 0;\r\n            list-style: none;\r\n            border-radius: .25rem\r\n        }\r\n\r\n        .page-link {\r\n            position: relative;\r\n            display: block;\r\n            padding: .5rem .75rem;\r\n            margin-left: -1px;\r\n            line-height: 1.25;\r\n            color: #007bff;\r\n            background-color: #fff;\r\n            border: 1px solid #dee2e6\r\n        }\r\n\r\n            .page-link:hover {\r\n                color: #0056b3;\r\n                text-decoration: none;\r\n                background-color: #e9ecef;\r\n                border-color: #dee2e6\r\n            }\r\n\r\n            .page-link:focus {\r\n                z-index: 2;\r\n                outline: 0;\r\n                box-shadow: 0 0 0 .2rem rgba(0,123,255,.25)\r\n            }\r\n\r\n            .page-link:not(:disabled):not(.disabled) {\r\n                cursor: pointer\r\n            }\r\n\r\n        .page-item:first-child .page-link {\r\n            margin-left: 0;\r\n            border-top-left-radius: .25rem;\r\n            border-bottom-left-radius: .25rem\r\n        }\r\n\r\n        .page-item:last-child .page-link {\r\n            border-top-right-radius: .25rem;\r\n            border-bottom-right-radius: .25rem\r\n        }\r\n\r\n        .page-item.active .page-link {\r\n            z-index: 1;\r\n            color: #fff;\r\n            background-color: #007bff;\r\n            border-color: #007bff\r\n        }\r\n\r\n        .page-item.disabled .page-link {\r\n            color: #6c757d;\r\n            pointer-events: none;\r\n            cursor: auto;\r\n            background-color: #fff;\r\n            border-color: #dee2e6\r\n        }\r\n\r\n        .pagination-lg .page-link {\r\n            padding: .75rem 1.5rem;\r\n            font-size: 1.25rem;\r\n            line-height: 1.5\r\n        }\r\n\r\n        .pagination-lg .page-item:first-child .page-link {\r\n            border-top-left-radius: .3rem;\r\n            border-bottom-left-radius: .3rem\r\n        }\r\n\r\n        .pagination-lg .page-item:last-child .page-link {\r\n            border-top-right-radius: .3rem;\r\n            border-bottom-right-radius: .3rem\r\n        }\r\n\r\n        .pagination-sm .page-link {\r\n            padding: .25rem .5rem;\r\n            font-size: .875rem;\r\n            line-height: 1.5\r\n        }\r\n\r\n        .pagination-sm .page-item:first-child .page-link {\r\n            border-top-left-radius: .2rem;\r\n            border-bottom-left-radius: .2rem\r\n        }\r\n\r\n        .pagination-sm .page-item:last-child .page-link {\r\n            border-top-right-radius: .2rem;\r\n            border-bottom-right-radius: .2rem\r\n        }\r\n\r\n        .badge {\r\n            display: inline-block;\r\n            padding: .25em .4em;\r\n            font-size: 75%;\r\n            font-weight: 700;\r\n            line-height: 1;\r\n            text-align: center;\r\n            white-space: nowrap;\r\n            vertical-align: baseline;\r\n            border-radius: .25rem\r\n        }\r\n\r\n            .badge:empty {\r\n                display: none\r\n            }\r\n\r\n        .btn .badge {\r\n            position: relative;\r\n            top: -1px\r\n        }\r\n\r\n        .badge-pill {\r\n            padding-right: .6em;\r\n            padding-left: .6em;\r\n            border-radius: 10rem\r\n        }\r\n\r\n        .badge-primary {\r\n            color: #fff;\r\n            background-color: #007bff\r\n        }\r\n\r\n            .badge-primary[href]:focus, .badge-primary[href]:hover {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                background-color: #0062cc\r\n            }\r\n\r\n        .badge-secondary {\r\n            color: #fff;\r\n            background-color: #6c757d\r\n        }\r\n\r\n            .badge-secondary[href]:focus, .badge-secondary[href]:hover {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                background-color: #545b62\r\n            }\r\n\r\n        .badge-success {\r\n            color: #fff;\r\n            background-color: #28a745\r\n        }\r\n\r\n            .badge-success[href]:focus, .badge-success[href]:hover {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                background-color: #1e7e34\r\n            }\r\n\r\n        .badge-info {\r\n            color: #fff;\r\n            background-color: #17a2b8\r\n        }\r\n\r\n            .badge-info[href]:focus, .badge-info[href]:hover {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                background-color: #117a8b\r\n            }\r\n\r\n        .badge-warning {\r\n            color: #212529;\r\n            background-color: #ffc107\r\n        }\r\n\r\n            .badge-warning[href]:focus, .badge-warning[href]:hover {\r\n                color: #212529;\r\n                text-decoration: none;\r\n                background-color: #d39e00\r\n            }\r\n\r\n        .badge-danger {\r\n            color: #fff;\r\n            background-color: #dc3545\r\n        }\r\n\r\n            .badge-danger[href]:focus, .badge-danger[href]:hover {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                background-color: #bd2130\r\n            }\r\n\r\n        .badge-light {\r\n            color: #212529;\r\n            background-color: #f8f9fa\r\n        }\r\n\r\n            .badge-light[href]:focus, .badge-light[href]:hover {\r\n                color: #212529;\r\n                text-decoration: none;\r\n                background-color: #dae0e5\r\n            }\r\n\r\n        .badge-dark {\r\n            color: #fff;\r\n            background-color: #343a40\r\n        }\r\n\r\n            .badge-dark[href]:focus, .badge-dark[href]:hover {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                background-color: #1d2124\r\n            }\r\n\r\n        .jumbotron {\r\n            padding: 2rem 1rem;\r\n            margin-bottom: 2rem;\r\n            background-color: #e9ecef;\r\n            border-radius: .3rem\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .jumbotron {\r\n                padding: 4rem 2rem\r\n            }\r\n        }\r\n\r\n        .jumbotron-fluid {\r\n            padding-right: 0;\r\n            padding-left: 0;\r\n            border-radius: 0\r\n        }\r\n\r\n        .alert {\r\n            position: relative;\r\n            padding: .75rem 1.25rem;\r\n            margin-bottom: 1rem;\r\n            border: 1px solid transparent;\r\n            border-radius: .25rem\r\n        }\r\n\r\n        .alert-heading {\r\n            color: inherit\r\n        }\r\n\r\n        .alert-link {\r\n            font-weight: 700\r\n        }\r\n\r\n        .alert-dismissible {\r\n            padding-right: 4rem\r\n        }\r\n\r\n            .alert-dismissible .close {\r\n                position: absolute;\r\n                top: 0;\r\n                right: 0;\r\n                padding: .75rem 1.25rem;\r\n                color: inherit\r\n            }\r\n\r\n        .alert-primary {\r\n            color: #004085;\r\n            background-color: #cce5ff;\r\n            border-color: #b8daff\r\n        }\r\n\r\n            .alert-primary hr {\r\n                border-top-color: #9fcdff\r\n            }\r\n\r\n            .alert-primary .alert-link {\r\n                color: #002752\r\n            }\r\n\r\n        .alert-secondary {\r\n            color: #383d41;\r\n            background-color: #e2e3e5;\r\n            border-color: #d6d8db\r\n        }\r\n\r\n            .alert-secondary hr {\r\n                border-top-color: #c8cbcf\r\n            }\r\n\r\n            .alert-secondary .alert-link {\r\n                color: #202326\r\n            }\r\n\r\n        .alert-success {\r\n            color: #155724;\r\n            background-color: #d4edda;\r\n            border-color: #c3e6cb\r\n        }\r\n\r\n            .alert-success hr {\r\n                border-top-color: #b1dfbb\r\n            }\r\n\r\n            .alert-success .alert-link {\r\n                color: #0b2e13\r\n            }\r\n\r\n        .alert-info {\r\n            color: #0c5460;\r\n            background-color: #d1ecf1;\r\n            border-color: #bee5eb\r\n        }\r\n\r\n            .alert-info hr {\r\n                border-top-color: #abdde5\r\n            }\r\n\r\n            .alert-info .alert-link {\r\n                color: #062c33\r\n            }\r\n\r\n        .alert-warning {\r\n            color: #856404;\r\n            background-color: #fff3cd;\r\n            border-color: #ffeeba\r\n        }\r\n\r\n            .alert-warning hr {\r\n                border-top-color: #ffe8a1\r\n            }\r\n\r\n            .alert-warning .alert-link {\r\n                color: #533f03\r\n            }\r\n\r\n        .alert-danger {\r\n            color: #721c24;\r\n            background-color: #f8d7da;\r\n            border-color: #f5c6cb\r\n        }\r\n\r\n            .alert-danger hr {\r\n                border-top-color: #f1b0b7\r\n            }\r\n\r\n            .alert-danger .alert-link {\r\n                color: #491217\r\n            }\r\n\r\n        .alert-light {\r\n            color: #818182;\r\n            background-color: #fefefe;\r\n            border-color: #fdfdfe\r\n        }\r\n\r\n            .alert-light hr {\r\n                border-top-color: #ececf6\r\n            }\r\n\r\n            .alert-light .alert-link {\r\n                color: #686868\r\n            }\r\n\r\n        .alert-dark {\r\n            color: #1b1e21;\r\n            background-color: #d6d8d9;\r\n            border-color: #c6c8ca\r\n        }\r\n\r\n            .alert-dark hr {\r\n                border-top-color: #b9bbbe\r\n            }\r\n\r\n            .alert-dark .alert-link {\r\n                color: #040505\r\n            }\r\n\r\n        @-webkit-keyframes progress-bar-stripes {\r\n            from {\r\n                background-position: 1rem 0\r\n            }\r\n\r\n            to {\r\n                background-position: 0 0\r\n            }\r\n        }\r\n\r\n        @keyframes progress-bar-stripes {\r\n            from {\r\n                background-position: 1rem 0\r\n            }\r\n\r\n            to {\r\n                background-position: 0 0\r\n            }\r\n        }\r\n\r\n        .progress {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            height: 1rem;\r\n            overflow: hidden;\r\n            font-size: .75rem;\r\n            background-color: #e9ecef;\r\n            border-radius: .25rem\r\n        }\r\n\r\n        .progress-bar {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column;\r\n            -webkit-box-pack: center;\r\n            -ms-flex-pack: center;\r\n            justify-content: center;\r\n            color: #fff;\r\n            text-align: center;\r\n            background-color: #007bff;\r\n            transition: width .6s ease\r\n        }\r\n\r\n        .progress-bar-striped {\r\n            background-image: linear-gradient(45deg,rgba(255,255,255,.15) 25%,transparent 25%,transparent 50%,rgba(255,255,255,.15) 50%,rgba(255,255,255,.15) 75%,transparent 75%,transparent);\r\n            background-size: 1rem 1rem\r\n        }\r\n\r\n        .progress-bar-animated {\r\n            -webkit-animation: progress-bar-stripes 1s linear infinite;\r\n            animation: progress-bar-stripes 1s linear infinite\r\n        }\r\n\r\n        .media {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-align: start;\r\n            -ms-flex-align: start;\r\n            align-items: flex-start\r\n        }\r\n\r\n        .media-body {\r\n            -webkit-box-flex: 1;\r\n            -ms-flex: 1;\r\n            flex: 1\r\n        }\r\n\r\n        .list-group {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column;\r\n            padding-left: 0;\r\n            margin-bottom: 0\r\n        }\r\n\r\n        .list-group-item-action {\r\n            width: 100%;\r\n            color: #495057;\r\n            text-align: inherit\r\n        }\r\n\r\n            .list-group-item-action:focus, .list-group-item-action:hover {\r\n                color: #495057;\r\n                text-decoration: none;\r\n                background-color: #f8f9fa\r\n            }\r\n\r\n            .list-group-item-action:active {\r\n                color: #212529;\r\n                background-color: #e9ecef\r\n            }\r\n\r\n        .list-group-item {\r\n            position: relative;\r\n            display: block;\r\n            padding: .75rem 1.25rem;\r\n            margin-bottom: -1px;\r\n            background-color: #fff;\r\n            border: 1px solid rgba(0,0,0,.125)\r\n        }\r\n\r\n            .list-group-item:first-child {\r\n                border-top-left-radius: .25rem;\r\n                border-top-right-radius: .25rem\r\n            }\r\n\r\n            .list-group-item:last-child {\r\n                margin-bottom: 0;\r\n                border-bottom-right-radius: .25rem;\r\n                border-bottom-left-radius: .25rem\r\n            }\r\n\r\n            .list-group-item:focus, .list-group-item:hover {\r\n                z-index: 1;\r\n                text-decoration: none\r\n            }\r\n\r\n            .list-group-item.disabled, .list-group-item:disabled {\r\n                color: #6c757d;\r\n                background-color: #fff\r\n            }\r\n\r\n            .list-group-item.active {\r\n                z-index: 2;\r\n                color: #fff;\r\n                background-color: #007bff;\r\n                border-color: #007bff\r\n            }\r\n\r\n        .list-group-flush .list-group-item {\r\n            border-right: 0;\r\n            border-left: 0;\r\n            border-radius: 0\r\n        }\r\n\r\n        .list-group-flush:first-child .list-group-item:first-child {\r\n            border-top: 0\r\n        }\r\n\r\n        .list-group-flush:last-child .list-group-item:last-child {\r\n            border-bottom: 0\r\n        }\r\n\r\n        .list-group-item-primary {\r\n            color: #004085;\r\n            background-color: #b8daff\r\n        }\r\n\r\n            .list-group-item-primary.list-group-item-action:focus, .list-group-item-primary.list-group-item-action:hover {\r\n                color: #004085;\r\n                background-color: #9fcdff\r\n            }\r\n\r\n            .list-group-item-primary.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #004085;\r\n                border-color: #004085\r\n            }\r\n\r\n        .list-group-item-secondary {\r\n            color: #383d41;\r\n            background-color: #d6d8db\r\n        }\r\n\r\n            .list-group-item-secondary.list-group-item-action:focus, .list-group-item-secondary.list-group-item-action:hover {\r\n                color: #383d41;\r\n                background-color: #c8cbcf\r\n            }\r\n\r\n            .list-group-item-secondary.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #383d41;\r\n                border-color: #383d41\r\n            }\r\n\r\n        .list-group-item-success {\r\n            color: #155724;\r\n            background-color: #c3e6cb\r\n        }\r\n\r\n            .list-group-item-success.list-group-item-action:focus, .list-group-item-success.list-group-item-action:hover {\r\n                color: #155724;\r\n                background-color: #b1dfbb\r\n            }\r\n\r\n            .list-group-item-success.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #155724;\r\n                border-color: #155724\r\n            }\r\n\r\n        .list-group-item-info {\r\n            color: #0c5460;\r\n            background-color: #bee5eb\r\n        }\r\n\r\n            .list-group-item-info.list-group-item-action:focus, .list-group-item-info.list-group-item-action:hover {\r\n                color: #0c5460;\r\n                background-color: #abdde5\r\n            }\r\n\r\n            .list-group-item-info.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #0c5460;\r\n                border-color: #0c5460\r\n            }\r\n\r\n        .list-group-item-warning {\r\n            color: #856404;\r\n            background-color: #ffeeba\r\n        }\r\n\r\n            .list-group-item-warning.list-group-item-action:focus, .list-group-item-warning.list-group-item-action:hover {\r\n                color: #856404;\r\n                background-color: #ffe8a1\r\n            }\r\n\r\n            .list-group-item-warning.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #856404;\r\n                border-color: #856404\r\n            }\r\n\r\n        .list-group-item-danger {\r\n            color: #721c24;\r\n            background-color: #f5c6cb\r\n        }\r\n\r\n            .list-group-item-danger.list-group-item-action:focus, .list-group-item-danger.list-group-item-action:hover {\r\n                color: #721c24;\r\n                background-color: #f1b0b7\r\n            }\r\n\r\n            .list-group-item-danger.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #721c24;\r\n                border-color: #721c24\r\n            }\r\n\r\n        .list-group-item-light {\r\n            color: #818182;\r\n            background-color: #fdfdfe\r\n        }\r\n\r\n            .list-group-item-light.list-group-item-action:focus, .list-group-item-light.list-group-item-action:hover {\r\n                color: #818182;\r\n                background-color: #ececf6\r\n            }\r\n\r\n            .list-group-item-light.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #818182;\r\n                border-color: #818182\r\n            }\r\n\r\n        .list-group-item-dark {\r\n            color: #1b1e21;\r\n            background-color: #c6c8ca\r\n        }\r\n\r\n            .list-group-item-dark.list-group-item-action:focus, .list-group-item-dark.list-group-item-action:hover {\r\n                color: #1b1e21;\r\n                background-color: #b9bbbe\r\n            }\r\n\r\n            .list-group-item-dark.list-group-item-action.active {\r\n                color: #fff;\r\n                background-color: #1b1e21;\r\n                border-color: #1b1e21\r\n            }\r\n\r\n        .close {\r\n            float: right;\r\n            font-size: 1.5rem;\r\n            font-weight: 700;\r\n            line-height: 1;\r\n            color: #000;\r\n            text-shadow: 0 1px 0 #fff;\r\n            opacity: .5\r\n        }\r\n\r\n            .close:focus, .close:hover {\r\n                color: #000;\r\n                text-decoration: none;\r\n                opacity: .75\r\n            }\r\n\r\n            .close:not(:disabled):not(.disabled) {\r\n                cursor: pointer\r\n            }\r\n\r\n        button.close {\r\n            padding: 0;\r\n            background-color: transparent;\r\n            border: 0;\r\n            -webkit-appearance: none\r\n        }\r\n\r\n        .modal-open {\r\n            overflow: hidden\r\n        }\r\n\r\n        .modal {\r\n            position: fixed;\r\n            top: 0;\r\n            right: 0;\r\n            bottom: 0;\r\n            left: 0;\r\n            z-index: 1050;\r\n            display: none;\r\n            overflow: hidden;\r\n            outline: 0\r\n        }\r\n\r\n        .modal-open .modal {\r\n            overflow-x: hidden;\r\n            overflow-y: auto\r\n        }\r\n\r\n        .modal-dialog {\r\n            position: relative;\r\n            width: auto;\r\n            margin: .5rem;\r\n            pointer-events: none\r\n        }\r\n\r\n        .modal.fade .modal-dialog {\r\n            transition: -webkit-transform .3s ease-out;\r\n            transition: transform .3s ease-out;\r\n            transition: transform .3s ease-out,-webkit-transform .3s ease-out;\r\n            -webkit-transform: translate(0,-25%);\r\n            transform: translate(0,-25%)\r\n        }\r\n\r\n        .modal.show .modal-dialog {\r\n            -webkit-transform: translate(0,0);\r\n            transform: translate(0,0)\r\n        }\r\n\r\n        .modal-dialog-centered {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center;\r\n            min-height: calc(100% - (.5rem * 2))\r\n        }\r\n\r\n        .modal-content {\r\n            position: relative;\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-orient: vertical;\r\n            -webkit-box-direction: normal;\r\n            -ms-flex-direction: column;\r\n            flex-direction: column;\r\n            width: 100%;\r\n            pointer-events: auto;\r\n            background-color: #fff;\r\n            background-clip: padding-box;\r\n            border: 1px solid rgba(0,0,0,.2);\r\n            border-radius: .3rem;\r\n            outline: 0\r\n        }\r\n\r\n        .modal-backdrop {\r\n            position: fixed;\r\n            top: 0;\r\n            right: 0;\r\n            bottom: 0;\r\n            left: 0;\r\n            z-index: 1040;\r\n            background-color: #000\r\n        }\r\n\r\n            .modal-backdrop.fade {\r\n                opacity: 0\r\n            }\r\n\r\n            .modal-backdrop.show {\r\n                opacity: .5\r\n            }\r\n\r\n        .modal-header {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-align: start;\r\n            -ms-flex-align: start;\r\n            align-items: flex-start;\r\n            -webkit-box-pack: justify;\r\n            -ms-flex-pack: justify;\r\n            justify-content: space-between;\r\n            padding: 1rem;\r\n            border-bottom: 1px solid #e9ecef;\r\n            border-top-left-radius: .3rem;\r\n            border-top-right-radius: .3rem\r\n        }\r\n\r\n            .modal-header .close {\r\n                padding: 1rem;\r\n                margin: -1rem -1rem -1rem auto\r\n            }\r\n\r\n        .modal-title {\r\n            margin-bottom: 0;\r\n            line-height: 1.5\r\n        }\r\n\r\n        .modal-body {\r\n            position: relative;\r\n            -webkit-box-flex: 1;\r\n            -ms-flex: 1 1 auto;\r\n            flex: 1 1 auto;\r\n            padding: 1rem\r\n        }\r\n\r\n        .modal-footer {\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center;\r\n            -webkit-box-pack: end;\r\n            -ms-flex-pack: end;\r\n            justify-content: flex-end;\r\n            padding: 1rem;\r\n            border-top: 1px solid #e9ecef\r\n        }\r\n\r\n            .modal-footer > :not(:first-child) {\r\n                margin-left: .25rem\r\n            }\r\n\r\n            .modal-footer > :not(:last-child) {\r\n                margin-right: .25rem\r\n            }\r\n\r\n        .modal-scrollbar-measure {\r\n            position: absolute;\r\n            top: -9999px;\r\n            width: 50px;\r\n            height: 50px;\r\n            overflow: scroll\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .modal-dialog {\r\n                max-width: 500px;\r\n                margin: 1.75rem auto\r\n            }\r\n\r\n            .modal-dialog-centered {\r\n                min-height: calc(100% - (1.75rem * 2))\r\n            }\r\n\r\n            .modal-sm {\r\n                max-width: 300px\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .modal-lg {\r\n                max-width: 800px\r\n            }\r\n        }\r\n\r\n        .tooltip {\r\n            position: absolute;\r\n            z-index: 1070;\r\n            display: block;\r\n            margin: 0;\r\n            font-family: -apple-system,BlinkMacSystemFont,\"Segoe UI\",Roboto,\"Helvetica Neue\",Arial,sans-serif,\"Apple Color Emoji\",\"Segoe UI Emoji\",\"Segoe UI Symbol\";\r\n            font-style: normal;\r\n            font-weight: 400;\r\n            line-height: 1.5;\r\n            text-align: left;\r\n            text-align: start;\r\n            text-decoration: none;\r\n            text-shadow: none;\r\n            text-transform: none;\r\n            letter-spacing: normal;\r\n            word-break: normal;\r\n            word-spacing: normal;\r\n            white-space: normal;\r\n            line-break: auto;\r\n            font-size: .875rem;\r\n            word-wrap: break-word;\r\n            opacity: 0\r\n        }\r\n\r\n            .tooltip.show {\r\n                opacity: .9\r\n            }\r\n\r\n            .tooltip .arrow {\r\n                position: absolute;\r\n                display: block;\r\n                width: .8rem;\r\n                height: .4rem\r\n            }\r\n\r\n                .tooltip .arrow::before {\r\n                    position: absolute;\r\n                    content: \"\";\r\n                    border-color: transparent;\r\n                    border-style: solid\r\n                }\r\n\r\n        .bs-tooltip-auto[x-placement^=top], .bs-tooltip-top {\r\n            padding: .4rem 0\r\n        }\r\n\r\n            .bs-tooltip-auto[x-placement^=top] .arrow, .bs-tooltip-top .arrow {\r\n                bottom: 0\r\n            }\r\n\r\n                .bs-tooltip-auto[x-placement^=top] .arrow::before, .bs-tooltip-top .arrow::before {\r\n                    top: 0;\r\n                    border-width: .4rem .4rem 0;\r\n                    border-top-color: #000\r\n                }\r\n\r\n        .bs-tooltip-auto[x-placement^=right], .bs-tooltip-right {\r\n            padding: 0 .4rem\r\n        }\r\n\r\n            .bs-tooltip-auto[x-placement^=right] .arrow, .bs-tooltip-right .arrow {\r\n                left: 0;\r\n                width: .4rem;\r\n                height: .8rem\r\n            }\r\n\r\n                .bs-tooltip-auto[x-placement^=right] .arrow::before, .bs-tooltip-right .arrow::before {\r\n                    right: 0;\r\n                    border-width: .4rem .4rem .4rem 0;\r\n                    border-right-color: #000\r\n                }\r\n\r\n        .bs-tooltip-auto[x-placement^=bottom], .bs-tooltip-bottom {\r\n            padding: .4rem 0\r\n        }\r\n\r\n            .bs-tooltip-auto[x-placement^=bottom] .arrow, .bs-tooltip-bottom .arrow {\r\n                top: 0\r\n            }\r\n\r\n                .bs-tooltip-auto[x-placement^=bottom] .arrow::before, .bs-tooltip-bottom .arrow::before {\r\n                    bottom: 0;\r\n                    border-width: 0 .4rem .4rem;\r\n                    border-bottom-color: #000\r\n                }\r\n\r\n        .bs-tooltip-auto[x-placement^=left], .bs-tooltip-left {\r\n            padding: 0 .4rem\r\n        }\r\n\r\n            .bs-tooltip-auto[x-placement^=left] .arrow, .bs-tooltip-left .arrow {\r\n                right: 0;\r\n                width: .4rem;\r\n                height: .8rem\r\n            }\r\n\r\n                .bs-tooltip-auto[x-placement^=left] .arrow::before, .bs-tooltip-left .arrow::before {\r\n                    left: 0;\r\n                    border-width: .4rem 0 .4rem .4rem;\r\n                    border-left-color: #000\r\n                }\r\n\r\n        .tooltip-inner {\r\n            max-width: 200px;\r\n            padding: .25rem .5rem;\r\n            color: #fff;\r\n            text-align: center;\r\n            background-color: #000;\r\n            border-radius: .25rem\r\n        }\r\n\r\n        .popover {\r\n            position: absolute;\r\n            top: 0;\r\n            left: 0;\r\n            z-index: 1060;\r\n            display: block;\r\n            max-width: 276px;\r\n            font-family: -apple-system,BlinkMacSystemFont,\"Segoe UI\",Roboto,\"Helvetica Neue\",Arial,sans-serif,\"Apple Color Emoji\",\"Segoe UI Emoji\",\"Segoe UI Symbol\";\r\n            font-style: normal;\r\n            font-weight: 400;\r\n            line-height: 1.5;\r\n            text-align: left;\r\n            text-align: start;\r\n            text-decoration: none;\r\n            text-shadow: none;\r\n            text-transform: none;\r\n            letter-spacing: normal;\r\n            word-break: normal;\r\n            word-spacing: normal;\r\n            white-space: normal;\r\n            line-break: auto;\r\n            font-size: .875rem;\r\n            word-wrap: break-word;\r\n            background-color: #fff;\r\n            background-clip: padding-box;\r\n            border: 1px solid rgba(0,0,0,.2);\r\n            border-radius: .3rem\r\n        }\r\n\r\n            .popover .arrow {\r\n                position: absolute;\r\n                display: block;\r\n                width: 1rem;\r\n                height: .5rem;\r\n                margin: 0 .3rem\r\n            }\r\n\r\n                .popover .arrow::after, .popover .arrow::before {\r\n                    position: absolute;\r\n                    display: block;\r\n                    content: \"\";\r\n                    border-color: transparent;\r\n                    border-style: solid\r\n                }\r\n\r\n        .bs-popover-auto[x-placement^=top], .bs-popover-top {\r\n            margin-bottom: .5rem\r\n        }\r\n\r\n            .bs-popover-auto[x-placement^=top] .arrow, .bs-popover-top .arrow {\r\n                bottom: calc((.5rem + 1px) * -1)\r\n            }\r\n\r\n                .bs-popover-auto[x-placement^=top] .arrow::after, .bs-popover-auto[x-placement^=top] .arrow::before, .bs-popover-top .arrow::after, .bs-popover-top .arrow::before {\r\n                    border-width: .5rem .5rem 0\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=top] .arrow::before, .bs-popover-top .arrow::before {\r\n                    bottom: 0;\r\n                    border-top-color: rgba(0,0,0,.25)\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=top] .arrow::after, .bs-popover-top .arrow::after {\r\n                    bottom: 1px;\r\n                    border-top-color: #fff\r\n                }\r\n\r\n        .bs-popover-auto[x-placement^=right], .bs-popover-right {\r\n            margin-left: .5rem\r\n        }\r\n\r\n            .bs-popover-auto[x-placement^=right] .arrow, .bs-popover-right .arrow {\r\n                left: calc((.5rem + 1px) * -1);\r\n                width: .5rem;\r\n                height: 1rem;\r\n                margin: .3rem 0\r\n            }\r\n\r\n                .bs-popover-auto[x-placement^=right] .arrow::after, .bs-popover-auto[x-placement^=right] .arrow::before, .bs-popover-right .arrow::after, .bs-popover-right .arrow::before {\r\n                    border-width: .5rem .5rem .5rem 0\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=right] .arrow::before, .bs-popover-right .arrow::before {\r\n                    left: 0;\r\n                    border-right-color: rgba(0,0,0,.25)\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=right] .arrow::after, .bs-popover-right .arrow::after {\r\n                    left: 1px;\r\n                    border-right-color: #fff\r\n                }\r\n\r\n        .bs-popover-auto[x-placement^=bottom], .bs-popover-bottom {\r\n            margin-top: .5rem\r\n        }\r\n\r\n            .bs-popover-auto[x-placement^=bottom] .arrow, .bs-popover-bottom .arrow {\r\n                top: calc((.5rem + 1px) * -1)\r\n            }\r\n\r\n                .bs-popover-auto[x-placement^=bottom] .arrow::after, .bs-popover-auto[x-placement^=bottom] .arrow::before, .bs-popover-bottom .arrow::after, .bs-popover-bottom .arrow::before {\r\n                    border-width: 0 .5rem .5rem .5rem\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=bottom] .arrow::before, .bs-popover-bottom .arrow::before {\r\n                    top: 0;\r\n                    border-bottom-color: rgba(0,0,0,.25)\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=bottom] .arrow::after, .bs-popover-bottom .arrow::after {\r\n                    top: 1px;\r\n                    border-bottom-color: #fff\r\n                }\r\n\r\n            .bs-popover-auto[x-placement^=bottom] .popover-header::before, .bs-popover-bottom .popover-header::before {\r\n                position: absolute;\r\n                top: 0;\r\n                left: 50%;\r\n                display: block;\r\n                width: 1rem;\r\n                margin-left: -.5rem;\r\n                content: \"\";\r\n                border-bottom: 1px solid #f7f7f7\r\n            }\r\n\r\n        .bs-popover-auto[x-placement^=left], .bs-popover-left {\r\n            margin-right: .5rem\r\n        }\r\n\r\n            .bs-popover-auto[x-placement^=left] .arrow, .bs-popover-left .arrow {\r\n                right: calc((.5rem + 1px) * -1);\r\n                width: .5rem;\r\n                height: 1rem;\r\n                margin: .3rem 0\r\n            }\r\n\r\n                .bs-popover-auto[x-placement^=left] .arrow::after, .bs-popover-auto[x-placement^=left] .arrow::before, .bs-popover-left .arrow::after, .bs-popover-left .arrow::before {\r\n                    border-width: .5rem 0 .5rem .5rem\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=left] .arrow::before, .bs-popover-left .arrow::before {\r\n                    right: 0;\r\n                    border-left-color: rgba(0,0,0,.25)\r\n                }\r\n\r\n                .bs-popover-auto[x-placement^=left] .arrow::after, .bs-popover-left .arrow::after {\r\n                    right: 1px;\r\n                    border-left-color: #fff\r\n                }\r\n\r\n        .popover-header {\r\n            padding: .5rem .75rem;\r\n            margin-bottom: 0;\r\n            font-size: 1rem;\r\n            color: inherit;\r\n            background-color: #f7f7f7;\r\n            border-bottom: 1px solid #ebebeb;\r\n            border-top-left-radius: calc(.3rem - 1px);\r\n            border-top-right-radius: calc(.3rem - 1px)\r\n        }\r\n\r\n            .popover-header:empty {\r\n                display: none\r\n            }\r\n\r\n        .popover-body {\r\n            padding: .5rem .75rem;\r\n            color: #212529\r\n        }\r\n\r\n        .carousel {\r\n            position: relative\r\n        }\r\n\r\n        .carousel-inner {\r\n            position: relative;\r\n            width: 100%;\r\n            overflow: hidden\r\n        }\r\n\r\n        .carousel-item {\r\n            position: relative;\r\n            display: none;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center;\r\n            width: 100%;\r\n            transition: -webkit-transform .6s ease;\r\n            transition: transform .6s ease;\r\n            transition: transform .6s ease,-webkit-transform .6s ease;\r\n            -webkit-backface-visibility: hidden;\r\n            backface-visibility: hidden;\r\n            -webkit-perspective: 1000px;\r\n            perspective: 1000px\r\n        }\r\n\r\n            .carousel-item-next, .carousel-item-prev, .carousel-item.active {\r\n                display: block\r\n            }\r\n\r\n        .carousel-item-next, .carousel-item-prev {\r\n            position: absolute;\r\n            top: 0\r\n        }\r\n\r\n            .carousel-item-next.carousel-item-left, .carousel-item-prev.carousel-item-right {\r\n                -webkit-transform: translateX(0);\r\n                transform: translateX(0)\r\n            }\r\n\r\n        @supports ((-webkit-transform-style:preserve-3d) or (transform-style:preserve-3d)) {\r\n            .carousel-item-next.carousel-item-left, .carousel-item-prev.carousel-item-right {\r\n                -webkit-transform: translate3d(0,0,0);\r\n                transform: translate3d(0,0,0)\r\n            }\r\n        }\r\n\r\n        .active.carousel-item-right, .carousel-item-next {\r\n            -webkit-transform: translateX(100%);\r\n            transform: translateX(100%)\r\n        }\r\n\r\n        @supports ((-webkit-transform-style:preserve-3d) or (transform-style:preserve-3d)) {\r\n            .active.carousel-item-right, .carousel-item-next {\r\n                -webkit-transform: translate3d(100%,0,0);\r\n                transform: translate3d(100%,0,0)\r\n            }\r\n        }\r\n\r\n        .active.carousel-item-left, .carousel-item-prev {\r\n            -webkit-transform: translateX(-100%);\r\n            transform: translateX(-100%)\r\n        }\r\n\r\n        @supports ((-webkit-transform-style:preserve-3d) or (transform-style:preserve-3d)) {\r\n            .active.carousel-item-left, .carousel-item-prev {\r\n                -webkit-transform: translate3d(-100%,0,0);\r\n                transform: translate3d(-100%,0,0)\r\n            }\r\n        }\r\n\r\n        .carousel-control-next, .carousel-control-prev {\r\n            position: absolute;\r\n            top: 0;\r\n            bottom: 0;\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-align: center;\r\n            -ms-flex-align: center;\r\n            align-items: center;\r\n            -webkit-box-pack: center;\r\n            -ms-flex-pack: center;\r\n            justify-content: center;\r\n            width: 15%;\r\n            color: #fff;\r\n            text-align: center;\r\n            opacity: .5\r\n        }\r\n\r\n            .carousel-control-next:focus, .carousel-control-next:hover, .carousel-control-prev:focus, .carousel-control-prev:hover {\r\n                color: #fff;\r\n                text-decoration: none;\r\n                outline: 0;\r\n                opacity: .9\r\n            }\r\n\r\n        .carousel-control-prev {\r\n            left: 0\r\n        }\r\n\r\n        .carousel-control-next {\r\n            right: 0\r\n        }\r\n\r\n        .carousel-control-next-icon, .carousel-control-prev-icon {\r\n            display: inline-block;\r\n            width: 20px;\r\n            height: 20px;\r\n            background: transparent no-repeat center center;\r\n            background-size: 100% 100%\r\n        }\r\n\r\n        .carousel-control-prev-icon {\r\n            background-image: url(\"data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M5.25 0l-4 4 4 4 1.5-1.5-2.5-2.5 2.5-2.5-1.5-1.5z'/%3E%3C/svg%3E\")\r\n        }\r\n\r\n        .carousel-control-next-icon {\r\n            background-image: url(\"data:image/svg+xml;charset=utf8,%3Csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' viewBox='0 0 8 8'%3E%3Cpath d='M2.75 0l-1.5 1.5 2.5 2.5-2.5 2.5 1.5 1.5 4-4-4-4z'/%3E%3C/svg%3E\")\r\n        }\r\n\r\n        .carousel-indicators {\r\n            position: absolute;\r\n            right: 0;\r\n            bottom: 10px;\r\n            left: 0;\r\n            z-index: 15;\r\n            display: -webkit-box;\r\n            display: -ms-flexbox;\r\n            display: flex;\r\n            -webkit-box-pack: center;\r\n            -ms-flex-pack: center;\r\n            justify-content: center;\r\n            padding-left: 0;\r\n            margin-right: 15%;\r\n            margin-left: 15%;\r\n            list-style: none\r\n        }\r\n\r\n            .carousel-indicators li {\r\n                position: relative;\r\n                -webkit-box-flex: 0;\r\n                -ms-flex: 0 1 auto;\r\n                flex: 0 1 auto;\r\n                width: 30px;\r\n                height: 3px;\r\n                margin-right: 3px;\r\n                margin-left: 3px;\r\n                text-indent: -999px;\r\n                background-color: rgba(255,255,255,.5)\r\n            }\r\n\r\n                .carousel-indicators li::before {\r\n                    position: absolute;\r\n                    top: -10px;\r\n                    left: 0;\r\n                    display: inline-block;\r\n                    width: 100%;\r\n                    height: 10px;\r\n                    content: \"\"\r\n                }\r\n\r\n                .carousel-indicators li::after {\r\n                    position: absolute;\r\n                    bottom: -10px;\r\n                    left: 0;\r\n                    display: inline-block;\r\n                    width: 100%;\r\n                    height: 10px;\r\n                    content: \"\"\r\n                }\r\n\r\n            .carousel-indicators .active {\r\n                background-color: #fff\r\n            }\r\n\r\n        .carousel-caption {\r\n            position: absolute;\r\n            right: 15%;\r\n            bottom: 20px;\r\n            left: 15%;\r\n            z-index: 10;\r\n            padding-top: 20px;\r\n            padding-bottom: 20px;\r\n            color: #fff;\r\n            text-align: center\r\n        }\r\n\r\n        .align-baseline {\r\n            vertical-align: baseline !important\r\n        }\r\n\r\n        .align-top {\r\n            vertical-align: top !important\r\n        }\r\n\r\n        .align-middle {\r\n            vertical-align: middle !important\r\n        }\r\n\r\n        .align-bottom {\r\n            vertical-align: bottom !important\r\n        }\r\n\r\n        .align-text-bottom {\r\n            vertical-align: text-bottom !important\r\n        }\r\n\r\n        .align-text-top {\r\n            vertical-align: text-top !important\r\n        }\r\n\r\n        .bg-primary {\r\n            background-color: #007bff !important\r\n        }\r\n\r\n        a.bg-primary:focus, a.bg-primary:hover, button.bg-primary:focus, button.bg-primary:hover {\r\n            background-color: #0062cc !important\r\n        }\r\n\r\n        .bg-secondary {\r\n            background-color: #6c757d !important\r\n        }\r\n\r\n        a.bg-secondary:focus, a.bg-secondary:hover, button.bg-secondary:focus, button.bg-secondary:hover {\r\n            background-color: #545b62 !important\r\n        }\r\n\r\n        .bg-success {\r\n            background-color: #28a745 !important\r\n        }\r\n\r\n        a.bg-success:focus, a.bg-success:hover, button.bg-success:focus, button.bg-success:hover {\r\n            background-color: #1e7e34 !important\r\n        }\r\n\r\n        .bg-info {\r\n            background-color: #17a2b8 !important\r\n        }\r\n\r\n        a.bg-info:focus, a.bg-info:hover, button.bg-info:focus, button.bg-info:hover {\r\n            background-color: #117a8b !important\r\n        }\r\n\r\n        .bg-warning {\r\n            background-color: #ffc107 !important\r\n        }\r\n\r\n        a.bg-warning:focus, a.bg-warning:hover, button.bg-warning:focus, button.bg-warning:hover {\r\n            background-color: #d39e00 !important\r\n        }\r\n\r\n        .bg-danger {\r\n            background-color: #dc3545 !important\r\n        }\r\n\r\n        a.bg-danger:focus, a.bg-danger:hover, button.bg-danger:focus, button.bg-danger:hover {\r\n            background-color: #bd2130 !important\r\n        }\r\n\r\n        .bg-light {\r\n            background-color: #f8f9fa !important\r\n        }\r\n\r\n        a.bg-light:focus, a.bg-light:hover, button.bg-light:focus, button.bg-light:hover {\r\n            background-color: #dae0e5 !important\r\n        }\r\n\r\n        .bg-dark {\r\n            background-color: #343a40 !important\r\n        }\r\n\r\n        a.bg-dark:focus, a.bg-dark:hover, button.bg-dark:focus, button.bg-dark:hover {\r\n            background-color: #1d2124 !important\r\n        }\r\n\r\n        .bg-white {\r\n            background-color: #fff !important\r\n        }\r\n\r\n        .bg-transparent {\r\n            background-color: transparent !important\r\n        }\r\n\r\n        .border {\r\n            border: 1px solid #dee2e6 !important\r\n        }\r\n\r\n        .border-top {\r\n            border-top: 1px solid #dee2e6 !important\r\n        }\r\n\r\n        .border-right {\r\n            border-right: 1px solid #dee2e6 !important\r\n        }\r\n\r\n        .border-bottom {\r\n            border-bottom: 1px solid #dee2e6 !important\r\n        }\r\n\r\n        .border-left {\r\n            border-left: 1px solid #dee2e6 !important\r\n        }\r\n\r\n        .border-0 {\r\n            border: 0 !important\r\n        }\r\n\r\n        .border-top-0 {\r\n            border-top: 0 !important\r\n        }\r\n\r\n        .border-right-0 {\r\n            border-right: 0 !important\r\n        }\r\n\r\n        .border-bottom-0 {\r\n            border-bottom: 0 !important\r\n        }\r\n\r\n        .border-left-0 {\r\n            border-left: 0 !important\r\n        }\r\n\r\n        .border-primary {\r\n            border-color: #007bff !important\r\n        }\r\n\r\n        .border-secondary {\r\n            border-color: #6c757d !important\r\n        }\r\n\r\n        .border-success {\r\n            border-color: #28a745 !important\r\n        }\r\n\r\n        .border-info {\r\n            border-color: #17a2b8 !important\r\n        }\r\n\r\n        .border-warning {\r\n            border-color: #ffc107 !important\r\n        }\r\n\r\n        .border-danger {\r\n            border-color: #dc3545 !important\r\n        }\r\n\r\n        .border-light {\r\n            border-color: #f8f9fa !important\r\n        }\r\n\r\n        .border-dark {\r\n            border-color: #343a40 !important\r\n        }\r\n\r\n        .border-white {\r\n            border-color: #fff !important\r\n        }\r\n\r\n        .rounded {\r\n            border-radius: .25rem !important\r\n        }\r\n\r\n        .rounded-top {\r\n            border-top-left-radius: .25rem !important;\r\n            border-top-right-radius: .25rem !important\r\n        }\r\n\r\n        .rounded-right {\r\n            border-top-right-radius: .25rem !important;\r\n            border-bottom-right-radius: .25rem !important\r\n        }\r\n\r\n        .rounded-bottom {\r\n            border-bottom-right-radius: .25rem !important;\r\n            border-bottom-left-radius: .25rem !important\r\n        }\r\n\r\n        .rounded-left {\r\n            border-top-left-radius: .25rem !important;\r\n            border-bottom-left-radius: .25rem !important\r\n        }\r\n\r\n        .rounded-circle {\r\n            border-radius: 50% !important\r\n        }\r\n\r\n        .rounded-0 {\r\n            border-radius: 0 !important\r\n        }\r\n\r\n        .clearfix::after {\r\n            display: block;\r\n            clear: both;\r\n            content: \"\"\r\n        }\r\n\r\n        .d-none {\r\n            display: none !important\r\n        }\r\n\r\n        .d-inline {\r\n            display: inline !important\r\n        }\r\n\r\n        .d-inline-block {\r\n            display: inline-block !important\r\n        }\r\n\r\n        .d-block {\r\n            display: block !important\r\n        }\r\n\r\n        .d-table {\r\n            display: table !important\r\n        }\r\n\r\n        .d-table-row {\r\n            display: table-row !important\r\n        }\r\n\r\n        .d-table-cell {\r\n            display: table-cell !important\r\n        }\r\n\r\n        .d-flex {\r\n            display: -webkit-box !important;\r\n            display: -ms-flexbox !important;\r\n            display: flex !important\r\n        }\r\n\r\n        .d-inline-flex {\r\n            display: -webkit-inline-box !important;\r\n            display: -ms-inline-flexbox !important;\r\n            display: inline-flex !important\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .d-sm-none {\r\n                display: none !important\r\n            }\r\n\r\n            .d-sm-inline {\r\n                display: inline !important\r\n            }\r\n\r\n            .d-sm-inline-block {\r\n                display: inline-block !important\r\n            }\r\n\r\n            .d-sm-block {\r\n                display: block !important\r\n            }\r\n\r\n            .d-sm-table {\r\n                display: table !important\r\n            }\r\n\r\n            .d-sm-table-row {\r\n                display: table-row !important\r\n            }\r\n\r\n            .d-sm-table-cell {\r\n                display: table-cell !important\r\n            }\r\n\r\n            .d-sm-flex {\r\n                display: -webkit-box !important;\r\n                display: -ms-flexbox !important;\r\n                display: flex !important\r\n            }\r\n\r\n            .d-sm-inline-flex {\r\n                display: -webkit-inline-box !important;\r\n                display: -ms-inline-flexbox !important;\r\n                display: inline-flex !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .d-md-none {\r\n                display: none !important\r\n            }\r\n\r\n            .d-md-inline {\r\n                display: inline !important\r\n            }\r\n\r\n            .d-md-inline-block {\r\n                display: inline-block !important\r\n            }\r\n\r\n            .d-md-block {\r\n                display: block !important\r\n            }\r\n\r\n            .d-md-table {\r\n                display: table !important\r\n            }\r\n\r\n            .d-md-table-row {\r\n                display: table-row !important\r\n            }\r\n\r\n            .d-md-table-cell {\r\n                display: table-cell !important\r\n            }\r\n\r\n            .d-md-flex {\r\n                display: -webkit-box !important;\r\n                display: -ms-flexbox !important;\r\n                display: flex !important\r\n            }\r\n\r\n            .d-md-inline-flex {\r\n                display: -webkit-inline-box !important;\r\n                display: -ms-inline-flexbox !important;\r\n                display: inline-flex !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .d-lg-none {\r\n                display: none !important\r\n            }\r\n\r\n            .d-lg-inline {\r\n                display: inline !important\r\n            }\r\n\r\n            .d-lg-inline-block {\r\n                display: inline-block !important\r\n            }\r\n\r\n            .d-lg-block {\r\n                display: block !important\r\n            }\r\n\r\n            .d-lg-table {\r\n                display: table !important\r\n            }\r\n\r\n            .d-lg-table-row {\r\n                display: table-row !important\r\n            }\r\n\r\n            .d-lg-table-cell {\r\n                display: table-cell !important\r\n            }\r\n\r\n            .d-lg-flex {\r\n                display: -webkit-box !important;\r\n                display: -ms-flexbox !important;\r\n                display: flex !important\r\n            }\r\n\r\n            .d-lg-inline-flex {\r\n                display: -webkit-inline-box !important;\r\n                display: -ms-inline-flexbox !important;\r\n                display: inline-flex !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .d-xl-none {\r\n                display: none !important\r\n            }\r\n\r\n            .d-xl-inline {\r\n                display: inline !important\r\n            }\r\n\r\n            .d-xl-inline-block {\r\n                display: inline-block !important\r\n            }\r\n\r\n            .d-xl-block {\r\n                display: block !important\r\n            }\r\n\r\n            .d-xl-table {\r\n                display: table !important\r\n            }\r\n\r\n            .d-xl-table-row {\r\n                display: table-row !important\r\n            }\r\n\r\n            .d-xl-table-cell {\r\n                display: table-cell !important\r\n            }\r\n\r\n            .d-xl-flex {\r\n                display: -webkit-box !important;\r\n                display: -ms-flexbox !important;\r\n                display: flex !important\r\n            }\r\n\r\n            .d-xl-inline-flex {\r\n                display: -webkit-inline-box !important;\r\n                display: -ms-inline-flexbox !important;\r\n                display: inline-flex !important\r\n            }\r\n        }\r\n\r\n        @media print {\r\n            .d-print-none {\r\n                display: none !important\r\n            }\r\n\r\n            .d-print-inline {\r\n                display: inline !important\r\n            }\r\n\r\n            .d-print-inline-block {\r\n                display: inline-block !important\r\n            }\r\n\r\n            .d-print-block {\r\n                display: block !important\r\n            }\r\n\r\n            .d-print-table {\r\n                display: table !important\r\n            }\r\n\r\n            .d-print-table-row {\r\n                display: table-row !important\r\n            }\r\n\r\n            .d-print-table-cell {\r\n                display: table-cell !important\r\n            }\r\n\r\n            .d-print-flex {\r\n                display: -webkit-box !important;\r\n                display: -ms-flexbox !important;\r\n                display: flex !important\r\n            }\r\n\r\n            .d-print-inline-flex {\r\n                display: -webkit-inline-box !important;\r\n                display: -ms-inline-flexbox !important;\r\n                display: inline-flex !important\r\n            }\r\n        }\r\n\r\n        .embed-responsive {\r\n            position: relative;\r\n            display: block;\r\n            width: 100%;\r\n            padding: 0;\r\n            overflow: hidden\r\n        }\r\n\r\n            .embed-responsive::before {\r\n                display: block;\r\n                content: \"\"\r\n            }\r\n\r\n            .embed-responsive .embed-responsive-item, .embed-responsive embed, .embed-responsive iframe, .embed-responsive object, .embed-responsive video {\r\n                position: absolute;\r\n                top: 0;\r\n                bottom: 0;\r\n                left: 0;\r\n                width: 100%;\r\n                height: 100%;\r\n                border: 0\r\n            }\r\n\r\n        .embed-responsive-21by9::before {\r\n            padding-top: 42.857143%\r\n        }\r\n\r\n        .embed-responsive-16by9::before {\r\n            padding-top: 56.25%\r\n        }\r\n\r\n        .embed-responsive-4by3::before {\r\n            padding-top: 75%\r\n        }\r\n\r\n        .embed-responsive-1by1::before {\r\n            padding-top: 100%\r\n        }\r\n\r\n        .flex-row {\r\n            -webkit-box-orient: horizontal !important;\r\n            -webkit-box-direction: normal !important;\r\n            -ms-flex-direction: row !important;\r\n            flex-direction: row !important\r\n        }\r\n\r\n        .flex-column {\r\n            -webkit-box-orient: vertical !important;\r\n            -webkit-box-direction: normal !important;\r\n            -ms-flex-direction: column !important;\r\n            flex-direction: column !important\r\n        }\r\n\r\n        .flex-row-reverse {\r\n            -webkit-box-orient: horizontal !important;\r\n            -webkit-box-direction: reverse !important;\r\n            -ms-flex-direction: row-reverse !important;\r\n            flex-direction: row-reverse !important\r\n        }\r\n\r\n        .flex-column-reverse {\r\n            -webkit-box-orient: vertical !important;\r\n            -webkit-box-direction: reverse !important;\r\n            -ms-flex-direction: column-reverse !important;\r\n            flex-direction: column-reverse !important\r\n        }\r\n\r\n        .flex-wrap {\r\n            -ms-flex-wrap: wrap !important;\r\n            flex-wrap: wrap !important\r\n        }\r\n\r\n        .flex-nowrap {\r\n            -ms-flex-wrap: nowrap !important;\r\n            flex-wrap: nowrap !important\r\n        }\r\n\r\n        .flex-wrap-reverse {\r\n            -ms-flex-wrap: wrap-reverse !important;\r\n            flex-wrap: wrap-reverse !important\r\n        }\r\n\r\n        .justify-content-start {\r\n            -webkit-box-pack: start !important;\r\n            -ms-flex-pack: start !important;\r\n            justify-content: flex-start !important\r\n        }\r\n\r\n        .justify-content-end {\r\n            -webkit-box-pack: end !important;\r\n            -ms-flex-pack: end !important;\r\n            justify-content: flex-end !important\r\n        }\r\n\r\n        .justify-content-center {\r\n            -webkit-box-pack: center !important;\r\n            -ms-flex-pack: center !important;\r\n            justify-content: center !important\r\n        }\r\n\r\n        .justify-content-between {\r\n            -webkit-box-pack: justify !important;\r\n            -ms-flex-pack: justify !important;\r\n            justify-content: space-between !important\r\n        }\r\n\r\n        .justify-content-around {\r\n            -ms-flex-pack: distribute !important;\r\n            justify-content: space-around !important\r\n        }\r\n\r\n        .align-items-start {\r\n            -webkit-box-align: start !important;\r\n            -ms-flex-align: start !important;\r\n            align-items: flex-start !important\r\n        }\r\n\r\n        .align-items-end {\r\n            -webkit-box-align: end !important;\r\n            -ms-flex-align: end !important;\r\n            align-items: flex-end !important\r\n        }\r\n\r\n        .align-items-center {\r\n            -webkit-box-align: center !important;\r\n            -ms-flex-align: center !important;\r\n            align-items: center !important\r\n        }\r\n\r\n        .align-items-baseline {\r\n            -webkit-box-align: baseline !important;\r\n            -ms-flex-align: baseline !important;\r\n            align-items: baseline !important\r\n        }\r\n\r\n        .align-items-stretch {\r\n            -webkit-box-align: stretch !important;\r\n            -ms-flex-align: stretch !important;\r\n            align-items: stretch !important\r\n        }\r\n\r\n        .align-content-start {\r\n            -ms-flex-line-pack: start !important;\r\n            align-content: flex-start !important\r\n        }\r\n\r\n        .align-content-end {\r\n            -ms-flex-line-pack: end !important;\r\n            align-content: flex-end !important\r\n        }\r\n\r\n        .align-content-center {\r\n            -ms-flex-line-pack: center !important;\r\n            align-content: center !important\r\n        }\r\n\r\n        .align-content-between {\r\n            -ms-flex-line-pack: justify !important;\r\n            align-content: space-between !important\r\n        }\r\n\r\n        .align-content-around {\r\n            -ms-flex-line-pack: distribute !important;\r\n            align-content: space-around !important\r\n        }\r\n\r\n        .align-content-stretch {\r\n            -ms-flex-line-pack: stretch !important;\r\n            align-content: stretch !important\r\n        }\r\n\r\n        .align-self-auto {\r\n            -ms-flex-item-align: auto !important;\r\n            align-self: auto !important\r\n        }\r\n\r\n        .align-self-start {\r\n            -ms-flex-item-align: start !important;\r\n            align-self: flex-start !important\r\n        }\r\n\r\n        .align-self-end {\r\n            -ms-flex-item-align: end !important;\r\n            align-self: flex-end !important\r\n        }\r\n\r\n        .align-self-center {\r\n            -ms-flex-item-align: center !important;\r\n            align-self: center !important\r\n        }\r\n\r\n        .align-self-baseline {\r\n            -ms-flex-item-align: baseline !important;\r\n            align-self: baseline !important\r\n        }\r\n\r\n        .align-self-stretch {\r\n            -ms-flex-item-align: stretch !important;\r\n            align-self: stretch !important\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .flex-sm-row {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: row !important;\r\n                flex-direction: row !important\r\n            }\r\n\r\n            .flex-sm-column {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: column !important;\r\n                flex-direction: column !important\r\n            }\r\n\r\n            .flex-sm-row-reverse {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: row-reverse !important;\r\n                flex-direction: row-reverse !important\r\n            }\r\n\r\n            .flex-sm-column-reverse {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: column-reverse !important;\r\n                flex-direction: column-reverse !important\r\n            }\r\n\r\n            .flex-sm-wrap {\r\n                -ms-flex-wrap: wrap !important;\r\n                flex-wrap: wrap !important\r\n            }\r\n\r\n            .flex-sm-nowrap {\r\n                -ms-flex-wrap: nowrap !important;\r\n                flex-wrap: nowrap !important\r\n            }\r\n\r\n            .flex-sm-wrap-reverse {\r\n                -ms-flex-wrap: wrap-reverse !important;\r\n                flex-wrap: wrap-reverse !important\r\n            }\r\n\r\n            .justify-content-sm-start {\r\n                -webkit-box-pack: start !important;\r\n                -ms-flex-pack: start !important;\r\n                justify-content: flex-start !important\r\n            }\r\n\r\n            .justify-content-sm-end {\r\n                -webkit-box-pack: end !important;\r\n                -ms-flex-pack: end !important;\r\n                justify-content: flex-end !important\r\n            }\r\n\r\n            .justify-content-sm-center {\r\n                -webkit-box-pack: center !important;\r\n                -ms-flex-pack: center !important;\r\n                justify-content: center !important\r\n            }\r\n\r\n            .justify-content-sm-between {\r\n                -webkit-box-pack: justify !important;\r\n                -ms-flex-pack: justify !important;\r\n                justify-content: space-between !important\r\n            }\r\n\r\n            .justify-content-sm-around {\r\n                -ms-flex-pack: distribute !important;\r\n                justify-content: space-around !important\r\n            }\r\n\r\n            .align-items-sm-start {\r\n                -webkit-box-align: start !important;\r\n                -ms-flex-align: start !important;\r\n                align-items: flex-start !important\r\n            }\r\n\r\n            .align-items-sm-end {\r\n                -webkit-box-align: end !important;\r\n                -ms-flex-align: end !important;\r\n                align-items: flex-end !important\r\n            }\r\n\r\n            .align-items-sm-center {\r\n                -webkit-box-align: center !important;\r\n                -ms-flex-align: center !important;\r\n                align-items: center !important\r\n            }\r\n\r\n            .align-items-sm-baseline {\r\n                -webkit-box-align: baseline !important;\r\n                -ms-flex-align: baseline !important;\r\n                align-items: baseline !important\r\n            }\r\n\r\n            .align-items-sm-stretch {\r\n                -webkit-box-align: stretch !important;\r\n                -ms-flex-align: stretch !important;\r\n                align-items: stretch !important\r\n            }\r\n\r\n            .align-content-sm-start {\r\n                -ms-flex-line-pack: start !important;\r\n                align-content: flex-start !important\r\n            }\r\n\r\n            .align-content-sm-end {\r\n                -ms-flex-line-pack: end !important;\r\n                align-content: flex-end !important\r\n            }\r\n\r\n            .align-content-sm-center {\r\n                -ms-flex-line-pack: center !important;\r\n                align-content: center !important\r\n            }\r\n\r\n            .align-content-sm-between {\r\n                -ms-flex-line-pack: justify !important;\r\n                align-content: space-between !important\r\n            }\r\n\r\n            .align-content-sm-around {\r\n                -ms-flex-line-pack: distribute !important;\r\n                align-content: space-around !important\r\n            }\r\n\r\n            .align-content-sm-stretch {\r\n                -ms-flex-line-pack: stretch !important;\r\n                align-content: stretch !important\r\n            }\r\n\r\n            .align-self-sm-auto {\r\n                -ms-flex-item-align: auto !important;\r\n                align-self: auto !important\r\n            }\r\n\r\n            .align-self-sm-start {\r\n                -ms-flex-item-align: start !important;\r\n                align-self: flex-start !important\r\n            }\r\n\r\n            .align-self-sm-end {\r\n                -ms-flex-item-align: end !important;\r\n                align-self: flex-end !important\r\n            }\r\n\r\n            .align-self-sm-center {\r\n                -ms-flex-item-align: center !important;\r\n                align-self: center !important\r\n            }\r\n\r\n            .align-self-sm-baseline {\r\n                -ms-flex-item-align: baseline !important;\r\n                align-self: baseline !important\r\n            }\r\n\r\n            .align-self-sm-stretch {\r\n                -ms-flex-item-align: stretch !important;\r\n                align-self: stretch !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .flex-md-row {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: row !important;\r\n                flex-direction: row !important\r\n            }\r\n\r\n            .flex-md-column {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: column !important;\r\n                flex-direction: column !important\r\n            }\r\n\r\n            .flex-md-row-reverse {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: row-reverse !important;\r\n                flex-direction: row-reverse !important\r\n            }\r\n\r\n            .flex-md-column-reverse {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: column-reverse !important;\r\n                flex-direction: column-reverse !important\r\n            }\r\n\r\n            .flex-md-wrap {\r\n                -ms-flex-wrap: wrap !important;\r\n                flex-wrap: wrap !important\r\n            }\r\n\r\n            .flex-md-nowrap {\r\n                -ms-flex-wrap: nowrap !important;\r\n                flex-wrap: nowrap !important\r\n            }\r\n\r\n            .flex-md-wrap-reverse {\r\n                -ms-flex-wrap: wrap-reverse !important;\r\n                flex-wrap: wrap-reverse !important\r\n            }\r\n\r\n            .justify-content-md-start {\r\n                -webkit-box-pack: start !important;\r\n                -ms-flex-pack: start !important;\r\n                justify-content: flex-start !important\r\n            }\r\n\r\n            .justify-content-md-end {\r\n                -webkit-box-pack: end !important;\r\n                -ms-flex-pack: end !important;\r\n                justify-content: flex-end !important\r\n            }\r\n\r\n            .justify-content-md-center {\r\n                -webkit-box-pack: center !important;\r\n                -ms-flex-pack: center !important;\r\n                justify-content: center !important\r\n            }\r\n\r\n            .justify-content-md-between {\r\n                -webkit-box-pack: justify !important;\r\n                -ms-flex-pack: justify !important;\r\n                justify-content: space-between !important\r\n            }\r\n\r\n            .justify-content-md-around {\r\n                -ms-flex-pack: distribute !important;\r\n                justify-content: space-around !important\r\n            }\r\n\r\n            .align-items-md-start {\r\n                -webkit-box-align: start !important;\r\n                -ms-flex-align: start !important;\r\n                align-items: flex-start !important\r\n            }\r\n\r\n            .align-items-md-end {\r\n                -webkit-box-align: end !important;\r\n                -ms-flex-align: end !important;\r\n                align-items: flex-end !important\r\n            }\r\n\r\n            .align-items-md-center {\r\n                -webkit-box-align: center !important;\r\n                -ms-flex-align: center !important;\r\n                align-items: center !important\r\n            }\r\n\r\n            .align-items-md-baseline {\r\n                -webkit-box-align: baseline !important;\r\n                -ms-flex-align: baseline !important;\r\n                align-items: baseline !important\r\n            }\r\n\r\n            .align-items-md-stretch {\r\n                -webkit-box-align: stretch !important;\r\n                -ms-flex-align: stretch !important;\r\n                align-items: stretch !important\r\n            }\r\n\r\n            .align-content-md-start {\r\n                -ms-flex-line-pack: start !important;\r\n                align-content: flex-start !important\r\n            }\r\n\r\n            .align-content-md-end {\r\n                -ms-flex-line-pack: end !important;\r\n                align-content: flex-end !important\r\n            }\r\n\r\n            .align-content-md-center {\r\n                -ms-flex-line-pack: center !important;\r\n                align-content: center !important\r\n            }\r\n\r\n            .align-content-md-between {\r\n                -ms-flex-line-pack: justify !important;\r\n                align-content: space-between !important\r\n            }\r\n\r\n            .align-content-md-around {\r\n                -ms-flex-line-pack: distribute !important;\r\n                align-content: space-around !important\r\n            }\r\n\r\n            .align-content-md-stretch {\r\n                -ms-flex-line-pack: stretch !important;\r\n                align-content: stretch !important\r\n            }\r\n\r\n            .align-self-md-auto {\r\n                -ms-flex-item-align: auto !important;\r\n                align-self: auto !important\r\n            }\r\n\r\n            .align-self-md-start {\r\n                -ms-flex-item-align: start !important;\r\n                align-self: flex-start !important\r\n            }\r\n\r\n            .align-self-md-end {\r\n                -ms-flex-item-align: end !important;\r\n                align-self: flex-end !important\r\n            }\r\n\r\n            .align-self-md-center {\r\n                -ms-flex-item-align: center !important;\r\n                align-self: center !important\r\n            }\r\n\r\n            .align-self-md-baseline {\r\n                -ms-flex-item-align: baseline !important;\r\n                align-self: baseline !important\r\n            }\r\n\r\n            .align-self-md-stretch {\r\n                -ms-flex-item-align: stretch !important;\r\n                align-self: stretch !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .flex-lg-row {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: row !important;\r\n                flex-direction: row !important\r\n            }\r\n\r\n            .flex-lg-column {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: column !important;\r\n                flex-direction: column !important\r\n            }\r\n\r\n            .flex-lg-row-reverse {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: row-reverse !important;\r\n                flex-direction: row-reverse !important\r\n            }\r\n\r\n            .flex-lg-column-reverse {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: column-reverse !important;\r\n                flex-direction: column-reverse !important\r\n            }\r\n\r\n            .flex-lg-wrap {\r\n                -ms-flex-wrap: wrap !important;\r\n                flex-wrap: wrap !important\r\n            }\r\n\r\n            .flex-lg-nowrap {\r\n                -ms-flex-wrap: nowrap !important;\r\n                flex-wrap: nowrap !important\r\n            }\r\n\r\n            .flex-lg-wrap-reverse {\r\n                -ms-flex-wrap: wrap-reverse !important;\r\n                flex-wrap: wrap-reverse !important\r\n            }\r\n\r\n            .justify-content-lg-start {\r\n                -webkit-box-pack: start !important;\r\n                -ms-flex-pack: start !important;\r\n                justify-content: flex-start !important\r\n            }\r\n\r\n            .justify-content-lg-end {\r\n                -webkit-box-pack: end !important;\r\n                -ms-flex-pack: end !important;\r\n                justify-content: flex-end !important\r\n            }\r\n\r\n            .justify-content-lg-center {\r\n                -webkit-box-pack: center !important;\r\n                -ms-flex-pack: center !important;\r\n                justify-content: center !important\r\n            }\r\n\r\n            .justify-content-lg-between {\r\n                -webkit-box-pack: justify !important;\r\n                -ms-flex-pack: justify !important;\r\n                justify-content: space-between !important\r\n            }\r\n\r\n            .justify-content-lg-around {\r\n                -ms-flex-pack: distribute !important;\r\n                justify-content: space-around !important\r\n            }\r\n\r\n            .align-items-lg-start {\r\n                -webkit-box-align: start !important;\r\n                -ms-flex-align: start !important;\r\n                align-items: flex-start !important\r\n            }\r\n\r\n            .align-items-lg-end {\r\n                -webkit-box-align: end !important;\r\n                -ms-flex-align: end !important;\r\n                align-items: flex-end !important\r\n            }\r\n\r\n            .align-items-lg-center {\r\n                -webkit-box-align: center !important;\r\n                -ms-flex-align: center !important;\r\n                align-items: center !important\r\n            }\r\n\r\n            .align-items-lg-baseline {\r\n                -webkit-box-align: baseline !important;\r\n                -ms-flex-align: baseline !important;\r\n                align-items: baseline !important\r\n            }\r\n\r\n            .align-items-lg-stretch {\r\n                -webkit-box-align: stretch !important;\r\n                -ms-flex-align: stretch !important;\r\n                align-items: stretch !important\r\n            }\r\n\r\n            .align-content-lg-start {\r\n                -ms-flex-line-pack: start !important;\r\n                align-content: flex-start !important\r\n            }\r\n\r\n            .align-content-lg-end {\r\n                -ms-flex-line-pack: end !important;\r\n                align-content: flex-end !important\r\n            }\r\n\r\n            .align-content-lg-center {\r\n                -ms-flex-line-pack: center !important;\r\n                align-content: center !important\r\n            }\r\n\r\n            .align-content-lg-between {\r\n                -ms-flex-line-pack: justify !important;\r\n                align-content: space-between !important\r\n            }\r\n\r\n            .align-content-lg-around {\r\n                -ms-flex-line-pack: distribute !important;\r\n                align-content: space-around !important\r\n            }\r\n\r\n            .align-content-lg-stretch {\r\n                -ms-flex-line-pack: stretch !important;\r\n                align-content: stretch !important\r\n            }\r\n\r\n            .align-self-lg-auto {\r\n                -ms-flex-item-align: auto !important;\r\n                align-self: auto !important\r\n            }\r\n\r\n            .align-self-lg-start {\r\n                -ms-flex-item-align: start !important;\r\n                align-self: flex-start !important\r\n            }\r\n\r\n            .align-self-lg-end {\r\n                -ms-flex-item-align: end !important;\r\n                align-self: flex-end !important\r\n            }\r\n\r\n            .align-self-lg-center {\r\n                -ms-flex-item-align: center !important;\r\n                align-self: center !important\r\n            }\r\n\r\n            .align-self-lg-baseline {\r\n                -ms-flex-item-align: baseline !important;\r\n                align-self: baseline !important\r\n            }\r\n\r\n            .align-self-lg-stretch {\r\n                -ms-flex-item-align: stretch !important;\r\n                align-self: stretch !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .flex-xl-row {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: row !important;\r\n                flex-direction: row !important\r\n            }\r\n\r\n            .flex-xl-column {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: normal !important;\r\n                -ms-flex-direction: column !important;\r\n                flex-direction: column !important\r\n            }\r\n\r\n            .flex-xl-row-reverse {\r\n                -webkit-box-orient: horizontal !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: row-reverse !important;\r\n                flex-direction: row-reverse !important\r\n            }\r\n\r\n            .flex-xl-column-reverse {\r\n                -webkit-box-orient: vertical !important;\r\n                -webkit-box-direction: reverse !important;\r\n                -ms-flex-direction: column-reverse !important;\r\n                flex-direction: column-reverse !important\r\n            }\r\n\r\n            .flex-xl-wrap {\r\n                -ms-flex-wrap: wrap !important;\r\n                flex-wrap: wrap !important\r\n            }\r\n\r\n            .flex-xl-nowrap {\r\n                -ms-flex-wrap: nowrap !important;\r\n                flex-wrap: nowrap !important\r\n            }\r\n\r\n            .flex-xl-wrap-reverse {\r\n                -ms-flex-wrap: wrap-reverse !important;\r\n                flex-wrap: wrap-reverse !important\r\n            }\r\n\r\n            .justify-content-xl-start {\r\n                -webkit-box-pack: start !important;\r\n                -ms-flex-pack: start !important;\r\n                justify-content: flex-start !important\r\n            }\r\n\r\n            .justify-content-xl-end {\r\n                -webkit-box-pack: end !important;\r\n                -ms-flex-pack: end !important;\r\n                justify-content: flex-end !important\r\n            }\r\n\r\n            .justify-content-xl-center {\r\n                -webkit-box-pack: center !important;\r\n                -ms-flex-pack: center !important;\r\n                justify-content: center !important\r\n            }\r\n\r\n            .justify-content-xl-between {\r\n                -webkit-box-pack: justify !important;\r\n                -ms-flex-pack: justify !important;\r\n                justify-content: space-between !important\r\n            }\r\n\r\n            .justify-content-xl-around {\r\n                -ms-flex-pack: distribute !important;\r\n                justify-content: space-around !important\r\n            }\r\n\r\n            .align-items-xl-start {\r\n                -webkit-box-align: start !important;\r\n                -ms-flex-align: start !important;\r\n                align-items: flex-start !important\r\n            }\r\n\r\n            .align-items-xl-end {\r\n                -webkit-box-align: end !important;\r\n                -ms-flex-align: end !important;\r\n                align-items: flex-end !important\r\n            }\r\n\r\n            .align-items-xl-center {\r\n                -webkit-box-align: center !important;\r\n                -ms-flex-align: center !important;\r\n                align-items: center !important\r\n            }\r\n\r\n            .align-items-xl-baseline {\r\n                -webkit-box-align: baseline !important;\r\n                -ms-flex-align: baseline !important;\r\n                align-items: baseline !important\r\n            }\r\n\r\n            .align-items-xl-stretch {\r\n                -webkit-box-align: stretch !important;\r\n                -ms-flex-align: stretch !important;\r\n                align-items: stretch !important\r\n            }\r\n\r\n            .align-content-xl-start {\r\n                -ms-flex-line-pack: start !important;\r\n                align-content: flex-start !important\r\n            }\r\n\r\n            .align-content-xl-end {\r\n                -ms-flex-line-pack: end !important;\r\n                align-content: flex-end !important\r\n            }\r\n\r\n            .align-content-xl-center {\r\n                -ms-flex-line-pack: center !important;\r\n                align-content: center !important\r\n            }\r\n\r\n            .align-content-xl-between {\r\n                -ms-flex-line-pack: justify !important;\r\n                align-content: space-between !important\r\n            }\r\n\r\n            .align-content-xl-around {\r\n                -ms-flex-line-pack: distribute !important;\r\n                align-content: space-around !important\r\n            }\r\n\r\n            .align-content-xl-stretch {\r\n                -ms-flex-line-pack: stretch !important;\r\n                align-content: stretch !important\r\n            }\r\n\r\n            .align-self-xl-auto {\r\n                -ms-flex-item-align: auto !important;\r\n                align-self: auto !important\r\n            }\r\n\r\n            .align-self-xl-start {\r\n                -ms-flex-item-align: start !important;\r\n                align-self: flex-start !important\r\n            }\r\n\r\n            .align-self-xl-end {\r\n                -ms-flex-item-align: end !important;\r\n                align-self: flex-end !important\r\n            }\r\n\r\n            .align-self-xl-center {\r\n                -ms-flex-item-align: center !important;\r\n                align-self: center !important\r\n            }\r\n\r\n            .align-self-xl-baseline {\r\n                -ms-flex-item-align: baseline !important;\r\n                align-self: baseline !important\r\n            }\r\n\r\n            .align-self-xl-stretch {\r\n                -ms-flex-item-align: stretch !important;\r\n                align-self: stretch !important\r\n            }\r\n        }\r\n\r\n        .float-left {\r\n            float: left !important\r\n        }\r\n\r\n        .float-right {\r\n            float: right !important\r\n        }\r\n\r\n        .float-none {\r\n            float: none !important\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .float-sm-left {\r\n                float: left !important\r\n            }\r\n\r\n            .float-sm-right {\r\n                float: right !important\r\n            }\r\n\r\n            .float-sm-none {\r\n                float: none !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .float-md-left {\r\n                float: left !important\r\n            }\r\n\r\n            .float-md-right {\r\n                float: right !important\r\n            }\r\n\r\n            .float-md-none {\r\n                float: none !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .float-lg-left {\r\n                float: left !important\r\n            }\r\n\r\n            .float-lg-right {\r\n                float: right !important\r\n            }\r\n\r\n            .float-lg-none {\r\n                float: none !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .float-xl-left {\r\n                float: left !important\r\n            }\r\n\r\n            .float-xl-right {\r\n                float: right !important\r\n            }\r\n\r\n            .float-xl-none {\r\n                float: none !important\r\n            }\r\n        }\r\n\r\n        .position-static {\r\n            position: static !important\r\n        }\r\n\r\n        .position-relative {\r\n            position: relative !important\r\n        }\r\n\r\n        .position-absolute {\r\n            position: absolute !important\r\n        }\r\n\r\n        .position-fixed {\r\n            position: fixed !important\r\n        }\r\n\r\n        .position-sticky {\r\n            position: -webkit-sticky !important;\r\n            position: sticky !important\r\n        }\r\n\r\n        .fixed-top {\r\n            position: fixed;\r\n            top: 0;\r\n            right: 0;\r\n            left: 0;\r\n            z-index: 1030\r\n        }\r\n\r\n        .fixed-bottom {\r\n            position: fixed;\r\n            right: 0;\r\n            bottom: 0;\r\n            left: 0;\r\n            z-index: 1030\r\n        }\r\n\r\n        @supports ((position:-webkit-sticky) or (position:sticky)) {\r\n            .sticky-top {\r\n                position: -webkit-sticky;\r\n                position: sticky;\r\n                top: 0;\r\n                z-index: 1020\r\n            }\r\n        }\r\n\r\n        .sr-only {\r\n            position: absolute;\r\n            width: 1px;\r\n            height: 1px;\r\n            padding: 0;\r\n            overflow: hidden;\r\n            clip: rect(0,0,0,0);\r\n            white-space: nowrap;\r\n            -webkit-clip-path: inset(50%);\r\n            clip-path: inset(50%);\r\n            border: 0\r\n        }\r\n\r\n        .sr-only-focusable:active, .sr-only-focusable:focus {\r\n            position: static;\r\n            width: auto;\r\n            height: auto;\r\n            overflow: visible;\r\n            clip: auto;\r\n            white-space: normal;\r\n            -webkit-clip-path: none;\r\n            clip-path: none\r\n        }\r\n\r\n        .w-25 {\r\n            width: 25% !important\r\n        }\r\n\r\n        .w-50 {\r\n            width: 50% !important\r\n        }\r\n\r\n        .w-75 {\r\n            width: 75% !important\r\n        }\r\n\r\n        .w-100 {\r\n            width: 100% !important\r\n        }\r\n\r\n        .h-25 {\r\n            height: 25% !important\r\n        }\r\n\r\n        .h-50 {\r\n            height: 50% !important\r\n        }\r\n\r\n        .h-75 {\r\n            height: 75% !important\r\n        }\r\n\r\n        .h-100 {\r\n            height: 100% !important\r\n        }\r\n\r\n        .mw-100 {\r\n            max-width: 100% !important\r\n        }\r\n\r\n        .mh-100 {\r\n            max-height: 100% !important\r\n        }\r\n\r\n        .m-0 {\r\n            margin: 0 !important\r\n        }\r\n\r\n        .mt-0, .my-0 {\r\n            margin-top: 0 !important\r\n        }\r\n\r\n        .mr-0, .mx-0 {\r\n            margin-right: 0 !important\r\n        }\r\n\r\n        .mb-0, .my-0 {\r\n            margin-bottom: 0 !important\r\n        }\r\n\r\n        .ml-0, .mx-0 {\r\n            margin-left: 0 !important\r\n        }\r\n\r\n        .m-1 {\r\n            margin: .25rem !important\r\n        }\r\n\r\n        .mt-1, .my-1 {\r\n            margin-top: .25rem !important\r\n        }\r\n\r\n        .mr-1, .mx-1 {\r\n            margin-right: .25rem !important\r\n        }\r\n\r\n        .mb-1, .my-1 {\r\n            margin-bottom: .25rem !important\r\n        }\r\n\r\n        .ml-1, .mx-1 {\r\n            margin-left: .25rem !important\r\n        }\r\n\r\n        .m-2 {\r\n            margin: .5rem !important\r\n        }\r\n\r\n        .mt-2, .my-2 {\r\n            margin-top: .5rem !important\r\n        }\r\n\r\n        .mr-2, .mx-2 {\r\n            margin-right: .5rem !important\r\n        }\r\n\r\n        .mb-2, .my-2 {\r\n            margin-bottom: .5rem !important\r\n        }\r\n\r\n        .ml-2, .mx-2 {\r\n            margin-left: .5rem !important\r\n        }\r\n\r\n        .m-3 {\r\n            margin: 1rem !important\r\n        }\r\n\r\n        .mt-3, .my-3 {\r\n            margin-top: 1rem !important\r\n        }\r\n\r\n        .mr-3, .mx-3 {\r\n            margin-right: 1rem !important\r\n        }\r\n\r\n        .mb-3, .my-3 {\r\n            margin-bottom: 1rem !important\r\n        }\r\n\r\n        .ml-3, .mx-3 {\r\n            margin-left: 1rem !important\r\n        }\r\n\r\n        .m-4 {\r\n            margin: 1.5rem !important\r\n        }\r\n\r\n        .mt-4, .my-4 {\r\n            margin-top: 1.5rem !important\r\n        }\r\n\r\n        .mr-4, .mx-4 {\r\n            margin-right: 1.5rem !important\r\n        }\r\n\r\n        .mb-4, .my-4 {\r\n            margin-bottom: 1.5rem !important\r\n        }\r\n\r\n        .ml-4, .mx-4 {\r\n            margin-left: 1.5rem !important\r\n        }\r\n\r\n        .m-5 {\r\n            margin: 3rem !important\r\n        }\r\n\r\n        .mt-5, .my-5 {\r\n            margin-top: 3rem !important\r\n        }\r\n\r\n        .mr-5, .mx-5 {\r\n            margin-right: 3rem !important\r\n        }\r\n\r\n        .mb-5, .my-5 {\r\n            margin-bottom: 3rem !important\r\n        }\r\n\r\n        .ml-5, .mx-5 {\r\n            margin-left: 3rem !important\r\n        }\r\n\r\n        .p-0 {\r\n            padding: 0 !important\r\n        }\r\n\r\n        .pt-0, .py-0 {\r\n            padding-top: 0 !important\r\n        }\r\n\r\n        .pr-0, .px-0 {\r\n            padding-right: 0 !important\r\n        }\r\n\r\n        .pb-0, .py-0 {\r\n            padding-bottom: 0 !important\r\n        }\r\n\r\n        .pl-0, .px-0 {\r\n            padding-left: 0 !important\r\n        }\r\n\r\n        .p-1 {\r\n            padding: .25rem !important\r\n        }\r\n\r\n        .pt-1, .py-1 {\r\n            padding-top: .25rem !important\r\n        }\r\n\r\n        .pr-1, .px-1 {\r\n            padding-right: .25rem !important\r\n        }\r\n\r\n        .pb-1, .py-1 {\r\n            padding-bottom: .25rem !important\r\n        }\r\n\r\n        .pl-1, .px-1 {\r\n            padding-left: .25rem !important\r\n        }\r\n\r\n        .p-2 {\r\n            padding: .5rem !important\r\n        }\r\n\r\n        .pt-2, .py-2 {\r\n            padding-top: .5rem !important\r\n        }\r\n\r\n        .pr-2, .px-2 {\r\n            padding-right: .5rem !important\r\n        }\r\n\r\n        .pb-2, .py-2 {\r\n            padding-bottom: .5rem !important\r\n        }\r\n\r\n        .pl-2, .px-2 {\r\n            padding-left: .5rem !important\r\n        }\r\n\r\n        .p-3 {\r\n            padding: 1rem !important\r\n        }\r\n\r\n        .pt-3, .py-3 {\r\n            padding-top: 1rem !important\r\n        }\r\n\r\n        .pr-3, .px-3 {\r\n            padding-right: 1rem !important\r\n        }\r\n\r\n        .pb-3, .py-3 {\r\n            padding-bottom: 1rem !important\r\n        }\r\n\r\n        .pl-3, .px-3 {\r\n            padding-left: 1rem !important\r\n        }\r\n\r\n        .p-4 {\r\n            padding: 1.5rem !important\r\n        }\r\n\r\n        .pt-4, .py-4 {\r\n            padding-top: 1.5rem !important\r\n        }\r\n\r\n        .pr-4, .px-4 {\r\n            padding-right: 1.5rem !important\r\n        }\r\n\r\n        .pb-4, .py-4 {\r\n            padding-bottom: 1.5rem !important\r\n        }\r\n\r\n        .pl-4, .px-4 {\r\n            padding-left: 1.5rem !important\r\n        }\r\n\r\n        .p-5 {\r\n            padding: 3rem !important\r\n        }\r\n\r\n        .pt-5, .py-5 {\r\n            padding-top: 3rem !important\r\n        }\r\n\r\n        .pr-5, .px-5 {\r\n            padding-right: 3rem !important\r\n        }\r\n\r\n        .pb-5, .py-5 {\r\n            padding-bottom: 3rem !important\r\n        }\r\n\r\n        .pl-5, .px-5 {\r\n            padding-left: 3rem !important\r\n        }\r\n\r\n        .m-auto {\r\n            margin: auto !important\r\n        }\r\n\r\n        .mt-auto, .my-auto {\r\n            margin-top: auto !important\r\n        }\r\n\r\n        .mr-auto, .mx-auto {\r\n            margin-right: auto !important\r\n        }\r\n\r\n        .mb-auto, .my-auto {\r\n            margin-bottom: auto !important\r\n        }\r\n\r\n        .ml-auto, .mx-auto {\r\n            margin-left: auto !important\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .m-sm-0 {\r\n                margin: 0 !important\r\n            }\r\n\r\n            .mt-sm-0, .my-sm-0 {\r\n                margin-top: 0 !important\r\n            }\r\n\r\n            .mr-sm-0, .mx-sm-0 {\r\n                margin-right: 0 !important\r\n            }\r\n\r\n            .mb-sm-0, .my-sm-0 {\r\n                margin-bottom: 0 !important\r\n            }\r\n\r\n            .ml-sm-0, .mx-sm-0 {\r\n                margin-left: 0 !important\r\n            }\r\n\r\n            .m-sm-1 {\r\n                margin: .25rem !important\r\n            }\r\n\r\n            .mt-sm-1, .my-sm-1 {\r\n                margin-top: .25rem !important\r\n            }\r\n\r\n            .mr-sm-1, .mx-sm-1 {\r\n                margin-right: .25rem !important\r\n            }\r\n\r\n            .mb-sm-1, .my-sm-1 {\r\n                margin-bottom: .25rem !important\r\n            }\r\n\r\n            .ml-sm-1, .mx-sm-1 {\r\n                margin-left: .25rem !important\r\n            }\r\n\r\n            .m-sm-2 {\r\n                margin: .5rem !important\r\n            }\r\n\r\n            .mt-sm-2, .my-sm-2 {\r\n                margin-top: .5rem !important\r\n            }\r\n\r\n            .mr-sm-2, .mx-sm-2 {\r\n                margin-right: .5rem !important\r\n            }\r\n\r\n            .mb-sm-2, .my-sm-2 {\r\n                margin-bottom: .5rem !important\r\n            }\r\n\r\n            .ml-sm-2, .mx-sm-2 {\r\n                margin-left: .5rem !important\r\n            }\r\n\r\n            .m-sm-3 {\r\n                margin: 1rem !important\r\n            }\r\n\r\n            .mt-sm-3, .my-sm-3 {\r\n                margin-top: 1rem !important\r\n            }\r\n\r\n            .mr-sm-3, .mx-sm-3 {\r\n                margin-right: 1rem !important\r\n            }\r\n\r\n            .mb-sm-3, .my-sm-3 {\r\n                margin-bottom: 1rem !important\r\n            }\r\n\r\n            .ml-sm-3, .mx-sm-3 {\r\n                margin-left: 1rem !important\r\n            }\r\n\r\n            .m-sm-4 {\r\n                margin: 1.5rem !important\r\n            }\r\n\r\n            .mt-sm-4, .my-sm-4 {\r\n                margin-top: 1.5rem !important\r\n            }\r\n\r\n            .mr-sm-4, .mx-sm-4 {\r\n                margin-right: 1.5rem !important\r\n            }\r\n\r\n            .mb-sm-4, .my-sm-4 {\r\n                margin-bottom: 1.5rem !important\r\n            }\r\n\r\n            .ml-sm-4, .mx-sm-4 {\r\n                margin-left: 1.5rem !important\r\n            }\r\n\r\n            .m-sm-5 {\r\n                margin: 3rem !important\r\n            }\r\n\r\n            .mt-sm-5, .my-sm-5 {\r\n                margin-top: 3rem !important\r\n            }\r\n\r\n            .mr-sm-5, .mx-sm-5 {\r\n                margin-right: 3rem !important\r\n            }\r\n\r\n            .mb-sm-5, .my-sm-5 {\r\n                margin-bottom: 3rem !important\r\n            }\r\n\r\n            .ml-sm-5, .mx-sm-5 {\r\n                margin-left: 3rem !important\r\n            }\r\n\r\n            .p-sm-0 {\r\n                padding: 0 !important\r\n            }\r\n\r\n            .pt-sm-0, .py-sm-0 {\r\n                padding-top: 0 !important\r\n            }\r\n\r\n            .pr-sm-0, .px-sm-0 {\r\n                padding-right: 0 !important\r\n            }\r\n\r\n            .pb-sm-0, .py-sm-0 {\r\n                padding-bottom: 0 !important\r\n            }\r\n\r\n            .pl-sm-0, .px-sm-0 {\r\n                padding-left: 0 !important\r\n            }\r\n\r\n            .p-sm-1 {\r\n                padding: .25rem !important\r\n            }\r\n\r\n            .pt-sm-1, .py-sm-1 {\r\n                padding-top: .25rem !important\r\n            }\r\n\r\n            .pr-sm-1, .px-sm-1 {\r\n                padding-right: .25rem !important\r\n            }\r\n\r\n            .pb-sm-1, .py-sm-1 {\r\n                padding-bottom: .25rem !important\r\n            }\r\n\r\n            .pl-sm-1, .px-sm-1 {\r\n                padding-left: .25rem !important\r\n            }\r\n\r\n            .p-sm-2 {\r\n                padding: .5rem !important\r\n            }\r\n\r\n            .pt-sm-2, .py-sm-2 {\r\n                padding-top: .5rem !important\r\n            }\r\n\r\n            .pr-sm-2, .px-sm-2 {\r\n                padding-right: .5rem !important\r\n            }\r\n\r\n            .pb-sm-2, .py-sm-2 {\r\n                padding-bottom: .5rem !important\r\n            }\r\n\r\n            .pl-sm-2, .px-sm-2 {\r\n                padding-left: .5rem !important\r\n            }\r\n\r\n            .p-sm-3 {\r\n                padding: 1rem !important\r\n            }\r\n\r\n            .pt-sm-3, .py-sm-3 {\r\n                padding-top: 1rem !important\r\n            }\r\n\r\n            .pr-sm-3, .px-sm-3 {\r\n                padding-right: 1rem !important\r\n            }\r\n\r\n            .pb-sm-3, .py-sm-3 {\r\n                padding-bottom: 1rem !important\r\n            }\r\n\r\n            .pl-sm-3, .px-sm-3 {\r\n                padding-left: 1rem !important\r\n            }\r\n\r\n            .p-sm-4 {\r\n                padding: 1.5rem !important\r\n            }\r\n\r\n            .pt-sm-4, .py-sm-4 {\r\n                padding-top: 1.5rem !important\r\n            }\r\n\r\n            .pr-sm-4, .px-sm-4 {\r\n                padding-right: 1.5rem !important\r\n            }\r\n\r\n            .pb-sm-4, .py-sm-4 {\r\n                padding-bottom: 1.5rem !important\r\n            }\r\n\r\n            .pl-sm-4, .px-sm-4 {\r\n                padding-left: 1.5rem !important\r\n            }\r\n\r\n            .p-sm-5 {\r\n                padding: 3rem !important\r\n            }\r\n\r\n            .pt-sm-5, .py-sm-5 {\r\n                padding-top: 3rem !important\r\n            }\r\n\r\n            .pr-sm-5, .px-sm-5 {\r\n                padding-right: 3rem !important\r\n            }\r\n\r\n            .pb-sm-5, .py-sm-5 {\r\n                padding-bottom: 3rem !important\r\n            }\r\n\r\n            .pl-sm-5, .px-sm-5 {\r\n                padding-left: 3rem !important\r\n            }\r\n\r\n            .m-sm-auto {\r\n                margin: auto !important\r\n            }\r\n\r\n            .mt-sm-auto, .my-sm-auto {\r\n                margin-top: auto !important\r\n            }\r\n\r\n            .mr-sm-auto, .mx-sm-auto {\r\n                margin-right: auto !important\r\n            }\r\n\r\n            .mb-sm-auto, .my-sm-auto {\r\n                margin-bottom: auto !important\r\n            }\r\n\r\n            .ml-sm-auto, .mx-sm-auto {\r\n                margin-left: auto !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .m-md-0 {\r\n                margin: 0 !important\r\n            }\r\n\r\n            .mt-md-0, .my-md-0 {\r\n                margin-top: 0 !important\r\n            }\r\n\r\n            .mr-md-0, .mx-md-0 {\r\n                margin-right: 0 !important\r\n            }\r\n\r\n            .mb-md-0, .my-md-0 {\r\n                margin-bottom: 0 !important\r\n            }\r\n\r\n            .ml-md-0, .mx-md-0 {\r\n                margin-left: 0 !important\r\n            }\r\n\r\n            .m-md-1 {\r\n                margin: .25rem !important\r\n            }\r\n\r\n            .mt-md-1, .my-md-1 {\r\n                margin-top: .25rem !important\r\n            }\r\n\r\n            .mr-md-1, .mx-md-1 {\r\n                margin-right: .25rem !important\r\n            }\r\n\r\n            .mb-md-1, .my-md-1 {\r\n                margin-bottom: .25rem !important\r\n            }\r\n\r\n            .ml-md-1, .mx-md-1 {\r\n                margin-left: .25rem !important\r\n            }\r\n\r\n            .m-md-2 {\r\n                margin: .5rem !important\r\n            }\r\n\r\n            .mt-md-2, .my-md-2 {\r\n                margin-top: .5rem !important\r\n            }\r\n\r\n            .mr-md-2, .mx-md-2 {\r\n                margin-right: .5rem !important\r\n            }\r\n\r\n            .mb-md-2, .my-md-2 {\r\n                margin-bottom: .5rem !important\r\n            }\r\n\r\n            .ml-md-2, .mx-md-2 {\r\n                margin-left: .5rem !important\r\n            }\r\n\r\n            .m-md-3 {\r\n                margin: 1rem !important\r\n            }\r\n\r\n            .mt-md-3, .my-md-3 {\r\n                margin-top: 1rem !important\r\n            }\r\n\r\n            .mr-md-3, .mx-md-3 {\r\n                margin-right: 1rem !important\r\n            }\r\n\r\n            .mb-md-3, .my-md-3 {\r\n                margin-bottom: 1rem !important\r\n            }\r\n\r\n            .ml-md-3, .mx-md-3 {\r\n                margin-left: 1rem !important\r\n            }\r\n\r\n            .m-md-4 {\r\n                margin: 1.5rem !important\r\n            }\r\n\r\n            .mt-md-4, .my-md-4 {\r\n                margin-top: 1.5rem !important\r\n            }\r\n\r\n            .mr-md-4, .mx-md-4 {\r\n                margin-right: 1.5rem !important\r\n            }\r\n\r\n            .mb-md-4, .my-md-4 {\r\n                margin-bottom: 1.5rem !important\r\n            }\r\n\r\n            .ml-md-4, .mx-md-4 {\r\n                margin-left: 1.5rem !important\r\n            }\r\n\r\n            .m-md-5 {\r\n                margin: 3rem !important\r\n            }\r\n\r\n            .mt-md-5, .my-md-5 {\r\n                margin-top: 3rem !important\r\n            }\r\n\r\n            .mr-md-5, .mx-md-5 {\r\n                margin-right: 3rem !important\r\n            }\r\n\r\n            .mb-md-5, .my-md-5 {\r\n                margin-bottom: 3rem !important\r\n            }\r\n\r\n            .ml-md-5, .mx-md-5 {\r\n                margin-left: 3rem !important\r\n            }\r\n\r\n            .p-md-0 {\r\n                padding: 0 !important\r\n            }\r\n\r\n            .pt-md-0, .py-md-0 {\r\n                padding-top: 0 !important\r\n            }\r\n\r\n            .pr-md-0, .px-md-0 {\r\n                padding-right: 0 !important\r\n            }\r\n\r\n            .pb-md-0, .py-md-0 {\r\n                padding-bottom: 0 !important\r\n            }\r\n\r\n            .pl-md-0, .px-md-0 {\r\n                padding-left: 0 !important\r\n            }\r\n\r\n            .p-md-1 {\r\n                padding: .25rem !important\r\n            }\r\n\r\n            .pt-md-1, .py-md-1 {\r\n                padding-top: .25rem !important\r\n            }\r\n\r\n            .pr-md-1, .px-md-1 {\r\n                padding-right: .25rem !important\r\n            }\r\n\r\n            .pb-md-1, .py-md-1 {\r\n                padding-bottom: .25rem !important\r\n            }\r\n\r\n            .pl-md-1, .px-md-1 {\r\n                padding-left: .25rem !important\r\n            }\r\n\r\n            .p-md-2 {\r\n                padding: .5rem !important\r\n            }\r\n\r\n            .pt-md-2, .py-md-2 {\r\n                padding-top: .5rem !important\r\n            }\r\n\r\n            .pr-md-2, .px-md-2 {\r\n                padding-right: .5rem !important\r\n            }\r\n\r\n            .pb-md-2, .py-md-2 {\r\n                padding-bottom: .5rem !important\r\n            }\r\n\r\n            .pl-md-2, .px-md-2 {\r\n                padding-left: .5rem !important\r\n            }\r\n\r\n            .p-md-3 {\r\n                padding: 1rem !important\r\n            }\r\n\r\n            .pt-md-3, .py-md-3 {\r\n                padding-top: 1rem !important\r\n            }\r\n\r\n            .pr-md-3, .px-md-3 {\r\n                padding-right: 1rem !important\r\n            }\r\n\r\n            .pb-md-3, .py-md-3 {\r\n                padding-bottom: 1rem !important\r\n            }\r\n\r\n            .pl-md-3, .px-md-3 {\r\n                padding-left: 1rem !important\r\n            }\r\n\r\n            .p-md-4 {\r\n                padding: 1.5rem !important\r\n            }\r\n\r\n            .pt-md-4, .py-md-4 {\r\n                padding-top: 1.5rem !important\r\n            }\r\n\r\n            .pr-md-4, .px-md-4 {\r\n                padding-right: 1.5rem !important\r\n            }\r\n\r\n            .pb-md-4, .py-md-4 {\r\n                padding-bottom: 1.5rem !important\r\n            }\r\n\r\n            .pl-md-4, .px-md-4 {\r\n                padding-left: 1.5rem !important\r\n            }\r\n\r\n            .p-md-5 {\r\n                padding: 3rem !important\r\n            }\r\n\r\n            .pt-md-5, .py-md-5 {\r\n                padding-top: 3rem !important\r\n            }\r\n\r\n            .pr-md-5, .px-md-5 {\r\n                padding-right: 3rem !important\r\n            }\r\n\r\n            .pb-md-5, .py-md-5 {\r\n                padding-bottom: 3rem !important\r\n            }\r\n\r\n            .pl-md-5, .px-md-5 {\r\n                padding-left: 3rem !important\r\n            }\r\n\r\n            .m-md-auto {\r\n                margin: auto !important\r\n            }\r\n\r\n            .mt-md-auto, .my-md-auto {\r\n                margin-top: auto !important\r\n            }\r\n\r\n            .mr-md-auto, .mx-md-auto {\r\n                margin-right: auto !important\r\n            }\r\n\r\n            .mb-md-auto, .my-md-auto {\r\n                margin-bottom: auto !important\r\n            }\r\n\r\n            .ml-md-auto, .mx-md-auto {\r\n                margin-left: auto !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .m-lg-0 {\r\n                margin: 0 !important\r\n            }\r\n\r\n            .mt-lg-0, .my-lg-0 {\r\n                margin-top: 0 !important\r\n            }\r\n\r\n            .mr-lg-0, .mx-lg-0 {\r\n                margin-right: 0 !important\r\n            }\r\n\r\n            .mb-lg-0, .my-lg-0 {\r\n                margin-bottom: 0 !important\r\n            }\r\n\r\n            .ml-lg-0, .mx-lg-0 {\r\n                margin-left: 0 !important\r\n            }\r\n\r\n            .m-lg-1 {\r\n                margin: .25rem !important\r\n            }\r\n\r\n            .mt-lg-1, .my-lg-1 {\r\n                margin-top: .25rem !important\r\n            }\r\n\r\n            .mr-lg-1, .mx-lg-1 {\r\n                margin-right: .25rem !important\r\n            }\r\n\r\n            .mb-lg-1, .my-lg-1 {\r\n                margin-bottom: .25rem !important\r\n            }\r\n\r\n            .ml-lg-1, .mx-lg-1 {\r\n                margin-left: .25rem !important\r\n            }\r\n\r\n            .m-lg-2 {\r\n                margin: .5rem !important\r\n            }\r\n\r\n            .mt-lg-2, .my-lg-2 {\r\n                margin-top: .5rem !important\r\n            }\r\n\r\n            .mr-lg-2, .mx-lg-2 {\r\n                margin-right: .5rem !important\r\n            }\r\n\r\n            .mb-lg-2, .my-lg-2 {\r\n                margin-bottom: .5rem !important\r\n            }\r\n\r\n            .ml-lg-2, .mx-lg-2 {\r\n                margin-left: .5rem !important\r\n            }\r\n\r\n            .m-lg-3 {\r\n                margin: 1rem !important\r\n            }\r\n\r\n            .mt-lg-3, .my-lg-3 {\r\n                margin-top: 1rem !important\r\n            }\r\n\r\n            .mr-lg-3, .mx-lg-3 {\r\n                margin-right: 1rem !important\r\n            }\r\n\r\n            .mb-lg-3, .my-lg-3 {\r\n                margin-bottom: 1rem !important\r\n            }\r\n\r\n            .ml-lg-3, .mx-lg-3 {\r\n                margin-left: 1rem !important\r\n            }\r\n\r\n            .m-lg-4 {\r\n                margin: 1.5rem !important\r\n            }\r\n\r\n            .mt-lg-4, .my-lg-4 {\r\n                margin-top: 1.5rem !important\r\n            }\r\n\r\n            .mr-lg-4, .mx-lg-4 {\r\n                margin-right: 1.5rem !important\r\n            }\r\n\r\n            .mb-lg-4, .my-lg-4 {\r\n                margin-bottom: 1.5rem !important\r\n            }\r\n\r\n            .ml-lg-4, .mx-lg-4 {\r\n                margin-left: 1.5rem !important\r\n            }\r\n\r\n            .m-lg-5 {\r\n                margin: 3rem !important\r\n            }\r\n\r\n            .mt-lg-5, .my-lg-5 {\r\n                margin-top: 3rem !important\r\n            }\r\n\r\n            .mr-lg-5, .mx-lg-5 {\r\n                margin-right: 3rem !important\r\n            }\r\n\r\n            .mb-lg-5, .my-lg-5 {\r\n                margin-bottom: 3rem !important\r\n            }\r\n\r\n            .ml-lg-5, .mx-lg-5 {\r\n                margin-left: 3rem !important\r\n            }\r\n\r\n            .p-lg-0 {\r\n                padding: 0 !important\r\n            }\r\n\r\n            .pt-lg-0, .py-lg-0 {\r\n                padding-top: 0 !important\r\n            }\r\n\r\n            .pr-lg-0, .px-lg-0 {\r\n                padding-right: 0 !important\r\n            }\r\n\r\n            .pb-lg-0, .py-lg-0 {\r\n                padding-bottom: 0 !important\r\n            }\r\n\r\n            .pl-lg-0, .px-lg-0 {\r\n                padding-left: 0 !important\r\n            }\r\n\r\n            .p-lg-1 {\r\n                padding: .25rem !important\r\n            }\r\n\r\n            .pt-lg-1, .py-lg-1 {\r\n                padding-top: .25rem !important\r\n            }\r\n\r\n            .pr-lg-1, .px-lg-1 {\r\n                padding-right: .25rem !important\r\n            }\r\n\r\n            .pb-lg-1, .py-lg-1 {\r\n                padding-bottom: .25rem !important\r\n            }\r\n\r\n            .pl-lg-1, .px-lg-1 {\r\n                padding-left: .25rem !important\r\n            }\r\n\r\n            .p-lg-2 {\r\n                padding: .5rem !important\r\n            }\r\n\r\n            .pt-lg-2, .py-lg-2 {\r\n                padding-top: .5rem !important\r\n            }\r\n\r\n            .pr-lg-2, .px-lg-2 {\r\n                padding-right: .5rem !important\r\n            }\r\n\r\n            .pb-lg-2, .py-lg-2 {\r\n                padding-bottom: .5rem !important\r\n            }\r\n\r\n            .pl-lg-2, .px-lg-2 {\r\n                padding-left: .5rem !important\r\n            }\r\n\r\n            .p-lg-3 {\r\n                padding: 1rem !important\r\n            }\r\n\r\n            .pt-lg-3, .py-lg-3 {\r\n                padding-top: 1rem !important\r\n            }\r\n\r\n            .pr-lg-3, .px-lg-3 {\r\n                padding-right: 1rem !important\r\n            }\r\n\r\n            .pb-lg-3, .py-lg-3 {\r\n                padding-bottom: 1rem !important\r\n            }\r\n\r\n            .pl-lg-3, .px-lg-3 {\r\n                padding-left: 1rem !important\r\n            }\r\n\r\n            .p-lg-4 {\r\n                padding: 1.5rem !important\r\n            }\r\n\r\n            .pt-lg-4, .py-lg-4 {\r\n                padding-top: 1.5rem !important\r\n            }\r\n\r\n            .pr-lg-4, .px-lg-4 {\r\n                padding-right: 1.5rem !important\r\n            }\r\n\r\n            .pb-lg-4, .py-lg-4 {\r\n                padding-bottom: 1.5rem !important\r\n            }\r\n\r\n            .pl-lg-4, .px-lg-4 {\r\n                padding-left: 1.5rem !important\r\n            }\r\n\r\n            .p-lg-5 {\r\n                padding: 3rem !important\r\n            }\r\n\r\n            .pt-lg-5, .py-lg-5 {\r\n                padding-top: 3rem !important\r\n            }\r\n\r\n            .pr-lg-5, .px-lg-5 {\r\n                padding-right: 3rem !important\r\n            }\r\n\r\n            .pb-lg-5, .py-lg-5 {\r\n                padding-bottom: 3rem !important\r\n            }\r\n\r\n            .pl-lg-5, .px-lg-5 {\r\n                padding-left: 3rem !important\r\n            }\r\n\r\n            .m-lg-auto {\r\n                margin: auto !important\r\n            }\r\n\r\n            .mt-lg-auto, .my-lg-auto {\r\n                margin-top: auto !important\r\n            }\r\n\r\n            .mr-lg-auto, .mx-lg-auto {\r\n                margin-right: auto !important\r\n            }\r\n\r\n            .mb-lg-auto, .my-lg-auto {\r\n                margin-bottom: auto !important\r\n            }\r\n\r\n            .ml-lg-auto, .mx-lg-auto {\r\n                margin-left: auto !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .m-xl-0 {\r\n                margin: 0 !important\r\n            }\r\n\r\n            .mt-xl-0, .my-xl-0 {\r\n                margin-top: 0 !important\r\n            }\r\n\r\n            .mr-xl-0, .mx-xl-0 {\r\n                margin-right: 0 !important\r\n            }\r\n\r\n            .mb-xl-0, .my-xl-0 {\r\n                margin-bottom: 0 !important\r\n            }\r\n\r\n            .ml-xl-0, .mx-xl-0 {\r\n                margin-left: 0 !important\r\n            }\r\n\r\n            .m-xl-1 {\r\n                margin: .25rem !important\r\n            }\r\n\r\n            .mt-xl-1, .my-xl-1 {\r\n                margin-top: .25rem !important\r\n            }\r\n\r\n            .mr-xl-1, .mx-xl-1 {\r\n                margin-right: .25rem !important\r\n            }\r\n\r\n            .mb-xl-1, .my-xl-1 {\r\n                margin-bottom: .25rem !important\r\n            }\r\n\r\n            .ml-xl-1, .mx-xl-1 {\r\n                margin-left: .25rem !important\r\n            }\r\n\r\n            .m-xl-2 {\r\n                margin: .5rem !important\r\n            }\r\n\r\n            .mt-xl-2, .my-xl-2 {\r\n                margin-top: .5rem !important\r\n            }\r\n\r\n            .mr-xl-2, .mx-xl-2 {\r\n                margin-right: .5rem !important\r\n            }\r\n\r\n            .mb-xl-2, .my-xl-2 {\r\n                margin-bottom: .5rem !important\r\n            }\r\n\r\n            .ml-xl-2, .mx-xl-2 {\r\n                margin-left: .5rem !important\r\n            }\r\n\r\n            .m-xl-3 {\r\n                margin: 1rem !important\r\n            }\r\n\r\n            .mt-xl-3, .my-xl-3 {\r\n                margin-top: 1rem !important\r\n            }\r\n\r\n            .mr-xl-3, .mx-xl-3 {\r\n                margin-right: 1rem !important\r\n            }\r\n\r\n            .mb-xl-3, .my-xl-3 {\r\n                margin-bottom: 1rem !important\r\n            }\r\n\r\n            .ml-xl-3, .mx-xl-3 {\r\n                margin-left: 1rem !important\r\n            }\r\n\r\n            .m-xl-4 {\r\n                margin: 1.5rem !important\r\n            }\r\n\r\n            .mt-xl-4, .my-xl-4 {\r\n                margin-top: 1.5rem !important\r\n            }\r\n\r\n            .mr-xl-4, .mx-xl-4 {\r\n                margin-right: 1.5rem !important\r\n            }\r\n\r\n            .mb-xl-4, .my-xl-4 {\r\n                margin-bottom: 1.5rem !important\r\n            }\r\n\r\n            .ml-xl-4, .mx-xl-4 {\r\n                margin-left: 1.5rem !important\r\n            }\r\n\r\n            .m-xl-5 {\r\n                margin: 3rem !important\r\n            }\r\n\r\n            .mt-xl-5, .my-xl-5 {\r\n                margin-top: 3rem !important\r\n            }\r\n\r\n            .mr-xl-5, .mx-xl-5 {\r\n                margin-right: 3rem !important\r\n            }\r\n\r\n            .mb-xl-5, .my-xl-5 {\r\n                margin-bottom: 3rem !important\r\n            }\r\n\r\n            .ml-xl-5, .mx-xl-5 {\r\n                margin-left: 3rem !important\r\n            }\r\n\r\n            .p-xl-0 {\r\n                padding: 0 !important\r\n            }\r\n\r\n            .pt-xl-0, .py-xl-0 {\r\n                padding-top: 0 !important\r\n            }\r\n\r\n            .pr-xl-0, .px-xl-0 {\r\n                padding-right: 0 !important\r\n            }\r\n\r\n            .pb-xl-0, .py-xl-0 {\r\n                padding-bottom: 0 !important\r\n            }\r\n\r\n            .pl-xl-0, .px-xl-0 {\r\n                padding-left: 0 !important\r\n            }\r\n\r\n            .p-xl-1 {\r\n                padding: .25rem !important\r\n            }\r\n\r\n            .pt-xl-1, .py-xl-1 {\r\n                padding-top: .25rem !important\r\n            }\r\n\r\n            .pr-xl-1, .px-xl-1 {\r\n                padding-right: .25rem !important\r\n            }\r\n\r\n            .pb-xl-1, .py-xl-1 {\r\n                padding-bottom: .25rem !important\r\n            }\r\n\r\n            .pl-xl-1, .px-xl-1 {\r\n                padding-left: .25rem !important\r\n            }\r\n\r\n            .p-xl-2 {\r\n                padding: .5rem !important\r\n            }\r\n\r\n            .pt-xl-2, .py-xl-2 {\r\n                padding-top: .5rem !important\r\n            }\r\n\r\n            .pr-xl-2, .px-xl-2 {\r\n                padding-right: .5rem !important\r\n            }\r\n\r\n            .pb-xl-2, .py-xl-2 {\r\n                padding-bottom: .5rem !important\r\n            }\r\n\r\n            .pl-xl-2, .px-xl-2 {\r\n                padding-left: .5rem !important\r\n            }\r\n\r\n            .p-xl-3 {\r\n                padding: 1rem !important\r\n            }\r\n\r\n            .pt-xl-3, .py-xl-3 {\r\n                padding-top: 1rem !important\r\n            }\r\n\r\n            .pr-xl-3, .px-xl-3 {\r\n                padding-right: 1rem !important\r\n            }\r\n\r\n            .pb-xl-3, .py-xl-3 {\r\n                padding-bottom: 1rem !important\r\n            }\r\n\r\n            .pl-xl-3, .px-xl-3 {\r\n                padding-left: 1rem !important\r\n            }\r\n\r\n            .p-xl-4 {\r\n                padding: 1.5rem !important\r\n            }\r\n\r\n            .pt-xl-4, .py-xl-4 {\r\n                padding-top: 1.5rem !important\r\n            }\r\n\r\n            .pr-xl-4, .px-xl-4 {\r\n                padding-right: 1.5rem !important\r\n            }\r\n\r\n            .pb-xl-4, .py-xl-4 {\r\n                padding-bottom: 1.5rem !important\r\n            }\r\n\r\n            .pl-xl-4, .px-xl-4 {\r\n                padding-left: 1.5rem !important\r\n            }\r\n\r\n            .p-xl-5 {\r\n                padding: 3rem !important\r\n            }\r\n\r\n            .pt-xl-5, .py-xl-5 {\r\n                padding-top: 3rem !important\r\n            }\r\n\r\n            .pr-xl-5, .px-xl-5 {\r\n                padding-right: 3rem !important\r\n            }\r\n\r\n            .pb-xl-5, .py-xl-5 {\r\n                padding-bottom: 3rem !important\r\n            }\r\n\r\n            .pl-xl-5, .px-xl-5 {\r\n                padding-left: 3rem !important\r\n            }\r\n\r\n            .m-xl-auto {\r\n                margin: auto !important\r\n            }\r\n\r\n            .mt-xl-auto, .my-xl-auto {\r\n                margin-top: auto !important\r\n            }\r\n\r\n            .mr-xl-auto, .mx-xl-auto {\r\n                margin-right: auto !important\r\n            }\r\n\r\n            .mb-xl-auto, .my-xl-auto {\r\n                margin-bottom: auto !important\r\n            }\r\n\r\n            .ml-xl-auto, .mx-xl-auto {\r\n                margin-left: auto !important\r\n            }\r\n        }\r\n\r\n        .text-justify {\r\n            text-align: justify !important\r\n        }\r\n\r\n        .text-nowrap {\r\n            white-space: nowrap !important\r\n        }\r\n\r\n        .text-truncate {\r\n            overflow: hidden;\r\n            text-overflow: ellipsis;\r\n            white-space: nowrap\r\n        }\r\n\r\n        .text-left {\r\n            text-align: left !important\r\n        }\r\n\r\n        .text-right {\r\n            text-align: right !important\r\n        }\r\n\r\n        .text-center {\r\n            text-align: center !important\r\n        }\r\n\r\n        @media (min-width:576px) {\r\n            .text-sm-left {\r\n                text-align: left !important\r\n            }\r\n\r\n            .text-sm-right {\r\n                text-align: right !important\r\n            }\r\n\r\n            .text-sm-center {\r\n                text-align: center !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:768px) {\r\n            .text-md-left {\r\n                text-align: left !important\r\n            }\r\n\r\n            .text-md-right {\r\n                text-align: right !important\r\n            }\r\n\r\n            .text-md-center {\r\n                text-align: center !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:992px) {\r\n            .text-lg-left {\r\n                text-align: left !important\r\n            }\r\n\r\n            .text-lg-right {\r\n                text-align: right !important\r\n            }\r\n\r\n            .text-lg-center {\r\n                text-align: center !important\r\n            }\r\n        }\r\n\r\n        @media (min-width:1200px) {\r\n            .text-xl-left {\r\n                text-align: left !important\r\n            }\r\n\r\n            .text-xl-right {\r\n                text-align: right !important\r\n            }\r\n\r\n            .text-xl-center {\r\n                text-align: center !important\r\n            }\r\n        }\r\n\r\n        .text-lowercase {\r\n            text-transform: lowercase !important\r\n        }\r\n\r\n        .text-uppercase {\r\n            text-transform: uppercase !important\r\n        }\r\n\r\n        .text-capitalize {\r\n            text-transform: capitalize !important\r\n        }\r\n\r\n        .font-weight-light {\r\n            font-weight: 300 !important\r\n        }\r\n\r\n        .font-weight-normal {\r\n            font-weight: 400 !important\r\n        }\r\n\r\n        .font-weight-bold {\r\n            font-weight: 700 !important\r\n        }\r\n\r\n        .font-italic {\r\n            font-style: italic !important\r\n        }\r\n\r\n        .text-white {\r\n            color: #fff !important\r\n        }\r\n\r\n        .text-primary {\r\n            color: #007bff !important\r\n        }\r\n\r\n        a.text-primary:focus, a.text-primary:hover {\r\n            color: #0062cc !important\r\n        }\r\n\r\n        .text-secondary {\r\n            color: #6c757d !important\r\n        }\r\n\r\n        a.text-secondary:focus, a.text-secondary:hover {\r\n            color: #545b62 !important\r\n        }\r\n\r\n        .text-success {\r\n            color: #28a745 !important\r\n        }\r\n\r\n        a.text-success:focus, a.text-success:hover {\r\n            color: #1e7e34 !important\r\n        }\r\n\r\n        .text-info {\r\n            color: #17a2b8 !important\r\n        }\r\n\r\n        a.text-info:focus, a.text-info:hover {\r\n            color: #117a8b !important\r\n        }\r\n\r\n        .text-warning {\r\n            color: #ffc107 !important\r\n        }\r\n\r\n        a.text-warning:focus, a.text-warning:hover {\r\n            color: #d39e00 !important\r\n        }\r\n\r\n        .text-danger {\r\n            color: #dc3545 !important\r\n        }\r\n\r\n        a.text-danger:focus, a.text-danger:hover {\r\n            color: #bd2130 !important\r\n        }\r\n\r\n        .text-light {\r\n            color: #f8f9fa !important\r\n        }\r\n\r\n        a.text-light:focus, a.text-light:hover {\r\n            color: #dae0e5 !important\r\n        }\r\n\r\n        .text-dark {\r\n            color: #343a40 !important\r\n        }\r\n\r\n        a.text-dark:focus, a.text-dark:hover {\r\n            color: #1d2124 !important\r\n        }\r\n\r\n        .text-muted {\r\n            color: #6c757d !important\r\n        }\r\n\r\n        .text-hide {\r\n            font: 0/0 a;\r\n            color: transparent;\r\n            text-shadow: none;\r\n            background-color: transparent;\r\n            border: 0\r\n        }\r\n\r\n        .visible {\r\n            visibility: visible !important\r\n        }\r\n\r\n        .invisible {\r\n            visibility: hidden !important\r\n        }\r\n\r\n        @media print {\r\n            *, ::after, ::before {\r\n                text-shadow: none !important;\r\n                box-shadow: none !important\r\n            }\r\n\r\n            a:not(.btn) {\r\n                text-decoration: underline\r\n            }\r\n\r\n            abbr[title]::after {\r\n                content: \" (\" attr(title) \")\"\r\n            }\r\n\r\n            pre {\r\n                white-space: pre-wrap !important\r\n            }\r\n\r\n            blockquote, pre {\r\n                border: 1px solid #999;\r\n                page-break-inside: avoid\r\n            }\r\n\r\n            thead {\r\n                display: table-header-group\r\n            }\r\n\r\n            img, tr {\r\n                page-break-inside: avoid\r\n            }\r\n\r\n            h2, h3, p {\r\n                orphans: 3;\r\n                widows: 3\r\n            }\r\n\r\n            h2, h3 {\r\n                page-break-after: avoid\r\n            }\r\n\r\n            @page {\r\n                size: a3\r\n            }\r\n\r\n            body {\r\n                min-width: 992px !important\r\n            }\r\n\r\n            .container {\r\n                min-width: 992px !important\r\n            }\r\n\r\n            .navbar {\r\n                display: none\r\n            }\r\n\r\n            .badge {\r\n                border: 1px solid #000\r\n            }\r\n\r\n            .table {\r\n                border-collapse: collapse !important\r\n            }\r\n\r\n                .table td, .table th {\r\n                    background-color: #fff !important\r\n                }\r\n\r\n            .table-bordered td, .table-bordered th {\r\n                border: 1px solid #ddd !important\r\n            }\r\n        }\r\n        /*# sourceMappingURL=bootstrap.min.css.map */\r\n    </style>\r\n    <script type=\"text/javascript\">\r\n        !function (t, e) { \"object\" == typeof exports && \"undefined\" != typeof module ? e(exports, require(\"jquery\"), require(\"popper.js\")) : \"function\" == typeof define && define.amd ? define([\"exports\", \"jquery\", \"popper.js\"], e) : e(t.bootstrap = {}, t.jQuery, t.Popper) }(this, function (t, e, n) { \"use strict\"; function i(t, e) { for (var n = 0; n < e.length; n++) { var i = e[n]; i.enumerable = i.enumerable || !1, i.configurable = !0, \"value\" in i && (i.writable = !0), Object.defineProperty(t, i.key, i) } } function s(t, e, n) { return e && i(t.prototype, e), n && i(t, n), t } function r() { return (r = Object.assign || function (t) { for (var e = 1; e < arguments.length; e++) { var n = arguments[e]; for (var i in n) Object.prototype.hasOwnProperty.call(n, i) && (t[i] = n[i]) } return t }).apply(this, arguments) } e = e && e.hasOwnProperty(\"default\") ? e.default : e, n = n && n.hasOwnProperty(\"default\") ? n.default : n; var o, a, l, h, c, u, f, d, _, g, p, m, v, E, T, y, C, I, A, b, D, S, w, N, O, k, P = function (t) { var e = !1; function n(e) { var n = this, s = !1; return t(this).one(i.TRANSITION_END, function () { s = !0 }), setTimeout(function () { s || i.triggerTransitionEnd(n) }, e), this } var i = { TRANSITION_END: \"bsTransitionEnd\", getUID: function (t) { do { t += ~~(1e6 * Math.random()) } while (document.getElementById(t)); return t }, getSelectorFromElement: function (e) { var n, i = e.getAttribute(\"data-target\"); i && \"#\" !== i || (i = e.getAttribute(\"href\") || \"\"), \"#\" === i.charAt(0) && (n = i, i = n = \"function\" == typeof t.escapeSelector ? t.escapeSelector(n).substr(1) : n.replace(/(:|\\.|\\[|\\]|,|=|@)/g, \"\\\\$1\")); try { return t(document).find(i).length > 0 ? i : null } catch (t) { return null } }, reflow: function (t) { return t.offsetHeight }, triggerTransitionEnd: function (n) { t(n).trigger(e.end) }, supportsTransitionEnd: function () { return Boolean(e) }, isElement: function (t) { return (t[0] || t).nodeType }, typeCheckConfig: function (t, e, n) { for (var s in n) if (Object.prototype.hasOwnProperty.call(n, s)) { var r = n[s], o = e[s], a = o && i.isElement(o) ? \"element\" : (l = o, {}.toString.call(l).match(/\\s([a-zA-Z]+)/)[1].toLowerCase()); if (!new RegExp(r).test(a)) throw new Error(t.toUpperCase() + ': Option \"' + s + '\" provided type \"' + a + '\" but expected type \"' + r + '\".') } var l } }; return e = (\"undefined\" == typeof window || !window.QUnit) && { end: \"transitionend\" }, t.fn.emulateTransitionEnd = n, i.supportsTransitionEnd() && (t.event.special[i.TRANSITION_END] = { bindType: e.end, delegateType: e.end, handle: function (e) { if (t(e.target).is(this)) return e.handleObj.handler.apply(this, arguments) } }), i }(e), L = (a = \"alert\", h = \".\" + (l = \"bs.alert\"), c = (o = e).fn[a], u = { CLOSE: \"close\" + h, CLOSED: \"closed\" + h, CLICK_DATA_API: \"click\" + h + \".data-api\" }, f = \"alert\", d = \"fade\", _ = \"show\", g = function () { function t(t) { this._element = t } var e = t.prototype; return e.close = function (t) { t = t || this._element; var e = this._getRootElement(t); this._triggerCloseEvent(e).isDefaultPrevented() || this._removeElement(e) }, e.dispose = function () { o.removeData(this._element, l), this._element = null }, e._getRootElement = function (t) { var e = P.getSelectorFromElement(t), n = !1; return e && (n = o(e)[0]), n || (n = o(t).closest(\".\" + f)[0]), n }, e._triggerCloseEvent = function (t) { var e = o.Event(u.CLOSE); return o(t).trigger(e), e }, e._removeElement = function (t) { var e = this; o(t).removeClass(_), P.supportsTransitionEnd() && o(t).hasClass(d) ? o(t).one(P.TRANSITION_END, function (n) { return e._destroyElement(t, n) }).emulateTransitionEnd(150) : this._destroyElement(t) }, e._destroyElement = function (t) { o(t).detach().trigger(u.CLOSED).remove() }, t._jQueryInterface = function (e) { return this.each(function () { var n = o(this), i = n.data(l); i || (i = new t(this), n.data(l, i)), \"close\" === e && i[e](this) }) }, t._handleDismiss = function (t) { return function (e) { e && e.preventDefault(), t.close(this) } }, s(t, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }]), t }(), o(document).on(u.CLICK_DATA_API, '[data-dismiss=\"alert\"]', g._handleDismiss(new g)), o.fn[a] = g._jQueryInterface, o.fn[a].Constructor = g, o.fn[a].noConflict = function () { return o.fn[a] = c, g._jQueryInterface }, g), R = (m = \"button\", E = \".\" + (v = \"bs.button\"), T = \".data-api\", y = (p = e).fn[m], C = \"active\", I = \"btn\", A = \"focus\", b = '[data-toggle^=\"button\"]', D = '[data-toggle=\"buttons\"]', S = \"input\", w = \".active\", N = \".btn\", O = { CLICK_DATA_API: \"click\" + E + T, FOCUS_BLUR_DATA_API: \"focus\" + E + T + \" blur\" + E + T }, k = function () { function t(t) { this._element = t } var e = t.prototype; return e.toggle = function () { var t = !0, e = !0, n = p(this._element).closest(D)[0]; if (n) { var i = p(this._element).find(S)[0]; if (i) { if (\"radio\" === i.type) if (i.checked && p(this._element).hasClass(C)) t = !1; else { var s = p(n).find(w)[0]; s && p(s).removeClass(C) } if (t) { if (i.hasAttribute(\"disabled\") || n.hasAttribute(\"disabled\") || i.classList.contains(\"disabled\") || n.classList.contains(\"disabled\")) return; i.checked = !p(this._element).hasClass(C), p(i).trigger(\"change\") } i.focus(), e = !1 } } e && this._element.setAttribute(\"aria-pressed\", !p(this._element).hasClass(C)), t && p(this._element).toggleClass(C) }, e.dispose = function () { p.removeData(this._element, v), this._element = null }, t._jQueryInterface = function (e) { return this.each(function () { var n = p(this).data(v); n || (n = new t(this), p(this).data(v, n)), \"toggle\" === e && n[e]() }) }, s(t, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }]), t }(), p(document).on(O.CLICK_DATA_API, b, function (t) { t.preventDefault(); var e = t.target; p(e).hasClass(I) || (e = p(e).closest(N)), k._jQueryInterface.call(p(e), \"toggle\") }).on(O.FOCUS_BLUR_DATA_API, b, function (t) { var e = p(t.target).closest(N)[0]; p(e).toggleClass(A, /^focus(in)?$/.test(t.type)) }), p.fn[m] = k._jQueryInterface, p.fn[m].Constructor = k, p.fn[m].noConflict = function () { return p.fn[m] = y, k._jQueryInterface }, k), j = function (t) { var e = \"carousel\", n = \"bs.carousel\", i = \".\" + n, o = t.fn[e], a = { interval: 5e3, keyboard: !0, slide: !1, pause: \"hover\", wrap: !0 }, l = { interval: \"(number|boolean)\", keyboard: \"boolean\", slide: \"(boolean|string)\", pause: \"(string|boolean)\", wrap: \"boolean\" }, h = \"next\", c = \"prev\", u = \"left\", f = \"right\", d = { SLIDE: \"slide\" + i, SLID: \"slid\" + i, KEYDOWN: \"keydown\" + i, MOUSEENTER: \"mouseenter\" + i, MOUSELEAVE: \"mouseleave\" + i, TOUCHEND: \"touchend\" + i, LOAD_DATA_API: \"load\" + i + \".data-api\", CLICK_DATA_API: \"click\" + i + \".data-api\" }, _ = \"carousel\", g = \"active\", p = \"slide\", m = \"carousel-item-right\", v = \"carousel-item-left\", E = \"carousel-item-next\", T = \"carousel-item-prev\", y = { ACTIVE: \".active\", ACTIVE_ITEM: \".active.carousel-item\", ITEM: \".carousel-item\", NEXT_PREV: \".carousel-item-next, .carousel-item-prev\", INDICATORS: \".carousel-indicators\", DATA_SLIDE: \"[data-slide], [data-slide-to]\", DATA_RIDE: '[data-ride=\"carousel\"]' }, C = function () { function o(e, n) { this._items = null, this._interval = null, this._activeElement = null, this._isPaused = !1, this._isSliding = !1, this.touchTimeout = null, this._config = this._getConfig(n), this._element = t(e)[0], this._indicatorsElement = t(this._element).find(y.INDICATORS)[0], this._addEventListeners() } var C = o.prototype; return C.next = function () { this._isSliding || this._slide(h) }, C.nextWhenVisible = function () { !document.hidden && t(this._element).is(\":visible\") && \"hidden\" !== t(this._element).css(\"visibility\") && this.next() }, C.prev = function () { this._isSliding || this._slide(c) }, C.pause = function (e) { e || (this._isPaused = !0), t(this._element).find(y.NEXT_PREV)[0] && P.supportsTransitionEnd() && (P.triggerTransitionEnd(this._element), this.cycle(!0)), clearInterval(this._interval), this._interval = null }, C.cycle = function (t) { t || (this._isPaused = !1), this._interval && (clearInterval(this._interval), this._interval = null), this._config.interval && !this._isPaused && (this._interval = setInterval((document.visibilityState ? this.nextWhenVisible : this.next).bind(this), this._config.interval)) }, C.to = function (e) { var n = this; this._activeElement = t(this._element).find(y.ACTIVE_ITEM)[0]; var i = this._getItemIndex(this._activeElement); if (!(e > this._items.length - 1 || e < 0)) if (this._isSliding) t(this._element).one(d.SLID, function () { return n.to(e) }); else { if (i === e) return this.pause(), void this.cycle(); var s = e > i ? h : c; this._slide(s, this._items[e]) } }, C.dispose = function () { t(this._element).off(i), t.removeData(this._element, n), this._items = null, this._config = null, this._element = null, this._interval = null, this._isPaused = null, this._isSliding = null, this._activeElement = null, this._indicatorsElement = null }, C._getConfig = function (t) { return t = r({}, a, t), P.typeCheckConfig(e, t, l), t }, C._addEventListeners = function () { var e = this; this._config.keyboard && t(this._element).on(d.KEYDOWN, function (t) { return e._keydown(t) }), \"hover\" === this._config.pause && (t(this._element).on(d.MOUSEENTER, function (t) { return e.pause(t) }).on(d.MOUSELEAVE, function (t) { return e.cycle(t) }), \"ontouchstart\" in document.documentElement && t(this._element).on(d.TOUCHEND, function () { e.pause(), e.touchTimeout && clearTimeout(e.touchTimeout), e.touchTimeout = setTimeout(function (t) { return e.cycle(t) }, 500 + e._config.interval) })) }, C._keydown = function (t) { if (!/input|textarea/i.test(t.target.tagName)) switch (t.which) { case 37: t.preventDefault(), this.prev(); break; case 39: t.preventDefault(), this.next() } }, C._getItemIndex = function (e) { return this._items = t.makeArray(t(e).parent().find(y.ITEM)), this._items.indexOf(e) }, C._getItemByDirection = function (t, e) { var n = t === h, i = t === c, s = this._getItemIndex(e), r = this._items.length - 1; if ((i && 0 === s || n && s === r) && !this._config.wrap) return e; var o = (s + (t === c ? -1 : 1)) % this._items.length; return -1 === o ? this._items[this._items.length - 1] : this._items[o] }, C._triggerSlideEvent = function (e, n) { var i = this._getItemIndex(e), s = this._getItemIndex(t(this._element).find(y.ACTIVE_ITEM)[0]), r = t.Event(d.SLIDE, { relatedTarget: e, direction: n, from: s, to: i }); return t(this._element).trigger(r), r }, C._setActiveIndicatorElement = function (e) { if (this._indicatorsElement) { t(this._indicatorsElement).find(y.ACTIVE).removeClass(g); var n = this._indicatorsElement.children[this._getItemIndex(e)]; n && t(n).addClass(g) } }, C._slide = function (e, n) { var i, s, r, o = this, a = t(this._element).find(y.ACTIVE_ITEM)[0], l = this._getItemIndex(a), c = n || a && this._getItemByDirection(e, a), _ = this._getItemIndex(c), C = Boolean(this._interval); if (e === h ? (i = v, s = E, r = u) : (i = m, s = T, r = f), c && t(c).hasClass(g)) this._isSliding = !1; else if (!this._triggerSlideEvent(c, r).isDefaultPrevented() && a && c) { this._isSliding = !0, C && this.pause(), this._setActiveIndicatorElement(c); var I = t.Event(d.SLID, { relatedTarget: c, direction: r, from: l, to: _ }); P.supportsTransitionEnd() && t(this._element).hasClass(p) ? (t(c).addClass(s), P.reflow(c), t(a).addClass(i), t(c).addClass(i), t(a).one(P.TRANSITION_END, function () { t(c).removeClass(i + \" \" + s).addClass(g), t(a).removeClass(g + \" \" + s + \" \" + i), o._isSliding = !1, setTimeout(function () { return t(o._element).trigger(I) }, 0) }).emulateTransitionEnd(600)) : (t(a).removeClass(g), t(c).addClass(g), this._isSliding = !1, t(this._element).trigger(I)), C && this.cycle() } }, o._jQueryInterface = function (e) { return this.each(function () { var i = t(this).data(n), s = r({}, a, t(this).data()); \"object\" == typeof e && (s = r({}, s, e)); var l = \"string\" == typeof e ? e : s.slide; if (i || (i = new o(this, s), t(this).data(n, i)), \"number\" == typeof e) i.to(e); else if (\"string\" == typeof l) { if (\"undefined\" == typeof i[l]) throw new TypeError('No method named \"' + l + '\"'); i[l]() } else s.interval && (i.pause(), i.cycle()) }) }, o._dataApiClickHandler = function (e) { var i = P.getSelectorFromElement(this); if (i) { var s = t(i)[0]; if (s && t(s).hasClass(_)) { var a = r({}, t(s).data(), t(this).data()), l = this.getAttribute(\"data-slide-to\"); l && (a.interval = !1), o._jQueryInterface.call(t(s), a), l && t(s).data(n).to(l), e.preventDefault() } } }, s(o, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }, { key: \"Default\", get: function () { return a } }]), o }(); return t(document).on(d.CLICK_DATA_API, y.DATA_SLIDE, C._dataApiClickHandler), t(window).on(d.LOAD_DATA_API, function () { t(y.DATA_RIDE).each(function () { var e = t(this); C._jQueryInterface.call(e, e.data()) }) }), t.fn[e] = C._jQueryInterface, t.fn[e].Constructor = C, t.fn[e].noConflict = function () { return t.fn[e] = o, C._jQueryInterface }, C }(e), H = function (t) { var e = \"collapse\", n = \"bs.collapse\", i = \".\" + n, o = t.fn[e], a = { toggle: !0, parent: \"\" }, l = { toggle: \"boolean\", parent: \"(string|element)\" }, h = { SHOW: \"show\" + i, SHOWN: \"shown\" + i, HIDE: \"hide\" + i, HIDDEN: \"hidden\" + i, CLICK_DATA_API: \"click\" + i + \".data-api\" }, c = \"show\", u = \"collapse\", f = \"collapsing\", d = \"collapsed\", _ = \"width\", g = \"height\", p = { ACTIVES: \".show, .collapsing\", DATA_TOGGLE: '[data-toggle=\"collapse\"]' }, m = function () { function i(e, n) { this._isTransitioning = !1, this._element = e, this._config = this._getConfig(n), this._triggerArray = t.makeArray(t('[data-toggle=\"collapse\"][href=\"#' + e.id + '\"],[data-toggle=\"collapse\"][data-target=\"#' + e.id + '\"]')); for (var i = t(p.DATA_TOGGLE), s = 0; s < i.length; s++) { var r = i[s], o = P.getSelectorFromElement(r); null !== o && t(o).filter(e).length > 0 && (this._selector = o, this._triggerArray.push(r)) } this._parent = this._config.parent ? this._getParent() : null, this._config.parent || this._addAriaAndCollapsedClass(this._element, this._triggerArray), this._config.toggle && this.toggle() } var o = i.prototype; return o.toggle = function () { t(this._element).hasClass(c) ? this.hide() : this.show() }, o.show = function () { var e, s, r = this; if (!this._isTransitioning && !t(this._element).hasClass(c) && (this._parent && 0 === (e = t.makeArray(t(this._parent).find(p.ACTIVES).filter('[data-parent=\"' + this._config.parent + '\"]'))).length && (e = null), !(e && (s = t(e).not(this._selector).data(n)) && s._isTransitioning))) { var o = t.Event(h.SHOW); if (t(this._element).trigger(o), !o.isDefaultPrevented()) { e && (i._jQueryInterface.call(t(e).not(this._selector), \"hide\"), s || t(e).data(n, null)); var a = this._getDimension(); t(this._element).removeClass(u).addClass(f), this._element.style[a] = 0, this._triggerArray.length > 0 && t(this._triggerArray).removeClass(d).attr(\"aria-expanded\", !0), this.setTransitioning(!0); var l = function () { t(r._element).removeClass(f).addClass(u).addClass(c), r._element.style[a] = \"\", r.setTransitioning(!1), t(r._element).trigger(h.SHOWN) }; if (P.supportsTransitionEnd()) { var _ = \"scroll\" + (a[0].toUpperCase() + a.slice(1)); t(this._element).one(P.TRANSITION_END, l).emulateTransitionEnd(600), this._element.style[a] = this._element[_] + \"px\" } else l() } } }, o.hide = function () { var e = this; if (!this._isTransitioning && t(this._element).hasClass(c)) { var n = t.Event(h.HIDE); if (t(this._element).trigger(n), !n.isDefaultPrevented()) { var i = this._getDimension(); if (this._element.style[i] = this._element.getBoundingClientRect()[i] + \"px\", P.reflow(this._element), t(this._element).addClass(f).removeClass(u).removeClass(c), this._triggerArray.length > 0) for (var s = 0; s < this._triggerArray.length; s++) { var r = this._triggerArray[s], o = P.getSelectorFromElement(r); if (null !== o) t(o).hasClass(c) || t(r).addClass(d).attr(\"aria-expanded\", !1) } this.setTransitioning(!0); var a = function () { e.setTransitioning(!1), t(e._element).removeClass(f).addClass(u).trigger(h.HIDDEN) }; this._element.style[i] = \"\", P.supportsTransitionEnd() ? t(this._element).one(P.TRANSITION_END, a).emulateTransitionEnd(600) : a() } } }, o.setTransitioning = function (t) { this._isTransitioning = t }, o.dispose = function () { t.removeData(this._element, n), this._config = null, this._parent = null, this._element = null, this._triggerArray = null, this._isTransitioning = null }, o._getConfig = function (t) { return (t = r({}, a, t)).toggle = Boolean(t.toggle), P.typeCheckConfig(e, t, l), t }, o._getDimension = function () { return t(this._element).hasClass(_) ? _ : g }, o._getParent = function () { var e = this, n = null; P.isElement(this._config.parent) ? (n = this._config.parent, \"undefined\" != typeof this._config.parent.jquery && (n = this._config.parent[0])) : n = t(this._config.parent)[0]; var s = '[data-toggle=\"collapse\"][data-parent=\"' + this._config.parent + '\"]'; return t(n).find(s).each(function (t, n) { e._addAriaAndCollapsedClass(i._getTargetFromElement(n), [n]) }), n }, o._addAriaAndCollapsedClass = function (e, n) { if (e) { var i = t(e).hasClass(c); n.length > 0 && t(n).toggleClass(d, !i).attr(\"aria-expanded\", i) } }, i._getTargetFromElement = function (e) { var n = P.getSelectorFromElement(e); return n ? t(n)[0] : null }, i._jQueryInterface = function (e) { return this.each(function () { var s = t(this), o = s.data(n), l = r({}, a, s.data(), \"object\" == typeof e && e); if (!o && l.toggle && /show|hide/.test(e) && (l.toggle = !1), o || (o = new i(this, l), s.data(n, o)), \"string\" == typeof e) { if (\"undefined\" == typeof o[e]) throw new TypeError('No method named \"' + e + '\"'); o[e]() } }) }, s(i, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }, { key: \"Default\", get: function () { return a } }]), i }(); return t(document).on(h.CLICK_DATA_API, p.DATA_TOGGLE, function (e) { \"A\" === e.currentTarget.tagName && e.preventDefault(); var i = t(this), s = P.getSelectorFromElement(this); t(s).each(function () { var e = t(this), s = e.data(n) ? \"toggle\" : i.data(); m._jQueryInterface.call(e, s) }) }), t.fn[e] = m._jQueryInterface, t.fn[e].Constructor = m, t.fn[e].noConflict = function () { return t.fn[e] = o, m._jQueryInterface }, m }(e), W = function (t) { var e = \"dropdown\", i = \"bs.dropdown\", o = \".\" + i, a = \".data-api\", l = t.fn[e], h = new RegExp(\"38|40|27\"), c = { HIDE: \"hide\" + o, HIDDEN: \"hidden\" + o, SHOW: \"show\" + o, SHOWN: \"shown\" + o, CLICK: \"click\" + o, CLICK_DATA_API: \"click\" + o + a, KEYDOWN_DATA_API: \"keydown\" + o + a, KEYUP_DATA_API: \"keyup\" + o + a }, u = \"disabled\", f = \"show\", d = \"dropup\", _ = \"dropright\", g = \"dropleft\", p = \"dropdown-menu-right\", m = \"dropdown-menu-left\", v = \"position-static\", E = '[data-toggle=\"dropdown\"]', T = \".dropdown form\", y = \".dropdown-menu\", C = \".navbar-nav\", I = \".dropdown-menu .dropdown-item:not(.disabled)\", A = \"top-start\", b = \"top-end\", D = \"bottom-start\", S = \"bottom-end\", w = \"right-start\", N = \"left-start\", O = { offset: 0, flip: !0, boundary: \"scrollParent\" }, k = { offset: \"(number|string|function)\", flip: \"boolean\", boundary: \"(string|element)\" }, L = function () { function a(t, e) { this._element = t, this._popper = null, this._config = this._getConfig(e), this._menu = this._getMenuElement(), this._inNavbar = this._detectNavbar(), this._addEventListeners() } var l = a.prototype; return l.toggle = function () { if (!this._element.disabled && !t(this._element).hasClass(u)) { var e = a._getParentFromElement(this._element), i = t(this._menu).hasClass(f); if (a._clearMenus(), !i) { var s = { relatedTarget: this._element }, r = t.Event(c.SHOW, s); if (t(e).trigger(r), !r.isDefaultPrevented()) { if (!this._inNavbar) { if (\"undefined\" == typeof n) throw new TypeError(\"Bootstrap dropdown require Popper.js (https://popper.js.org)\"); var o = this._element; t(e).hasClass(d) && (t(this._menu).hasClass(m) || t(this._menu).hasClass(p)) && (o = e), \"scrollParent\" !== this._config.boundary && t(e).addClass(v), this._popper = new n(o, this._menu, this._getPopperConfig()) } \"ontouchstart\" in document.documentElement && 0 === t(e).closest(C).length && t(\"body\").children().on(\"mouseover\", null, t.noop), this._element.focus(), this._element.setAttribute(\"aria-expanded\", !0), t(this._menu).toggleClass(f), t(e).toggleClass(f).trigger(t.Event(c.SHOWN, s)) } } } }, l.dispose = function () { t.removeData(this._element, i), t(this._element).off(o), this._element = null, this._menu = null, null !== this._popper && (this._popper.destroy(), this._popper = null) }, l.update = function () { this._inNavbar = this._detectNavbar(), null !== this._popper && this._popper.scheduleUpdate() }, l._addEventListeners = function () { var e = this; t(this._element).on(c.CLICK, function (t) { t.preventDefault(), t.stopPropagation(), e.toggle() }) }, l._getConfig = function (n) { return n = r({}, this.constructor.Default, t(this._element).data(), n), P.typeCheckConfig(e, n, this.constructor.DefaultType), n }, l._getMenuElement = function () { if (!this._menu) { var e = a._getParentFromElement(this._element); this._menu = t(e).find(y)[0] } return this._menu }, l._getPlacement = function () { var e = t(this._element).parent(), n = D; return e.hasClass(d) ? (n = A, t(this._menu).hasClass(p) && (n = b)) : e.hasClass(_) ? n = w : e.hasClass(g) ? n = N : t(this._menu).hasClass(p) && (n = S), n }, l._detectNavbar = function () { return t(this._element).closest(\".navbar\").length > 0 }, l._getPopperConfig = function () { var t = this, e = {}; return \"function\" == typeof this._config.offset ? e.fn = function (e) { return e.offsets = r({}, e.offsets, t._config.offset(e.offsets) || {}), e } : e.offset = this._config.offset, { placement: this._getPlacement(), modifiers: { offset: e, flip: { enabled: this._config.flip }, preventOverflow: { boundariesElement: this._config.boundary } } } }, a._jQueryInterface = function (e) { return this.each(function () { var n = t(this).data(i); if (n || (n = new a(this, \"object\" == typeof e ? e : null), t(this).data(i, n)), \"string\" == typeof e) { if (\"undefined\" == typeof n[e]) throw new TypeError('No method named \"' + e + '\"'); n[e]() } }) }, a._clearMenus = function (e) { if (!e || 3 !== e.which && (\"keyup\" !== e.type || 9 === e.which)) for (var n = t.makeArray(t(E)), s = 0; s < n.length; s++) { var r = a._getParentFromElement(n[s]), o = t(n[s]).data(i), l = { relatedTarget: n[s] }; if (o) { var h = o._menu; if (t(r).hasClass(f) && !(e && (\"click\" === e.type && /input|textarea/i.test(e.target.tagName) || \"keyup\" === e.type && 9 === e.which) && t.contains(r, e.target))) { var u = t.Event(c.HIDE, l); t(r).trigger(u), u.isDefaultPrevented() || (\"ontouchstart\" in document.documentElement && t(\"body\").children().off(\"mouseover\", null, t.noop), n[s].setAttribute(\"aria-expanded\", \"false\"), t(h).removeClass(f), t(r).removeClass(f).trigger(t.Event(c.HIDDEN, l))) } } } }, a._getParentFromElement = function (e) { var n, i = P.getSelectorFromElement(e); return i && (n = t(i)[0]), n || e.parentNode }, a._dataApiKeydownHandler = function (e) { if ((/input|textarea/i.test(e.target.tagName) ? !(32 === e.which || 27 !== e.which && (40 !== e.which && 38 !== e.which || t(e.target).closest(y).length)) : h.test(e.which)) && (e.preventDefault(), e.stopPropagation(), !this.disabled && !t(this).hasClass(u))) { var n = a._getParentFromElement(this), i = t(n).hasClass(f); if ((i || 27 === e.which && 32 === e.which) && (!i || 27 !== e.which && 32 !== e.which)) { var s = t(n).find(I).get(); if (0 !== s.length) { var r = s.indexOf(e.target); 38 === e.which && r > 0 && r-- , 40 === e.which && r < s.length - 1 && r++ , r < 0 && (r = 0), s[r].focus() } } else { if (27 === e.which) { var o = t(n).find(E)[0]; t(o).trigger(\"focus\") } t(this).trigger(\"click\") } } }, s(a, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }, { key: \"Default\", get: function () { return O } }, { key: \"DefaultType\", get: function () { return k } }]), a }(); return t(document).on(c.KEYDOWN_DATA_API, E, L._dataApiKeydownHandler).on(c.KEYDOWN_DATA_API, y, L._dataApiKeydownHandler).on(c.CLICK_DATA_API + \" \" + c.KEYUP_DATA_API, L._clearMenus).on(c.CLICK_DATA_API, E, function (e) { e.preventDefault(), e.stopPropagation(), L._jQueryInterface.call(t(this), \"toggle\") }).on(c.CLICK_DATA_API, T, function (t) { t.stopPropagation() }), t.fn[e] = L._jQueryInterface, t.fn[e].Constructor = L, t.fn[e].noConflict = function () { return t.fn[e] = l, L._jQueryInterface }, L }(e), M = function (t) { var e = \"modal\", n = \"bs.modal\", i = \".\" + n, o = t.fn.modal, a = { backdrop: !0, keyboard: !0, focus: !0, show: !0 }, l = { backdrop: \"(boolean|string)\", keyboard: \"boolean\", focus: \"boolean\", show: \"boolean\" }, h = { HIDE: \"hide\" + i, HIDDEN: \"hidden\" + i, SHOW: \"show\" + i, SHOWN: \"shown\" + i, FOCUSIN: \"focusin\" + i, RESIZE: \"resize\" + i, CLICK_DISMISS: \"click.dismiss\" + i, KEYDOWN_DISMISS: \"keydown.dismiss\" + i, MOUSEUP_DISMISS: \"mouseup.dismiss\" + i, MOUSEDOWN_DISMISS: \"mousedown.dismiss\" + i, CLICK_DATA_API: \"click\" + i + \".data-api\" }, c = \"modal-scrollbar-measure\", u = \"modal-backdrop\", f = \"modal-open\", d = \"fade\", _ = \"show\", g = { DIALOG: \".modal-dialog\", DATA_TOGGLE: '[data-toggle=\"modal\"]', DATA_DISMISS: '[data-dismiss=\"modal\"]', FIXED_CONTENT: \".fixed-top, .fixed-bottom, .is-fixed, .sticky-top\", STICKY_CONTENT: \".sticky-top\", NAVBAR_TOGGLER: \".navbar-toggler\" }, p = function () { function o(e, n) { this._config = this._getConfig(n), this._element = e, this._dialog = t(e).find(g.DIALOG)[0], this._backdrop = null, this._isShown = !1, this._isBodyOverflowing = !1, this._ignoreBackdropClick = !1, this._originalBodyPadding = 0, this._scrollbarWidth = 0 } var p = o.prototype; return p.toggle = function (t) { return this._isShown ? this.hide() : this.show(t) }, p.show = function (e) { var n = this; if (!this._isTransitioning && !this._isShown) { P.supportsTransitionEnd() && t(this._element).hasClass(d) && (this._isTransitioning = !0); var i = t.Event(h.SHOW, { relatedTarget: e }); t(this._element).trigger(i), this._isShown || i.isDefaultPrevented() || (this._isShown = !0, this._checkScrollbar(), this._setScrollbar(), this._adjustDialog(), t(document.body).addClass(f), this._setEscapeEvent(), this._setResizeEvent(), t(this._element).on(h.CLICK_DISMISS, g.DATA_DISMISS, function (t) { return n.hide(t) }), t(this._dialog).on(h.MOUSEDOWN_DISMISS, function () { t(n._element).one(h.MOUSEUP_DISMISS, function (e) { t(e.target).is(n._element) && (n._ignoreBackdropClick = !0) }) }), this._showBackdrop(function () { return n._showElement(e) })) } }, p.hide = function (e) { var n = this; if (e && e.preventDefault(), !this._isTransitioning && this._isShown) { var i = t.Event(h.HIDE); if (t(this._element).trigger(i), this._isShown && !i.isDefaultPrevented()) { this._isShown = !1; var s = P.supportsTransitionEnd() && t(this._element).hasClass(d); s && (this._isTransitioning = !0), this._setEscapeEvent(), this._setResizeEvent(), t(document).off(h.FOCUSIN), t(this._element).removeClass(_), t(this._element).off(h.CLICK_DISMISS), t(this._dialog).off(h.MOUSEDOWN_DISMISS), s ? t(this._element).one(P.TRANSITION_END, function (t) { return n._hideModal(t) }).emulateTransitionEnd(300) : this._hideModal() } } }, p.dispose = function () { t.removeData(this._element, n), t(window, document, this._element, this._backdrop).off(i), this._config = null, this._element = null, this._dialog = null, this._backdrop = null, this._isShown = null, this._isBodyOverflowing = null, this._ignoreBackdropClick = null, this._scrollbarWidth = null }, p.handleUpdate = function () { this._adjustDialog() }, p._getConfig = function (t) { return t = r({}, a, t), P.typeCheckConfig(e, t, l), t }, p._showElement = function (e) { var n = this, i = P.supportsTransitionEnd() && t(this._element).hasClass(d); this._element.parentNode && this._element.parentNode.nodeType === Node.ELEMENT_NODE || document.body.appendChild(this._element), this._element.style.display = \"block\", this._element.removeAttribute(\"aria-hidden\"), this._element.scrollTop = 0, i && P.reflow(this._element), t(this._element).addClass(_), this._config.focus && this._enforceFocus(); var s = t.Event(h.SHOWN, { relatedTarget: e }), r = function () { n._config.focus && n._element.focus(), n._isTransitioning = !1, t(n._element).trigger(s) }; i ? t(this._dialog).one(P.TRANSITION_END, r).emulateTransitionEnd(300) : r() }, p._enforceFocus = function () { var e = this; t(document).off(h.FOCUSIN).on(h.FOCUSIN, function (n) { document !== n.target && e._element !== n.target && 0 === t(e._element).has(n.target).length && e._element.focus() }) }, p._setEscapeEvent = function () { var e = this; this._isShown && this._config.keyboard ? t(this._element).on(h.KEYDOWN_DISMISS, function (t) { 27 === t.which && (t.preventDefault(), e.hide()) }) : this._isShown || t(this._element).off(h.KEYDOWN_DISMISS) }, p._setResizeEvent = function () { var e = this; this._isShown ? t(window).on(h.RESIZE, function (t) { return e.handleUpdate(t) }) : t(window).off(h.RESIZE) }, p._hideModal = function () { var e = this; this._element.style.display = \"none\", this._element.setAttribute(\"aria-hidden\", !0), this._isTransitioning = !1, this._showBackdrop(function () { t(document.body).removeClass(f), e._resetAdjustments(), e._resetScrollbar(), t(e._element).trigger(h.HIDDEN) }) }, p._removeBackdrop = function () { this._backdrop && (t(this._backdrop).remove(), this._backdrop = null) }, p._showBackdrop = function (e) { var n = this, i = t(this._element).hasClass(d) ? d : \"\"; if (this._isShown && this._config.backdrop) { var s = P.supportsTransitionEnd() && i; if (this._backdrop = document.createElement(\"div\"), this._backdrop.className = u, i && t(this._backdrop).addClass(i), t(this._backdrop).appendTo(document.body), t(this._element).on(h.CLICK_DISMISS, function (t) { n._ignoreBackdropClick ? n._ignoreBackdropClick = !1 : t.target === t.currentTarget && (\"static\" === n._config.backdrop ? n._element.focus() : n.hide()) }), s && P.reflow(this._backdrop), t(this._backdrop).addClass(_), !e) return; if (!s) return void e(); t(this._backdrop).one(P.TRANSITION_END, e).emulateTransitionEnd(150) } else if (!this._isShown && this._backdrop) { t(this._backdrop).removeClass(_); var r = function () { n._removeBackdrop(), e && e() }; P.supportsTransitionEnd() && t(this._element).hasClass(d) ? t(this._backdrop).one(P.TRANSITION_END, r).emulateTransitionEnd(150) : r() } else e && e() }, p._adjustDialog = function () { var t = this._element.scrollHeight > document.documentElement.clientHeight; !this._isBodyOverflowing && t && (this._element.style.paddingLeft = this._scrollbarWidth + \"px\"), this._isBodyOverflowing && !t && (this._element.style.paddingRight = this._scrollbarWidth + \"px\") }, p._resetAdjustments = function () { this._element.style.paddingLeft = \"\", this._element.style.paddingRight = \"\" }, p._checkScrollbar = function () { var t = document.body.getBoundingClientRect(); this._isBodyOverflowing = t.left + t.right < window.innerWidth, this._scrollbarWidth = this._getScrollbarWidth() }, p._setScrollbar = function () { var e = this; if (this._isBodyOverflowing) { t(g.FIXED_CONTENT).each(function (n, i) { var s = t(i)[0].style.paddingRight, r = t(i).css(\"padding-right\"); t(i).data(\"padding-right\", s).css(\"padding-right\", parseFloat(r) + e._scrollbarWidth + \"px\") }), t(g.STICKY_CONTENT).each(function (n, i) { var s = t(i)[0].style.marginRight, r = t(i).css(\"margin-right\"); t(i).data(\"margin-right\", s).css(\"margin-right\", parseFloat(r) - e._scrollbarWidth + \"px\") }), t(g.NAVBAR_TOGGLER).each(function (n, i) { var s = t(i)[0].style.marginRight, r = t(i).css(\"margin-right\"); t(i).data(\"margin-right\", s).css(\"margin-right\", parseFloat(r) + e._scrollbarWidth + \"px\") }); var n = document.body.style.paddingRight, i = t(\"body\").css(\"padding-right\"); t(\"body\").data(\"padding-right\", n).css(\"padding-right\", parseFloat(i) + this._scrollbarWidth + \"px\") } }, p._resetScrollbar = function () { t(g.FIXED_CONTENT).each(function (e, n) { var i = t(n).data(\"padding-right\"); \"undefined\" != typeof i && t(n).css(\"padding-right\", i).removeData(\"padding-right\") }), t(g.STICKY_CONTENT + \", \" + g.NAVBAR_TOGGLER).each(function (e, n) { var i = t(n).data(\"margin-right\"); \"undefined\" != typeof i && t(n).css(\"margin-right\", i).removeData(\"margin-right\") }); var e = t(\"body\").data(\"padding-right\"); \"undefined\" != typeof e && t(\"body\").css(\"padding-right\", e).removeData(\"padding-right\") }, p._getScrollbarWidth = function () { var t = document.createElement(\"div\"); t.className = c, document.body.appendChild(t); var e = t.getBoundingClientRect().width - t.clientWidth; return document.body.removeChild(t), e }, o._jQueryInterface = function (e, i) { return this.each(function () { var s = t(this).data(n), a = r({}, o.Default, t(this).data(), \"object\" == typeof e && e); if (s || (s = new o(this, a), t(this).data(n, s)), \"string\" == typeof e) { if (\"undefined\" == typeof s[e]) throw new TypeError('No method named \"' + e + '\"'); s[e](i) } else a.show && s.show(i) }) }, s(o, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }, { key: \"Default\", get: function () { return a } }]), o }(); return t(document).on(h.CLICK_DATA_API, g.DATA_TOGGLE, function (e) { var i, s = this, o = P.getSelectorFromElement(this); o && (i = t(o)[0]); var a = t(i).data(n) ? \"toggle\" : r({}, t(i).data(), t(this).data()); \"A\" !== this.tagName && \"AREA\" !== this.tagName || e.preventDefault(); var l = t(i).one(h.SHOW, function (e) { e.isDefaultPrevented() || l.one(h.HIDDEN, function () { t(s).is(\":visible\") && s.focus() }) }); p._jQueryInterface.call(t(i), a, this) }), t.fn.modal = p._jQueryInterface, t.fn.modal.Constructor = p, t.fn.modal.noConflict = function () { return t.fn.modal = o, p._jQueryInterface }, p }(e), U = function (t) { var e = \"tooltip\", i = \"bs.tooltip\", o = \".\" + i, a = t.fn[e], l = new RegExp(\"(^|\\\\s)bs-tooltip\\\\S+\", \"g\"), h = { animation: \"boolean\", template: \"string\", title: \"(string|element|function)\", trigger: \"string\", delay: \"(number|object)\", html: \"boolean\", selector: \"(string|boolean)\", placement: \"(string|function)\", offset: \"(number|string)\", container: \"(string|element|boolean)\", fallbackPlacement: \"(string|array)\", boundary: \"(string|element)\" }, c = { AUTO: \"auto\", TOP: \"top\", RIGHT: \"right\", BOTTOM: \"bottom\", LEFT: \"left\" }, u = { animation: !0, template: '<div class=\"tooltip\" role=\"tooltip\"><div class=\"arrow\"></div><div class=\"tooltip-inner\"></div></div>', trigger: \"hover focus\", title: \"\", delay: 0, html: !1, selector: !1, placement: \"top\", offset: 0, container: !1, fallbackPlacement: \"flip\", boundary: \"scrollParent\" }, f = \"show\", d = \"out\", _ = { HIDE: \"hide\" + o, HIDDEN: \"hidden\" + o, SHOW: \"show\" + o, SHOWN: \"shown\" + o, INSERTED: \"inserted\" + o, CLICK: \"click\" + o, FOCUSIN: \"focusin\" + o, FOCUSOUT: \"focusout\" + o, MOUSEENTER: \"mouseenter\" + o, MOUSELEAVE: \"mouseleave\" + o }, g = \"fade\", p = \"show\", m = \".tooltip-inner\", v = \".arrow\", E = \"hover\", T = \"focus\", y = \"click\", C = \"manual\", I = function () { function a(t, e) { if (\"undefined\" == typeof n) throw new TypeError(\"Bootstrap tooltips require Popper.js (https://popper.js.org)\"); this._isEnabled = !0, this._timeout = 0, this._hoverState = \"\", this._activeTrigger = {}, this._popper = null, this.element = t, this.config = this._getConfig(e), this.tip = null, this._setListeners() } var I = a.prototype; return I.enable = function () { this._isEnabled = !0 }, I.disable = function () { this._isEnabled = !1 }, I.toggleEnabled = function () { this._isEnabled = !this._isEnabled }, I.toggle = function (e) { if (this._isEnabled) if (e) { var n = this.constructor.DATA_KEY, i = t(e.currentTarget).data(n); i || (i = new this.constructor(e.currentTarget, this._getDelegateConfig()), t(e.currentTarget).data(n, i)), i._activeTrigger.click = !i._activeTrigger.click, i._isWithActiveTrigger() ? i._enter(null, i) : i._leave(null, i) } else { if (t(this.getTipElement()).hasClass(p)) return void this._leave(null, this); this._enter(null, this) } }, I.dispose = function () { clearTimeout(this._timeout), t.removeData(this.element, this.constructor.DATA_KEY), t(this.element).off(this.constructor.EVENT_KEY), t(this.element).closest(\".modal\").off(\"hide.bs.modal\"), this.tip && t(this.tip).remove(), this._isEnabled = null, this._timeout = null, this._hoverState = null, this._activeTrigger = null, null !== this._popper && this._popper.destroy(), this._popper = null, this.element = null, this.config = null, this.tip = null }, I.show = function () { var e = this; if (\"none\" === t(this.element).css(\"display\")) throw new Error(\"Please use show on visible elements\"); var i = t.Event(this.constructor.Event.SHOW); if (this.isWithContent() && this._isEnabled) { t(this.element).trigger(i); var s = t.contains(this.element.ownerDocument.documentElement, this.element); if (i.isDefaultPrevented() || !s) return; var r = this.getTipElement(), o = P.getUID(this.constructor.NAME); r.setAttribute(\"id\", o), this.element.setAttribute(\"aria-describedby\", o), this.setContent(), this.config.animation && t(r).addClass(g); var l = \"function\" == typeof this.config.placement ? this.config.placement.call(this, r, this.element) : this.config.placement, h = this._getAttachment(l); this.addAttachmentClass(h); var c = !1 === this.config.container ? document.body : t(this.config.container); t(r).data(this.constructor.DATA_KEY, this), t.contains(this.element.ownerDocument.documentElement, this.tip) || t(r).appendTo(c), t(this.element).trigger(this.constructor.Event.INSERTED), this._popper = new n(this.element, r, { placement: h, modifiers: { offset: { offset: this.config.offset }, flip: { behavior: this.config.fallbackPlacement }, arrow: { element: v }, preventOverflow: { boundariesElement: this.config.boundary } }, onCreate: function (t) { t.originalPlacement !== t.placement && e._handlePopperPlacementChange(t) }, onUpdate: function (t) { e._handlePopperPlacementChange(t) } }), t(r).addClass(p), \"ontouchstart\" in document.documentElement && t(\"body\").children().on(\"mouseover\", null, t.noop); var u = function () { e.config.animation && e._fixTransition(); var n = e._hoverState; e._hoverState = null, t(e.element).trigger(e.constructor.Event.SHOWN), n === d && e._leave(null, e) }; P.supportsTransitionEnd() && t(this.tip).hasClass(g) ? t(this.tip).one(P.TRANSITION_END, u).emulateTransitionEnd(a._TRANSITION_DURATION) : u() } }, I.hide = function (e) { var n = this, i = this.getTipElement(), s = t.Event(this.constructor.Event.HIDE), r = function () { n._hoverState !== f && i.parentNode && i.parentNode.removeChild(i), n._cleanTipClass(), n.element.removeAttribute(\"aria-describedby\"), t(n.element).trigger(n.constructor.Event.HIDDEN), null !== n._popper && n._popper.destroy(), e && e() }; t(this.element).trigger(s), s.isDefaultPrevented() || (t(i).removeClass(p), \"ontouchstart\" in document.documentElement && t(\"body\").children().off(\"mouseover\", null, t.noop), this._activeTrigger[y] = !1, this._activeTrigger[T] = !1, this._activeTrigger[E] = !1, P.supportsTransitionEnd() && t(this.tip).hasClass(g) ? t(i).one(P.TRANSITION_END, r).emulateTransitionEnd(150) : r(), this._hoverState = \"\") }, I.update = function () { null !== this._popper && this._popper.scheduleUpdate() }, I.isWithContent = function () { return Boolean(this.getTitle()) }, I.addAttachmentClass = function (e) { t(this.getTipElement()).addClass(\"bs-tooltip-\" + e) }, I.getTipElement = function () { return this.tip = this.tip || t(this.config.template)[0], this.tip }, I.setContent = function () { var e = t(this.getTipElement()); this.setElementContent(e.find(m), this.getTitle()), e.removeClass(g + \" \" + p) }, I.setElementContent = function (e, n) { var i = this.config.html; \"object\" == typeof n && (n.nodeType || n.jquery) ? i ? t(n).parent().is(e) || e.empty().append(n) : e.text(t(n).text()) : e[i ? \"html\" : \"text\"](n) }, I.getTitle = function () { var t = this.element.getAttribute(\"data-original-title\"); return t || (t = \"function\" == typeof this.config.title ? this.config.title.call(this.element) : this.config.title), t }, I._getAttachment = function (t) { return c[t.toUpperCase()] }, I._setListeners = function () { var e = this; this.config.trigger.split(\" \").forEach(function (n) { if (\"click\" === n) t(e.element).on(e.constructor.Event.CLICK, e.config.selector, function (t) { return e.toggle(t) }); else if (n !== C) { var i = n === E ? e.constructor.Event.MOUSEENTER : e.constructor.Event.FOCUSIN, s = n === E ? e.constructor.Event.MOUSELEAVE : e.constructor.Event.FOCUSOUT; t(e.element).on(i, e.config.selector, function (t) { return e._enter(t) }).on(s, e.config.selector, function (t) { return e._leave(t) }) } t(e.element).closest(\".modal\").on(\"hide.bs.modal\", function () { return e.hide() }) }), this.config.selector ? this.config = r({}, this.config, { trigger: \"manual\", selector: \"\" }) : this._fixTitle() }, I._fixTitle = function () { var t = typeof this.element.getAttribute(\"data-original-title\"); (this.element.getAttribute(\"title\") || \"string\" !== t) && (this.element.setAttribute(\"data-original-title\", this.element.getAttribute(\"title\") || \"\"), this.element.setAttribute(\"title\", \"\")) }, I._enter = function (e, n) { var i = this.constructor.DATA_KEY; (n = n || t(e.currentTarget).data(i)) || (n = new this.constructor(e.currentTarget, this._getDelegateConfig()), t(e.currentTarget).data(i, n)), e && (n._activeTrigger[\"focusin\" === e.type ? T : E] = !0), t(n.getTipElement()).hasClass(p) || n._hoverState === f ? n._hoverState = f : (clearTimeout(n._timeout), n._hoverState = f, n.config.delay && n.config.delay.show ? n._timeout = setTimeout(function () { n._hoverState === f && n.show() }, n.config.delay.show) : n.show()) }, I._leave = function (e, n) { var i = this.constructor.DATA_KEY; (n = n || t(e.currentTarget).data(i)) || (n = new this.constructor(e.currentTarget, this._getDelegateConfig()), t(e.currentTarget).data(i, n)), e && (n._activeTrigger[\"focusout\" === e.type ? T : E] = !1), n._isWithActiveTrigger() || (clearTimeout(n._timeout), n._hoverState = d, n.config.delay && n.config.delay.hide ? n._timeout = setTimeout(function () { n._hoverState === d && n.hide() }, n.config.delay.hide) : n.hide()) }, I._isWithActiveTrigger = function () { for (var t in this._activeTrigger) if (this._activeTrigger[t]) return !0; return !1 }, I._getConfig = function (n) { return \"number\" == typeof (n = r({}, this.constructor.Default, t(this.element).data(), n)).delay && (n.delay = { show: n.delay, hide: n.delay }), \"number\" == typeof n.title && (n.title = n.title.toString()), \"number\" == typeof n.content && (n.content = n.content.toString()), P.typeCheckConfig(e, n, this.constructor.DefaultType), n }, I._getDelegateConfig = function () { var t = {}; if (this.config) for (var e in this.config) this.constructor.Default[e] !== this.config[e] && (t[e] = this.config[e]); return t }, I._cleanTipClass = function () { var e = t(this.getTipElement()), n = e.attr(\"class\").match(l); null !== n && n.length > 0 && e.removeClass(n.join(\"\")) }, I._handlePopperPlacementChange = function (t) { this._cleanTipClass(), this.addAttachmentClass(this._getAttachment(t.placement)) }, I._fixTransition = function () { var e = this.getTipElement(), n = this.config.animation; null === e.getAttribute(\"x-placement\") && (t(e).removeClass(g), this.config.animation = !1, this.hide(), this.show(), this.config.animation = n) }, a._jQueryInterface = function (e) { return this.each(function () { var n = t(this).data(i), s = \"object\" == typeof e && e; if ((n || !/dispose|hide/.test(e)) && (n || (n = new a(this, s), t(this).data(i, n)), \"string\" == typeof e)) { if (\"undefined\" == typeof n[e]) throw new TypeError('No method named \"' + e + '\"'); n[e]() } }) }, s(a, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }, { key: \"Default\", get: function () { return u } }, { key: \"NAME\", get: function () { return e } }, { key: \"DATA_KEY\", get: function () { return i } }, { key: \"Event\", get: function () { return _ } }, { key: \"EVENT_KEY\", get: function () { return o } }, { key: \"DefaultType\", get: function () { return h } }]), a }(); return t.fn[e] = I._jQueryInterface, t.fn[e].Constructor = I, t.fn[e].noConflict = function () { return t.fn[e] = a, I._jQueryInterface }, I }(e), x = function (t) { var e = \"popover\", n = \"bs.popover\", i = \".\" + n, o = t.fn[e], a = new RegExp(\"(^|\\\\s)bs-popover\\\\S+\", \"g\"), l = r({}, U.Default, { placement: \"right\", trigger: \"click\", content: \"\", template: '<div class=\"popover\" role=\"tooltip\"><div class=\"arrow\"></div><h3 class=\"popover-header\"></h3><div class=\"popover-body\"></div></div>' }), h = r({}, U.DefaultType, { content: \"(string|element|function)\" }), c = \"fade\", u = \"show\", f = \".popover-header\", d = \".popover-body\", _ = { HIDE: \"hide\" + i, HIDDEN: \"hidden\" + i, SHOW: \"show\" + i, SHOWN: \"shown\" + i, INSERTED: \"inserted\" + i, CLICK: \"click\" + i, FOCUSIN: \"focusin\" + i, FOCUSOUT: \"focusout\" + i, MOUSEENTER: \"mouseenter\" + i, MOUSELEAVE: \"mouseleave\" + i }, g = function (r) { var o, g; function p() { return r.apply(this, arguments) || this } g = r, (o = p).prototype = Object.create(g.prototype), o.prototype.constructor = o, o.__proto__ = g; var m = p.prototype; return m.isWithContent = function () { return this.getTitle() || this._getContent() }, m.addAttachmentClass = function (e) { t(this.getTipElement()).addClass(\"bs-popover-\" + e) }, m.getTipElement = function () { return this.tip = this.tip || t(this.config.template)[0], this.tip }, m.setContent = function () { var e = t(this.getTipElement()); this.setElementContent(e.find(f), this.getTitle()); var n = this._getContent(); \"function\" == typeof n && (n = n.call(this.element)), this.setElementContent(e.find(d), n), e.removeClass(c + \" \" + u) }, m._getContent = function () { return this.element.getAttribute(\"data-content\") || this.config.content }, m._cleanTipClass = function () { var e = t(this.getTipElement()), n = e.attr(\"class\").match(a); null !== n && n.length > 0 && e.removeClass(n.join(\"\")) }, p._jQueryInterface = function (e) { return this.each(function () { var i = t(this).data(n), s = \"object\" == typeof e ? e : null; if ((i || !/destroy|hide/.test(e)) && (i || (i = new p(this, s), t(this).data(n, i)), \"string\" == typeof e)) { if (\"undefined\" == typeof i[e]) throw new TypeError('No method named \"' + e + '\"'); i[e]() } }) }, s(p, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }, { key: \"Default\", get: function () { return l } }, { key: \"NAME\", get: function () { return e } }, { key: \"DATA_KEY\", get: function () { return n } }, { key: \"Event\", get: function () { return _ } }, { key: \"EVENT_KEY\", get: function () { return i } }, { key: \"DefaultType\", get: function () { return h } }]), p }(U); return t.fn[e] = g._jQueryInterface, t.fn[e].Constructor = g, t.fn[e].noConflict = function () { return t.fn[e] = o, g._jQueryInterface }, g }(e), K = function (t) { var e = \"scrollspy\", n = \"bs.scrollspy\", i = \".\" + n, o = t.fn[e], a = { offset: 10, method: \"auto\", target: \"\" }, l = { offset: \"number\", method: \"string\", target: \"(string|element)\" }, h = { ACTIVATE: \"activate\" + i, SCROLL: \"scroll\" + i, LOAD_DATA_API: \"load\" + i + \".data-api\" }, c = \"dropdown-item\", u = \"active\", f = { DATA_SPY: '[data-spy=\"scroll\"]', ACTIVE: \".active\", NAV_LIST_GROUP: \".nav, .list-group\", NAV_LINKS: \".nav-link\", NAV_ITEMS: \".nav-item\", LIST_ITEMS: \".list-group-item\", DROPDOWN: \".dropdown\", DROPDOWN_ITEMS: \".dropdown-item\", DROPDOWN_TOGGLE: \".dropdown-toggle\" }, d = \"offset\", _ = \"position\", g = function () { function o(e, n) { var i = this; this._element = e, this._scrollElement = \"BODY\" === e.tagName ? window : e, this._config = this._getConfig(n), this._selector = this._config.target + \" \" + f.NAV_LINKS + \",\" + this._config.target + \" \" + f.LIST_ITEMS + \",\" + this._config.target + \" \" + f.DROPDOWN_ITEMS, this._offsets = [], this._targets = [], this._activeTarget = null, this._scrollHeight = 0, t(this._scrollElement).on(h.SCROLL, function (t) { return i._process(t) }), this.refresh(), this._process() } var g = o.prototype; return g.refresh = function () { var e = this, n = this._scrollElement === this._scrollElement.window ? d : _, i = \"auto\" === this._config.method ? n : this._config.method, s = i === _ ? this._getScrollTop() : 0; this._offsets = [], this._targets = [], this._scrollHeight = this._getScrollHeight(), t.makeArray(t(this._selector)).map(function (e) { var n, r = P.getSelectorFromElement(e); if (r && (n = t(r)[0]), n) { var o = n.getBoundingClientRect(); if (o.width || o.height) return [t(n)[i]().top + s, r] } return null }).filter(function (t) { return t }).sort(function (t, e) { return t[0] - e[0] }).forEach(function (t) { e._offsets.push(t[0]), e._targets.push(t[1]) }) }, g.dispose = function () { t.removeData(this._element, n), t(this._scrollElement).off(i), this._element = null, this._scrollElement = null, this._config = null, this._selector = null, this._offsets = null, this._targets = null, this._activeTarget = null, this._scrollHeight = null }, g._getConfig = function (n) { if (\"string\" != typeof (n = r({}, a, n)).target) { var i = t(n.target).attr(\"id\"); i || (i = P.getUID(e), t(n.target).attr(\"id\", i)), n.target = \"#\" + i } return P.typeCheckConfig(e, n, l), n }, g._getScrollTop = function () { return this._scrollElement === window ? this._scrollElement.pageYOffset : this._scrollElement.scrollTop }, g._getScrollHeight = function () { return this._scrollElement.scrollHeight || Math.max(document.body.scrollHeight, document.documentElement.scrollHeight) }, g._getOffsetHeight = function () { return this._scrollElement === window ? window.innerHeight : this._scrollElement.getBoundingClientRect().height }, g._process = function () { var t = this._getScrollTop() + this._config.offset, e = this._getScrollHeight(), n = this._config.offset + e - this._getOffsetHeight(); if (this._scrollHeight !== e && this.refresh(), t >= n) { var i = this._targets[this._targets.length - 1]; this._activeTarget !== i && this._activate(i) } else { if (this._activeTarget && t < this._offsets[0] && this._offsets[0] > 0) return this._activeTarget = null, void this._clear(); for (var s = this._offsets.length; s--;) { this._activeTarget !== this._targets[s] && t >= this._offsets[s] && (\"undefined\" == typeof this._offsets[s + 1] || t < this._offsets[s + 1]) && this._activate(this._targets[s]) } } }, g._activate = function (e) { this._activeTarget = e, this._clear(); var n = this._selector.split(\",\"); n = n.map(function (t) { return t + '[data-target=\"' + e + '\"],' + t + '[href=\"' + e + '\"]' }); var i = t(n.join(\",\")); i.hasClass(c) ? (i.closest(f.DROPDOWN).find(f.DROPDOWN_TOGGLE).addClass(u), i.addClass(u)) : (i.addClass(u), i.parents(f.NAV_LIST_GROUP).prev(f.NAV_LINKS + \", \" + f.LIST_ITEMS).addClass(u), i.parents(f.NAV_LIST_GROUP).prev(f.NAV_ITEMS).children(f.NAV_LINKS).addClass(u)), t(this._scrollElement).trigger(h.ACTIVATE, { relatedTarget: e }) }, g._clear = function () { t(this._selector).filter(f.ACTIVE).removeClass(u) }, o._jQueryInterface = function (e) { return this.each(function () { var i = t(this).data(n); if (i || (i = new o(this, \"object\" == typeof e && e), t(this).data(n, i)), \"string\" == typeof e) { if (\"undefined\" == typeof i[e]) throw new TypeError('No method named \"' + e + '\"'); i[e]() } }) }, s(o, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }, { key: \"Default\", get: function () { return a } }]), o }(); return t(window).on(h.LOAD_DATA_API, function () { for (var e = t.makeArray(t(f.DATA_SPY)), n = e.length; n--;) { var i = t(e[n]); g._jQueryInterface.call(i, i.data()) } }), t.fn[e] = g._jQueryInterface, t.fn[e].Constructor = g, t.fn[e].noConflict = function () { return t.fn[e] = o, g._jQueryInterface }, g }(e), V = function (t) { var e = \"bs.tab\", n = \".\" + e, i = t.fn.tab, r = { HIDE: \"hide\" + n, HIDDEN: \"hidden\" + n, SHOW: \"show\" + n, SHOWN: \"shown\" + n, CLICK_DATA_API: \"click.bs.tab.data-api\" }, o = \"dropdown-menu\", a = \"active\", l = \"disabled\", h = \"fade\", c = \"show\", u = \".dropdown\", f = \".nav, .list-group\", d = \".active\", _ = \"> li > .active\", g = '[data-toggle=\"tab\"], [data-toggle=\"pill\"], [data-toggle=\"list\"]', p = \".dropdown-toggle\", m = \"> .dropdown-menu .active\", v = function () { function n(t) { this._element = t } var i = n.prototype; return i.show = function () { var e = this; if (!(this._element.parentNode && this._element.parentNode.nodeType === Node.ELEMENT_NODE && t(this._element).hasClass(a) || t(this._element).hasClass(l))) { var n, i, s = t(this._element).closest(f)[0], o = P.getSelectorFromElement(this._element); if (s) { var h = \"UL\" === s.nodeName ? _ : d; i = (i = t.makeArray(t(s).find(h)))[i.length - 1] } var c = t.Event(r.HIDE, { relatedTarget: this._element }), u = t.Event(r.SHOW, { relatedTarget: i }); if (i && t(i).trigger(c), t(this._element).trigger(u), !u.isDefaultPrevented() && !c.isDefaultPrevented()) { o && (n = t(o)[0]), this._activate(this._element, s); var g = function () { var n = t.Event(r.HIDDEN, { relatedTarget: e._element }), s = t.Event(r.SHOWN, { relatedTarget: i }); t(i).trigger(n), t(e._element).trigger(s) }; n ? this._activate(n, n.parentNode, g) : g() } } }, i.dispose = function () { t.removeData(this._element, e), this._element = null }, i._activate = function (e, n, i) { var s = this, r = (\"UL\" === n.nodeName ? t(n).find(_) : t(n).children(d))[0], o = i && P.supportsTransitionEnd() && r && t(r).hasClass(h), a = function () { return s._transitionComplete(e, r, i) }; r && o ? t(r).one(P.TRANSITION_END, a).emulateTransitionEnd(150) : a() }, i._transitionComplete = function (e, n, i) { if (n) { t(n).removeClass(c + \" \" + a); var s = t(n.parentNode).find(m)[0]; s && t(s).removeClass(a), \"tab\" === n.getAttribute(\"role\") && n.setAttribute(\"aria-selected\", !1) } if (t(e).addClass(a), \"tab\" === e.getAttribute(\"role\") && e.setAttribute(\"aria-selected\", !0), P.reflow(e), t(e).addClass(c), e.parentNode && t(e.parentNode).hasClass(o)) { var r = t(e).closest(u)[0]; r && t(r).find(p).addClass(a), e.setAttribute(\"aria-expanded\", !0) } i && i() }, n._jQueryInterface = function (i) { return this.each(function () { var s = t(this), r = s.data(e); if (r || (r = new n(this), s.data(e, r)), \"string\" == typeof i) { if (\"undefined\" == typeof r[i]) throw new TypeError('No method named \"' + i + '\"'); r[i]() } }) }, s(n, null, [{ key: \"VERSION\", get: function () { return \"4.0.0\" } }]), n }(); return t(document).on(r.CLICK_DATA_API, g, function (e) { e.preventDefault(), v._jQueryInterface.call(t(this), \"show\") }), t.fn.tab = v._jQueryInterface, t.fn.tab.Constructor = v, t.fn.tab.noConflict = function () { return t.fn.tab = i, v._jQueryInterface }, v }(e); !function (t) { if (\"undefined\" == typeof t) throw new TypeError(\"Bootstrap's JavaScript requires jQuery. jQuery must be included before Bootstrap's JavaScript.\"); var e = t.fn.jquery.split(\" \")[0].split(\".\"); if (e[0] < 2 && e[1] < 9 || 1 === e[0] && 9 === e[1] && e[2] < 1 || e[0] >= 4) throw new Error(\"Bootstrap's JavaScript requires at least jQuery v1.9.1 but less than v4.0.0\") }(e), t.Util = P, t.Alert = L, t.Button = R, t.Carousel = j, t.Collapse = H, t.Dropdown = W, t.Modal = M, t.Popover = x, t.Scrollspy = K, t.Tab = V, t.Tooltip = U, Object.defineProperty(t, \"__esModule\", { value: !0 }) });\n//# sourceMappingURL=bootstrap.min.js.map\r\n    </script>\r\n\r\n\r\n</head>\r\n<body>\r\n\r\n    <nav class=\"navbar navbar-dark bg-dark\">\r\n        <h1 style=\"color:white\">taskt</h1><small style=\"color:white\">free and open-source process automation</small>\r\n    </nav>\r\n    <br />\r\n\r\n\r\n    <div class=\"container\">\r\n\r\n        <h5><b>Directions:</b> This a sample data collection form that can be presented to a user.  You can add and implement as many fields as you need or choose standard form inputs. Note, each field will require a <b>v_applyToVariable</b> attribute specifying which variable should contain the respective value for the input field.</h5>\r\n\r\n        <hr />\r\n        <form>\r\n            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"inputEmail4\">Email</label>\r\n                    <input type=\"email\" class=\"form-control\" id=\"inputEmail4\" v_applyToVariable=\"vInput\" placeholder=\"Email\">\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"inputPassword4\">Password</label>\r\n                    <input type=\"password\" class=\"form-control\" id=\"inputPassword4\" v_applyToVariable=\"vPass\" placeholder=\"Password\">\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"inputAddress\">Address</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"inputAddress\" v_applyToVariable=\"vAddress\" placeholder=\"1234 Main St\">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"inputAddress2\">Address 2</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"inputAddress2\" v_applyToVariable=\"vAddress2\" placeholder=\"Apartment, studio, or floor\">\r\n            </div>\r\n            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label for=\"inputCity\">City</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"inputCity\" v_applyToVariable=\"vCity\">\r\n                </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    <label for=\"inputState\">State</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"inputState\" v_applyToVariable=\"vState\">\r\n                </div>\r\n                <div class=\"form-group col-md-2\">\r\n                    <label for=\"inputZip\">Zip</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"inputZip\" v_applyToVariable=\"vZip\">\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"form-check\">\r\n                    <input class=\"form-check-input\" type=\"checkbox\" id=\"gridCheck\" v_applyToVariable=\"vCheck\">\r\n                    <label class=\"form-check-label\" for=\"gridCheck\">\r\n                        Check me out\r\n                    </label>\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"exampleFormControlSelect1\">Example select</label>\r\n                <select class=\"form-control\" id=\"exampleFormControlSelect1\" v_applyToVariable=\"vSelected\">\r\n                    <option>1</option>\r\n                    <option>2</option>\r\n                    <option>3</option>\r\n                    <option>4</option>\r\n                    <option>5</option>\r\n                </select>\r\n            </div>\r\n            <button class=\"btn btn-primary\" onclick=\"window.external.Ok();\">Ok</button>\r\n            <button class=\"btn btn-primary\" onclick=\"window.external.Cancel();\">Close</button>\r\n        </form>\r\n    </div>\r\n\r\n</body>\r\n</html>";
        }

        public override void RunCommand(object sender)
        {
            var engine = (Engine.AutomationEngineInstance)sender;

            if (engine.tasktEngineUI == null)
            {
                engine.ReportProgress("HTML UserInput Supported With UI Only");
                MessageBox.Show("HTML UserInput Supported With UI Only", "UserInput Command", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //invoke ui for data collection
            var result = engine.tasktEngineUI.Invoke(new Action(() =>
                {
                    //sample for temp testing
                    var htmlInput = v_InputHTML.ConvertToUserVariable(sender);

                    var errorOnClose = this.GetUISelectionValue(nameof(v_ErrorOnClose), engine);

                    var variables = engine.tasktEngineUI.ShowHTMLInput(htmlInput);

                    //if user selected Ok then process variables
                    //null result means user cancelled/closed
                    if (variables != null)
                    {
                        //store each one into context
                        foreach (var variable in variables)
                        {
                            variable.VariableValue.ToString().StoreInUserVariable(sender, variable.VariableName);
                        }
                    }
                    else if (errorOnClose == "Error On Close")
                    {
                        throw new Exception("Input Form was closed by the user");
                    }
                }
            ));
        }

        private void ShowHTMLBuilder(object sender, EventArgs e)
        {
            using (var htmlForm = new UI.Forms.Supplemental.frmHTMLBuilder())
            {
                var htmlInput = (TextBox)ControlsList[nameof(v_InputHTML)];
                htmlForm.rtbHTML.Text = htmlInput.Text;

                if (htmlForm.ShowDialog() == DialogResult.OK)
                {
                    htmlInput.Text = htmlForm.rtbHTML.Text;
                }
            }
        }
    }
}