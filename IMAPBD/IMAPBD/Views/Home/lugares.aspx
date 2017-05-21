<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>IMAPDB - Empresa - Crear paquete</title>

    <!-- Bootstrap -->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" rel="stylesheet">
    <link href="Views/Home/res/css/font-awesome.min.css" rel="stylesheet">
    <link href="Views/Home/res/css/custom.css" rel="stylesheet">

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    
    <header>
        
        <div class="container">
            
            <div class="row">
                
                <div class="col-xs-8"><h1>IMAPDB</h1></div>
                <div class="col-xs-4"><i class="fa fa-sign-out fa-2x pull-right" aria-hidden="true"></i></div>
                
            </div>
            
            <div class="row menu">
                
                <div class="col-md-6 col-xs-12">
                    <ul>
                        <li><a href="index.html">Inicio</a></li>
                        <li><a href="crear-paquete.html">Crear paquetes</a></li>
                        <li><a href="lugares.html">Lugares</a></li>
                    </ul>
                </div>
                <div class="col-md-6 col-xs-12">
                   <div class="pull-right">
                        <form class="form-inline busqueda">

                            <div class="form-group ">
                                <input type="search" class="form-control" id="inputBuscar" placeholder="Buscar paquete">
                            </div>
                            <button type="submit" class="btn btn-primary">Buscar</button>
                        </form>
                    </div>
                    
                </div>
                
            </div>
            
        </div>
        
    </header>
    
    <div>
        
        <div class="container">
            
           
            <div class="row">
                
                <div class="col-md-8 col-md-offset-2 col-xs-12 col-xs-offset-0">
                    <h2>Lugares</h2>
                    <!-- On rows -->
                    <div class="table-responsive">
                        <table class="table table-condensed table-hover">

                            <!--<tr>
                            <td class="active">Cotizaciones</td>
                            <td class="success">Origen</td>
                            <td class="warning">Destino</td>
                            <td class="danger">estatus</td>
                            </tr>-->
                            <tr>
                                <td>Cotizaciones</td>
                                <td>Origen</td>
                                <td>Destino</td>
                                <td>estatus</td>
                            </tr>
                            <tr>
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>Default</td>
                            </tr>
                            <tr class="success">
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>App roved</td>
                            </tr>
                            <tr>
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>Default</td>
                            </tr>
                            <tr class="active">
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>Declined</td>
                            </tr>
                            <tr>
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>Default</td>
                            </tr>
                            <tr>
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>Default</td>
                            </tr>
                            <tr class="warning">
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>Pending</td>
                            </tr>
                            <tr class="danger">
                                <td>1</td>
                                <td>Origen 1</td>
                                <td>Destino 2</td>
                                <td>Call in to confirm</td>
                            </tr>

                        </table>
                    </div>
                </div>
                
            </div>
            
            
        </div>
        
    </div>
    
    <footer>
        <div class="container">
            <row>
                <div class="col-xs-12">
                    IMAPDB. 2017
                </div>
            </row>
        </div>
    </footer>
    
    
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js"></script>
</body>
</html>
