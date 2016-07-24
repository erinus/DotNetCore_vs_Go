package main

import "net/http"

import "github.com/gin-gonic/gin"

func main() {
    gin.SetMode(gin.ReleaseMode)

    router := gin.New()

    router.GET("/api/values", func(ctx *gin.Context) {
        ctx.JSON(http.StatusOK, []string { "value1", "value2" })
    })

    router.Run(":9000")
}
