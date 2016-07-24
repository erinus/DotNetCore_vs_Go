package main

import "math/rand"
import "net/http"
import "time"

import "github.com/gin-gonic/gin"

func main() {
    gin.SetMode(gin.ReleaseMode)

    router := gin.New()

    router.GET("/api/values", func(ctx *gin.Context) {
        l := make([]int32, 0)
        r := rand.New(rand.NewSource(time.Now().UnixNano()))
        for i := 0; i < 1000; i++ {
            l = append(l, r.Int31())
        }
        ctx.JSON(http.StatusOK, []string { "value1", "value2" })
    })

    router.Run(":9000")
}
