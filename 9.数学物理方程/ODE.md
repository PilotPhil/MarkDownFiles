# 1.二阶常系数齐次ODE
$$
y^{''}+py^{'}+qy=0
$$

得特征方程：
$$
r^2+pr+q=0
$$

- 互异实根$r_1 、r_2$
  - $y=c_1e^{r_1 x}+c_2e^{r_2 x}$
- 相同实根$r$
  - $y=(c_1+c_2x)e^{rx}$
- 共轭复根$\alpha \pm i\beta$
  - $y=e^{\alpha x}(c_1 cos\beta x+c_2 sin\beta x)$



# 2.一阶线性ODE
$$
y^{'}+p(x)y=q(x)
$$

解：
$$
\begin{aligned}
y^{'}+p(x)y & = q(x)       \\
e^{\int p(x)dx}[y^{'}+p(x)y] & = q(x)e^{\int p(x)dx}       \\
[ye^{\int p(x)dx}]^{'} & = q(x)e^{\int p(x)dx}       \\
ye^{\int p(x)dx} & = \int q(x)e^{\int p(x)dx} dx+c       \\
y & = e^{-\int p(x)dx}[\int q(x)e^{\int p(x)dx} dx+c]       \\
\end{aligned}
$$

得
$$
y= e^{-\int p(x)dx}[\int q(x)e^{\int p(x)dx} dx+c]
$$

# 3.正弦余弦变换
$$
\begin{aligned}
    f(x) & =\Sigma_{n=1}^{+\infty} A_n sin\frac{n\pi}{l} x \\
    A_n  & =\frac{2}{l} \int_0^l f(x) sin\frac{n\pi}{l} dx   n=1,2,3,...\\
\end{aligned}
$$

$$
\begin{aligned}
    f(x) & =\frac{A_0}{2}+\Sigma_{n=1}^{+\infty} A_n cos\frac{n\pi}{l} x \\
    A_n  & =\frac{2}{l} \int_0^l f(x) cos\frac{n\pi}{l} dx  n=0,1,2,...\\
\end{aligned}
$$

# 4.三角函数正交性
$$
\int_{-\pi}^{\pi} sinnxsinmxdx=
\begin{cases}
    0,m\neq n\\
    \pi,m=n
\end{cases}
$$

$$
\int_{-\pi}^{\pi} cosnxcosmxdx=
\begin{cases}
    0,m\neq n\\
    \pi,m=n
\end{cases}
$$

# 5.三角函数相关
$$
\begin{aligned}
  sin\alpha cos\beta & =\frac{1}{2}[sin(\alpha+\beta)+sin(\alpha-\beta)]  \\
  cos\alpha sin\beta & =\frac{1}{2}[sin(\alpha+\beta)-sin(\alpha-\beta)]  \\
  cos\alpha cos\beta & =\frac{1}{2}[cos(\alpha+\beta)+cos(\alpha-\beta)]  \\
  sin\alpha sin\beta & =\frac{1}{2}[cos(\alpha-\beta)-cos(\alpha+\beta)]  \\
\end{aligned}
$$

$$
\begin{aligned}
  e^{j\omega t} & = cos\omega t+j sin\omega t \\
  e^{-j\omega t} & = cos\omega t-j sin\omega t \\
  2cos\omega t  & = e^{j\omega t}+e^{-j\omega t}  \\
  2jsin\omega t  & = e^{j\omega t}-e^{-j\omega t}  \\
\end{aligned}
$$


# 6.傅里叶变换及性质
$$
\begin{aligned}
  F(\alpha) & = \int_{-\infty}^{+\infty} f(x) e^{-i\alpha x} dx \\
  f(x)      & = \frac{1}{2\pi} \int_{-\infty}^{+\infty} F(\alpha) e^{i\alpha x} d\alpha   \\
\end{aligned}
$$

性质
- 线性：$F[af(x)+bg(x)]=aF[f(x)]+bF[g(x)]=aF(\alpha)+bG(\alpha)$
- 时移：$F[f(x-c)]=e^{-i\alpha c}F[f(x)]=e^{-i\alpha c}F(\alpha)$
- 频移：$F[e^{i\alpha_0 x}f(x)]=F(\alpha-\alpha_0)$
- 尺度：$F[f(cx)]=\frac{1}{|c|} F(\frac{\alpha}{c})$
- 微分：$F[f^{'}(x)]=i\alpha F[f(x)]=i\alpha F(\alpha)$
  - $F[f^{(n)}(x)]=(i\alpha)^n F[f(x)]=(i\alpha)^n F(\alpha)$
- $F[xf(x)]=i\frac{d}{d\alpha}F(\alpha)$
- $F[x^nf(x)]=i^n \frac{d^n}{d\alpha^n}F(\alpha)$
- 卷积：$f(x)*g(x)=\int_{-\infty}^{+\infty} f(x-\tau)g(\tau) d\tau$
  - $F[f(x)*g(x)]=F[f(x)]F[g(x)]=F(\alpha)G(\alpha)$
  - $F^{-1}[f(x)*g(x)]=F^{-1}[f(x)]F^{-1}[g(x)]=f(x)*g(x)$
  - $F[f(x)g(x)]=\frac{1}{2\pi}F[f(x)]*F[g(x)]=\frac{1}{2\pi}F(\alpha)*G(\alpha)$
  - $F^{-1}[F(\alpha)*g(\alpha)]=2\pi f(x)g(x)$
- Parseval能量守恒: $\int_{-\infty}^{+\infty} |f(x)|^2 dx=\frac{1}{2\pi} \int_{-\infty}^{+\infty} |F(\alpha)|^2 d\alpha$


# 7.拉普拉斯变换及性质
$$
\begin{aligned}
  F(s)=\int_0^{+\infty} f(t) e^{-st} dt
\end{aligned}
$$

性质
- 线性：$L[af(t)+bg(t)]=aF(s)+bG(s)$
- 时移：$L[f(t-t_0)]=e^{-st_0}F(s)$
- s域平移：$L[e^{s_0 t} f(t)]=F(s-s_0)$
- 微分：$L[f^{'}(t)]=sF(s)-f(0)$
  - $L[f^{(n)}(t)]=s^nF(s)-\Sigma_\lambda^{n-1} s^{n-1-\lambda}f^{(\lambda)}(0)$
- 积分：$L[\int_0^t f(\tau) d\tau]=\frac{F(s)}{s}$
- $L[t^n f(t)]=(-1)^n F^{(n)}(s)$
- 卷积：$L[f(t)*g(t)]=F(s)G(s)$
  - $L^{-1}[F(s)G(s)]=f(t)*g(t)$
















