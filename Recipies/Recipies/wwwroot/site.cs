@import 'bootstrap.css';
@import url('http://fonts.googleapis.com/css?family=Source+Sans+Pro%3Aregular%2Citalic%2C700%2C200%2C300%2C300italic%2C900%7CRaleway%3Aregular%2C700%2C200%2C300%2C900%26subset%3Dlatin%2C&ver=2.1.1');

body {
    color: #333;
    font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
    font-size: 15px;
    line-height: 1.625;
}

h1, h2, h3, h4, h5, h6 {
    font-family: "Raleway","Helvetica Neue",sans-serif;
}

h2 {
    margin-top: 10px;
}

a {
    color: #e74797;
}

    a:hover {
        color: #111;
    }

img[src = ""] {
    visibility: hidden;
}

header {
    margin-bottom: 20px;
    text-align: center;
}

.main-logo {
    line-height: 1.5;
    padding: 20px;
    margin-top: -120px;
}

    .main-logo a
{
    background: url(http://portfolio.wpdiy.net/genesis/wp-content/uploads/2015/04/cropped-logo.png) no-repeat !important;
        display: inline-block;
    width: 800px;
    height: 230px;
    margin-bottom: -10px;
    color: rgba(0, 0, 0, 0);
}

.navbar {
    border-radius: 0;
    border-bottom: 1px solid #777;
    border-top: 1px solid #777;
    min-height: inherit;
}

    .navbar, .navbar.btn-link {
        font-weight: 400;
        font-family: "Source Sans Pro","Helvetica Neue",sans-serif;
        text-transform: uppercase;
    }

        .navbar form span {
            text-transform: none;
        }

        .navbar.btn-link {
            font-weight: 600;
        }

        .navbar a, .navbar.btn-link {
            color: #333;
            letter-spacing: 2px;
            font-size: 12px;
        }

            .navbar a.active
{
    font-weight: 800;
}

        .navbar.nav {
            width: 60%;
            margin: auto;
            display: inline-table;
        }

            .navbar.nav li
{
    display: table-cell;
    width: 1%;
                float: none;
}

        .navbar ul:last-child {
            float: right;
            width: 100px;
        }

.recipes.recipe {
    height: 40em;
    overflow: hidden;
    text-align: center;
}

    .recipes.recipe.img {
        width: auto;
        height: 15em;
    }

    .recipes.recipe p
{
    text-align: justify;
}

.btn.add-recipe {
    float: right;
    margin-top: -50px;
    margin-right: 15px;
}

.directions li
{
    margin-bottom: 15px;
}


/**** Validation    ****/
.field-validation-error {
    color: #d9534f;
    font-weight: bold;
}

.field-validation-valid {
    display: none;
}

.input-validation-error {
    border: 2px solid #d9534f;
    background-color: #E6AFAD;
}

.validation-summary-errors {
    color: #d9534f;
    font-weight: bold;
    font-size: 1.1em;
}

.validation-summary-valid {
    display: none;
}
/**** END: Validation ****/


/**** Sticky footer ****/
html {
    position: relative;
    min-height: 100%;
    margin: 0;
}

body {
    /* Margin bottom by footer height */
    margin-bottom: 80px;
}

footer {
    position: absolute;
    bottom: 0;
    width: 100%;
    height: 50px;
    line-height: 50px; /* Vertically center the text there */
    background-color: #f5f5f5;
}
/**** END: Sticky footer ****/