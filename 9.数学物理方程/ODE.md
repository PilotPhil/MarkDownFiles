# 常见ODE解法

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









