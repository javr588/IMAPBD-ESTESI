<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>IMAPDB - Empresa - Detalle de paquete</title>

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
                <div class="clearfix">
                    <a href="mailto:contacto@imapdb.com" class="btn btn-success pull-right">Solicitar</a>
                </div>
            </div>
           
            
            <div class="row">
                
                <div class="col-md-5 col-xs-12 detalle">
                    
                    <h2>Detalle de paquete</h2>
                    
                    <div class="item">
                        <div>Información general</div>
                        <p>Aquí va el nombre del paquetes</p>
                    </div>
                    
                    <div class="item">
                        <div>Tipo de paquete</div>
                        <p>De aventura</p>
                    </div>
                    
                    <div class="row">
                        
                        <div class="col-xs-6">
                            <div class="item">
                                <div>Origen</div>
                                <p>Lima</p>
                            </div>
                        </div>
                        <div class="col-xs-6">
                            <div class="item">
                                <div>Destino</div>
                                <p>Argentina</p>
                            </div>
                        </div>
                    
                    </div>
                    
                    <div class="row">
                        
                        <div class="col-xs-6">
                            <div class="item">
                                <div>Fecha de salida</div>
                                <p>01-02-2017</p>
                            </div>
                        </div>
                        
                        <div class="col-xs-6">
                            <div class="item">
                                <div>Fecha de llegada</div>
                                <p>01-03-2017</p>
                            </div>
                        </div>
                    
                    </div>
                    
                    
                    <div class="row">
                        
                        <div class="col-xs-6">
                            <div class="item">
                                <div>Fecha de vencimiento</div>
                                <p>01-03-2017</p>
                            </div>
                        </div>
                        
                        <div class="col-xs-6">
                            <div class="item">
                                <div>Costo</div>
                                <p>$300</p>
                            </div>
                        </div>
                    
                    </div>
                    
                    
                    
                    
                    
                    
                    
                    <div class="item">
                        <img src="Views/Home/res/images/bg.jpg" width="100%" height="auto">
                    </div>
                    
                    
                    
                    
                    
                </div>
                
                <div class="col-md-7 col-xs-12">
                    <h2>Actividades</h2>
                    <div class="table-responsive">
                        <table class="table table-condensed table-hover">

                            <!--<tr>
                            <td class="active">Cotizaciones</td>
                            <td class="success">Origen</td>
                            <td class="warning">Destino</td>
                            <td class="danger">estatus</td>
                            </tr>-->
                            <thead>                            
                                <tr>
                                    <td>Tipo</td>
                                    <td>Origen</td>
                                    <td>Destino</td>
                                    <td>Fecha salida</td>
                                    <td>Fecha llegada</td>
                                    <td>Costo</td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Viaje</td>
                                    <td>Lima</td>
                                    <td>Trujillo</td>
                                    <td>01-02-2017</td>
                                    <td>01-03-2017</td>
                                    <td>$30</td>
                                </tr>
                                <tr>
                                    <td>Paseo</td>
                                    <td>Lima</td>
                                    <td>Trujillo</td>
                                    <td>01-02-2017</td>
                                    <td>01-03-2017</td>
                                    <td>$30</td>
                                </tr>
                                <tr>
                                    <td>Estadia</td>
                                    <td>Lima</td>
                                    <td>Trujillo</td>
                                    <td>01-02-2017</td>
                                    <td>01-03-2017</td>
                                    <td>$30</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    
                    <div class="detalle">
                        <h3>Calificación de paquete</h3>
                        <div class="item">
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star" aria-hidden="true"></i>
                            <i class="fa fa-star-o" aria-hidden="true"></i>
                        </div>
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
