## 1.二阶常系数齐次ODE
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



## 2.一阶线性ODE
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

## 3.正弦余弦变换
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

## 4.三角函数正交性
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

## 5.三角函数相关
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
\end{aligned}
$$






















